using Cryptography.ECDSA;
using EosSharp.Core.Helpers;
using EosSharp.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosSharp.Core.Providers
{
    public class LendSignProvider : ISignProvider
    {
        private readonly byte[] KeyTypeBytes = Encoding.UTF8.GetBytes("K1");
        private readonly Dictionary<string, byte[]> Keys = new Dictionary<string, byte[]>();
        public LendSignProvider(string privateKey)
        {
            var privKeyBytes = CryptoHelper.GetPrivateKeyBytesWithoutCheckSum(privateKey);
            var pubKey = CryptoHelper.PubKeyBytesToString(Secp256K1Manager.GetPublicKey(privKeyBytes, true));
            Keys.Add(pubKey, privKeyBytes);
        }
        public Task<IEnumerable<string>> GetAvailableKeys()
        {
            return Task.FromResult(Keys.Keys.AsEnumerable());
        }

        public Task<IEnumerable<string>> Sign(string chainId, IEnumerable<string> requiredKeys, byte[] signBytes, IEnumerable<string> abiNames = null)
        {
            if (requiredKeys == null)
                return Task.FromResult(new List<string>().AsEnumerable());

            var data = new List<byte[]>()
            {
                Hex.HexToBytes(chainId),
                signBytes,
                new byte[32]
            };
            var hash = Sha256Manager.GetHash(SerializationHelper.Combine(data));

            return Task.FromResult(requiredKeys.Select(key =>
            {
                var sign = Secp256K1Manager.SignCompressedCompact(hash, CryptoHelper.GetPrivateKeyBytesWithoutCheckSum(key));
                var check = new List<byte[]>() { sign, KeyTypeBytes };
                var checksum = Ripemd160Manager.GetHash(SerializationHelper.Combine(check)).Take(4).ToArray();
                var signAndChecksum = new List<byte[]>() { sign, checksum };

                return "SIG_K1_" + Base58.Encode(SerializationHelper.Combine(signAndChecksum));
            }));
        }
    }
}
