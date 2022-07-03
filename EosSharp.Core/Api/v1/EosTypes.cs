// Auto Generated, do not edit.
using EosSharp.Core.DataAttributes;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace EosSharp.Core.Api.v1
{
	#region generate api types
	[ProtoContract]
	public class Symbol
    {
		
		public string name;
		
		public byte precision;
    }
	[ProtoContract]
	public class Resource
    {
		
		public Int64 used;
		
		public Int64 available;
		
		public Int64 max;
    }
	[ProtoContract]
	public class AuthorityKey
    {
		
		public string key;
		
		public Int32 weight;
    }
	[ProtoContract]
	public class AuthorityAccount
    {
		
		public PermissionLevel permission;
		
		public Int32 weight;
    }
	[ProtoContract]
	public class AuthorityWait
    {
		
		public string wait_sec;
		
		public Int32 weight;
    }
	[ProtoContract]
	public class Authority
    {
		
		public UInt32 threshold;
		
		public List<AuthorityKey> keys;
		
		public List<AuthorityAccount> accounts;
		
		public List<AuthorityWait> waits;
    }
	[ProtoContract]
	public class Permission
    {
		
		public string perm_name;
		
		public string parent;
		
		public Authority required_auth;
    }
	[ProtoContract]
	public class AbiType
    {
		
		public string new_type_name;
		
		public string type;
    }
	[ProtoContract]
	public class AbiField
    {
		
		public string name;
		
		public string type;
    }
	[ProtoContract]
	public class AbiStruct
    {
		
		public string name;
		
		public string @base;
		
		public List<AbiField> fields;
    }
	[ProtoContract]
	public class AbiAction
    {
		[AbiFieldType("name")]
		public string name;
		
		public string type;
		
		public string ricardian_contract;
    }
	[ProtoContract]
	public class AbiTable
    {
		[AbiFieldType("name")]
		public string name;
		
		public string index_type;
		
		public List<string> key_names;
		
		public List<string> key_types;
		
		public string type;
    }
	[ProtoContract]
	public class Abi
    {
		
		public string version;
		
		public List<AbiType> types;
		
		public List<AbiStruct> structs;
		
		public List<AbiAction> actions;
		
		public List<AbiTable> tables;
		
		public List<AbiRicardianClause> ricardian_clauses;
		
		public List<string> error_messages;
		
		public List<Extension> abi_extensions;
		
		public List<Variant> variants;
    }
	[ProtoContract]
	public class AbiRicardianClause
    {
		
		public string id;
		
		public string body;
    }
	[ProtoContract]
	public class CurrencyStat
    {
		
		public string supply;
		
		public string max_supply;
		
		public string issuer;
    }
	[ProtoContract]
	public class Producer
    {
		[AbiFieldType("name")]
		public string owner;
		[AbiFieldType("float64")]
		public double total_votes;
		[AbiFieldType("public_key")]
		public string producer_key;
		
		public bool is_active;
		
		public string url;
		
		public UInt32 unpaid_blocks;
		
		public UInt64 last_claim_time;
		
		public UInt16 location;
    }
	[ProtoContract]
	public class ScheduleProducers
    {
		
		public string producer_name;
		
		public string block_signing_key;
    }
	[ProtoContract]
	public class Schedule
    {
		
		public UInt32? version;
		
		public List<ScheduleProducers> producers;
    }
	[ProtoContract]
	public class PermissionLevel
    {
		
		public string actor;
		
		public string permission;
    }
	[ProtoContract]
	public class Extension
    {
		
		public UInt16 type;
		
		public byte[] data;
    }
	[ProtoContract]
	public class Variant
    {
		
		public string name;
		
		public List<string> types;
    }
	[ProtoContract]
	public class Action
    {
		
		public string account;
		
		public string name;
		
		public List<PermissionLevel> authorization;
		
		public object data;
		
		public string hex_data;
    }
	[ProtoContract]
	public class Transaction
    {
		
		public DateTime expiration;
		
		public UInt16 ref_block_num;
		
		public UInt32 ref_block_prefix;
		
		public UInt32 max_net_usage_words;
		
		public byte max_cpu_usage_ms;
		
		public UInt32 delay_sec;
		
		public List<Action> context_free_actions = new List<Action>();
		
		public List<Action> actions = new List<Action>();
		
		public List<Extension> transaction_extensions = new List<Extension>();
    }
	[ProtoContract]
	public class ScheduledTransaction
    {
		
		public string trx_id;
		
		public string sender;
		
		public string sender_id;
		
		public string payer;
		
		public DateTime? delay_until;
		
		public DateTime? expiration;
		
		public DateTime? published;
		
		public Object transaction;
    }
	[ProtoContract]
	public class Receipt
    {
		
		public string receiver;
		
		public string act_digest;
		
		public UInt64? global_sequence;
		
		public UInt64? recv_sequence;
		
		public List<List<object>> auth_sequence;
		
		public UInt64? code_sequence;
		
		public UInt64? abi_sequence;
    }
	[ProtoContract]
	public class ActionTrace
    {
		
		public Receipt receipt;
		
		public Action act;
		
		public UInt32? elapsed;
		
		public UInt32? cpu_usage;
		
		public string console;
		
		public UInt32? total_cpu_usage;
		
		public string trx_id;
		
		public List<ActionTrace> inline_traces;
    }
	[ProtoContract]
	public class GlobalAction
    {
		
		public UInt64? global_action_seq;
		
		public UInt64? account_action_seq;
		
		public UInt32? block_num;
		
		public DateTime? block_time;
		
		public ActionTrace action_trace;
    }
	[ProtoContract]
	public class TransactionReceipt
    {
		
		public string status;
		
		public UInt32? cpu_usage_us;
		
		public UInt32? net_usage_words;
		
		public object trx;
    }
	[ProtoContract]
	public class ProcessedTransaction
    {
		
		public string id;
		
		public TransactionReceipt receipt;
		
		public UInt32 elapsed;
		
		public UInt32 net_usage;
		
		public bool scheduled;
		
		public string except;
		
		public List<ActionTrace> action_traces;
    }
	[ProtoContract]
	public class DetailedTransaction
    {
		
		public TransactionReceipt receipt;
		
		public Transaction trx;
    }
	[ProtoContract]
	public class PackedTransaction
    {
		
		public string compression;
		
		public List<object> context_free_data;
		
		public string id;
		
		public string packed_context_free_data;
		
		public string packed_trx;
		
		public List<string> signatures;
		
		public Transaction transaction;
    }
	[ProtoContract]
	public class RefundRequest
    {
		
		public string cpu_amount;
		
		public string net_amount;
    }
	[ProtoContract]
	public class SelfDelegatedBandwidth
    {
		
		public string cpu_weight;
		
		public string from;
		
		public string net_weight;
		
		public string to;
    }
	[ProtoContract]
	public class TotalResources
    {
		
		public string cpu_weight;
		
		public string net_weight;
		
		public string owner;
		
		public UInt64? ram_bytes;
    }
	[ProtoContract]
	public class VoterInfo
    {
		
		public bool? is_proxy;
		
		public double? last_vote_weight;
		
		public string owner;
		
		public List<string> producers;
		
		public double? proxied_vote_weight;
		
		public string proxy;
		
		public UInt64? staked;
    }
	[ProtoContract]
	public class ExtendedAsset
    {
		
		public string quantity;
		
		public string contract;
    }
	[ProtoContract]
	public class TableByScopeResultRow
    {
		
		public string code;
		
		public string scope;
		
		public string table;
		
		public string payer;
		
		public UInt32? count;
    }
	[ProtoContract]
	public class BlockHeader
    {
		
		public DateTime timestamp;
		
		public string producer;
		
		public UInt32 confirmed;
		
		public string previous;
		
		public string transaction_mroot;
		
		public string action_mroot;
		
		public UInt32 schedule_version;
		
		public object new_producers;
		
		public object header_extensions;
    }
	[ProtoContract]
	public class SignedBlockHeader
    {
		
		public DateTime timestamp;
		
		public string producer;
		
		public UInt32 confirmed;
		
		public string previous;
		
		public string transaction_mroot;
		
		public string action_mroot;
		
		public UInt32 schedule_version;
		
		public object new_producers;
		
		public object header_extensions;
		
		public string producer_signature;
    }
	[ProtoContract]
	public class Merkle
    {
		
		public List<string> _active_nodes;
		
		public UInt32 _node_count;
    }
	[ProtoContract]
	public class ActivedProtocolFeatures
    {
		
		public List<string> protocol_features;
    }
	#endregion

	#region generate api method types
	[ProtoContract]
    public class GetInfoResponse
    {
 
		public string server_version;
 
		public string chain_id;
 
		public UInt32 head_block_num;
 
		public UInt32 last_irreversible_block_num;
 
		public string last_irreversible_block_id;
 
		public string head_block_id;
 
		public DateTime head_block_time;
 
		public string head_block_producer;
 
		public string virtual_block_cpu_limit;
 
		public string virtual_block_net_limit;
 
		public string block_cpu_limit;
 
		public string block_net_limit;
    }
	[ProtoContract]
    public class GetAccountRequest
    {
		public string account_name;
    }
	[ProtoContract]
    public class GetAccountResponse
    {
 
		public string account_name;
 
		public UInt32 head_block_num;
 
		public DateTime head_block_time;
 
		public bool privileged;
 
		public DateTime last_code_update;
 
		public DateTime created;
 
		public Int64 ram_quota;
 
		public Int64 net_weight;
 
		public Int64 cpu_weight;
 
		public Resource net_limit;
 
		public Resource cpu_limit;
 
		public UInt64 ram_usage;
 
		public List<Permission> permissions;
 
		public RefundRequest refund_request;
 
		public SelfDelegatedBandwidth self_delegated_bandwidth;
 
		public TotalResources total_resources;
 
		public VoterInfo voter_info;
    }
	[ProtoContract]
    public class GetCodeRequest
    {
		public string account_name;
		public bool code_as_wasm;
    }
	[ProtoContract]
    public class GetCodeResponse
    {
 
		public string account_name;
 
		public string wast;
 
		public string wasm;
 
		public string code_hash;
 
		public Abi abi;
    }
	[ProtoContract]
    public class GetAbiRequest
    {
		public string account_name;
    }
	[ProtoContract]
    public class GetAbiResponse
    {
 
		public string account_name;
 
		public Abi abi;
    }
	[ProtoContract]
    public class GetRawCodeAndAbiRequest
    {
		public string account_name;
    }
	[ProtoContract]
    public class GetRawCodeAndAbiResponse
    {
 
		public string account_name;
 
		public string wasm;
 
		public string abi;
    }
	//[ProtoContract]
	[ProtoContract]
    public class GetRawAbiRequest
    {
        [ProtoMember(1)] public string account_name;
        [ProtoMember(2)] public string abi_hash;
    }
	//[ProtoContract]
    [ProtoContract]
    public class GetRawAbiResponse
    {

        [ProtoMember(1)] public string account_name;

        [ProtoMember(2)] public string code_hash;

        [ProtoMember(3)] public string abi_hash;

        [ProtoMember(4)] public string abi;
    }
	[ProtoContract]
    public class AbiJsonToBinRequest
    {
		public string code;
		public string action;
		public object args;
    }
	[ProtoContract]
    public class AbiJsonToBinResponse
    {
 
		public string binargs;
    }
	[ProtoContract]
    public class AbiBinToJsonRequest
    {
		public string code;
		public string action;
		public string binargs;
    }
	[ProtoContract]
    public class AbiBinToJsonResponse
    {
 
		public object args;
    }
	[ProtoContract]
    public class GetRequiredKeysRequest
    {
		public Transaction transaction;
		public List<string> available_keys;
    }
	[ProtoContract]
    public class GetRequiredKeysResponse
    {
 
		public List<string> required_keys;
    }
	[ProtoContract]
    public class GetBlockRequest
    {
		public string block_num_or_id;
    }
	[ProtoContract]
    public class GetBlockResponse
    {
 
		public DateTime timestamp;
 
		public string producer;
 
		public UInt32 confirmed;
 
		public string previous;
 
		public string transaction_mroot;
 
		public string action_mroot;
 
		public UInt32 schedule_version;
 
		public Schedule new_producers;
 
		public List<Extension> block_extensions;
 
		public List<Extension> header_extensions;
 
		public string producer_signature;
 
		public List<TransactionReceipt> transactions;
 
		public string id;
 
		public UInt32 block_num;
 
		public UInt32 ref_block_prefix;
    }
	[ProtoContract]
    public class GetBlockHeaderStateRequest
    {
		public string block_num_or_id;
    }
	[ProtoContract]
    public class GetBlockHeaderStateResponse
    {
 
		public Schedule active_schedule;
 
		public UInt32 bft_irreversible_blocknum;
 
		public UInt32 block_num;
 
		public string block_signing_key;
 
		public Merkle blockroot_merkle;
 
		public List<UInt32> confirm_count;
 
		public object confirmations;
 
		public UInt32 dpos_irreversible_blocknum;
 
		public UInt32 dpos_proposed_irreversible_blocknum;
 
		public SignedBlockHeader header;
 
		public string id;
 
		public Schedule pending_schedule;
 
		public ActivedProtocolFeatures activated_protocol_features;
 
		public List<List<string>> producer_to_last_produced;
 
		public List<List<string>> producer_to_last_implied_irb;
    }
	[ProtoContract]
    public class GetTableRowsRequest
    {
		public bool json = false;
		public string code;
		public string scope;
		public string table;
		public string table_key;
		public string lower_bound = "0";
		public string upper_bound = "-1";
		public Int32 limit = 10;
		public string key_type;
		public string index_position;
		public string encode_type = "dec";
		public bool reverse;
		public bool show_payer;
    }
	[ProtoContract]
    public class GetTableRowsResponse
    {
 
		public List<object> rows;
 
		public bool more;
    }
	[ProtoContract]
    public class GetTableRowsResponse<TRowType>
    {
   
		public List<TRowType> rows;
   
		public bool more;
    }
	[ProtoContract]
    public class GetTableByScopeRequest
    {
		public string code;
		public string table;
		public string lower_bound;
		public string upper_bound;
		public Int32 limit = 10;
		public bool reverse;
    }
	[ProtoContract]
    public class GetTableByScopeResponse
    {
 
		public List<TableByScopeResultRow> rows;
 
		public string more;
    }
	[ProtoContract]
    public class GetCurrencyBalanceRequest
    {
		public string code;
		public string account;
		public string symbol;
    }
	[ProtoContract]
    public class GetCurrencyBalanceResponse
    {
 
		public List<string> assets;
    }
	[ProtoContract]
    public class GetCurrencyStatsRequest
    {
		public string code;
		public string symbol;
    }
	[ProtoContract]
    public class GetCurrencyStatsResponse
    {
 
		public Dictionary<string, CurrencyStat> stats;
    }
	[ProtoContract]
    public class GetProducersRequest
    {
		public bool json = false;
		public string lower_bound;
		public Int32 limit = 50;
    }
	[ProtoContract]
    public class GetProducersResponse
    {
 
		public List<object> rows;
 
		public double total_producer_vote_weight;
 
		public string more;
    }
	[ProtoContract]
    public class GetProducerScheduleResponse
    {
 
		public Schedule active;
 
		public Schedule pending;
 
		public Schedule proposed;
    }
	[ProtoContract]
    public class GetScheduledTransactionsRequest
    {
		public bool json = false;
		public string lower_bound;
		public Int32 limit = 50;
    }
	[ProtoContract]
    public class GetScheduledTransactionsResponse
    {
 
		public List<ScheduledTransaction> transactions;
 
		public string more;
    }
	[ProtoContract]
    public class PushTransactionRequest
    {
		public string[] signatures;
		public UInt32 compression;
		public string packed_context_free_data;
		public string packed_trx;
		public Transaction transaction;
    }
	[ProtoContract]
    public class PushTransactionResponse
    {
 
		public string transaction_id;
 
		public ProcessedTransaction processed;
    }
	[ProtoContract]
    public class GetActionsRequest
    {
		public string account_name;
		public Int32 pos;
		public Int32 offset;
    }
	[ProtoContract]
    public class GetActionsResponse
    {
 
		public List<GlobalAction> actions;
 
		public UInt32 last_irreversible_block;
 
		public bool time_limit_exceeded_error;
    }
	[ProtoContract]
    public class GetTransactionRequest
    {
		public string id;
		public UInt32? block_num_hint;
    }
	[ProtoContract]
    public class GetTransactionResponse
    {
 
		public string id;
 
		public DetailedTransaction trx;
 
		public DateTime block_time;
 
		public UInt32 block_num;
 
		public UInt32 last_irreversible_block;
 
		public List<ActionTrace> traces;
    }
	[ProtoContract]
    public class GetKeyAccountsRequest
    {
		public string public_key;
    }
	[ProtoContract]
    public class GetKeyAccountsResponse
    {
 
		public List<string> account_names;
    }
	[ProtoContract]
    public class GetControlledAccountsRequest
    {
		public string controlling_account;
    }
	[ProtoContract]
    public class GetControlledAccountsResponse
    {
 
		public List<string> controlled_accounts;
    }
	#endregion
}

