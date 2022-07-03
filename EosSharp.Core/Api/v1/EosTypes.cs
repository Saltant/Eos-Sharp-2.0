  

  

// Auto Generated, do not edit.
using EosSharp.Core.DataAttributes;
using System;
using System.Collections.Generic;
using ProtoBuf;

namespace EosSharp.Core.Api.v1
{
	#region generate api types
	[ProtoContract]
	public class Symbol
    {
			
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public byte precision;
    }
	[ProtoContract]
	public class Resource
    {
			
		[ProtoMember(1)] public Int64 used;
		
		[ProtoMember(2)] public Int64 available;
		
		[ProtoMember(3)] public Int64 max;
    }
	[ProtoContract]
	public class AuthorityKey
    {
			
		[ProtoMember(1)] public string key;
		
		[ProtoMember(2)] public Int32 weight;
    }
	[ProtoContract]
	public class AuthorityAccount
    {
			
		[ProtoMember(1)] public PermissionLevel permission;
		
		[ProtoMember(2)] public Int32 weight;
    }
	[ProtoContract]
	public class AuthorityWait
    {
			
		[ProtoMember(1)] public string wait_sec;
		
		[ProtoMember(2)] public Int32 weight;
    }
	[ProtoContract]
	public class Authority
    {
			
		[ProtoMember(1)] public UInt32 threshold;
		
		[ProtoMember(2)] public List<AuthorityKey> keys;
		
		[ProtoMember(3)] public List<AuthorityAccount> accounts;
		
		[ProtoMember(4)] public List<AuthorityWait> waits;
    }
	[ProtoContract]
	public class Permission
    {
			
		[ProtoMember(1)] public string perm_name;
		
		[ProtoMember(2)] public string parent;
		
		[ProtoMember(3)] public Authority required_auth;
    }
	[ProtoContract]
	public class AbiType
    {
			
		[ProtoMember(1)] public string new_type_name;
		
		[ProtoMember(2)] public string type;
    }
	[ProtoContract]
	public class AbiField
    {
			
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public string type;
    }
	[ProtoContract]
	public class AbiStruct
    {
			
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public string @base;
		
		[ProtoMember(3)] public List<AbiField> fields;
    }
	[ProtoContract]
	public class AbiAction
    {
			[AbiFieldType("name")]
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public string type;
		
		[ProtoMember(3)] public string ricardian_contract;
    }
	[ProtoContract]
	public class AbiTable
    {
			[AbiFieldType("name")]
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public string index_type;
		
		[ProtoMember(3)] public List<string> key_names;
		
		[ProtoMember(4)] public List<string> key_types;
		
		[ProtoMember(5)] public string type;
    }
	[ProtoContract]
	public class Abi
    {
			
		[ProtoMember(1)] public string version;
		
		[ProtoMember(2)] public List<AbiType> types;
		
		[ProtoMember(3)] public List<AbiStruct> structs;
		
		[ProtoMember(4)] public List<AbiAction> actions;
		
		[ProtoMember(5)] public List<AbiTable> tables;
		
		[ProtoMember(6)] public List<AbiRicardianClause> ricardian_clauses;
		
		[ProtoMember(7)] public List<string> error_messages;
		
		[ProtoMember(8)] public List<Extension> abi_extensions;
		
		[ProtoMember(9)] public List<Variant> variants;
    }
	[ProtoContract]
	public class AbiRicardianClause
    {
			
		[ProtoMember(1)] public string id;
		
		[ProtoMember(2)] public string body;
    }
	[ProtoContract]
	public class CurrencyStat
    {
			
		[ProtoMember(1)] public string supply;
		
		[ProtoMember(2)] public string max_supply;
		
		[ProtoMember(3)] public string issuer;
    }
	[ProtoContract]
	public class Producer
    {
			[AbiFieldType("name")]
		[ProtoMember(1)] public string owner;
		[AbiFieldType("float64")]
		[ProtoMember(2)] public double total_votes;
		[AbiFieldType("public_key")]
		[ProtoMember(3)] public string producer_key;
		
		[ProtoMember(4)] public bool is_active;
		
		[ProtoMember(5)] public string url;
		
		[ProtoMember(6)] public UInt32 unpaid_blocks;
		
		[ProtoMember(7)] public UInt64 last_claim_time;
		
		[ProtoMember(8)] public UInt16 location;
    }
	[ProtoContract]
	public class ScheduleProducers
    {
			
		[ProtoMember(1)] public string producer_name;
		
		[ProtoMember(2)] public string block_signing_key;
    }
	[ProtoContract]
	public class Schedule
    {
			
		[ProtoMember(1)] public UInt32? version;
		
		[ProtoMember(2)] public List<ScheduleProducers> producers;
    }
	[ProtoContract]
	public class PermissionLevel
    {
			
		[ProtoMember(1)] public string actor;
		
		[ProtoMember(2)] public string permission;
    }
	[ProtoContract]
	public class Extension
    {
			
		[ProtoMember(1)] public UInt16 type;
		
		[ProtoMember(2)] public byte[] data;
    }
	[ProtoContract]
	public class Variant
    {
			
		[ProtoMember(1)] public string name;
		
		[ProtoMember(2)] public List<string> types;
    }
	[ProtoContract]
	public class Action
    {
			
		[ProtoMember(1)] public string account;
		
		[ProtoMember(2)] public string name;
		
		[ProtoMember(3)] public List<PermissionLevel> authorization;
		
		[ProtoMember(4)] public object data;
		
		[ProtoMember(5)] public string hex_data;
    }
	[ProtoContract]
	public class Transaction
    {
			
		[ProtoMember(1)] public DateTime expiration;
		
		[ProtoMember(2)] public UInt16 ref_block_num;
		
		[ProtoMember(3)] public UInt32 ref_block_prefix;
		
		[ProtoMember(4)] public UInt32 max_net_usage_words;
		
		[ProtoMember(5)] public byte max_cpu_usage_ms;
		
		[ProtoMember(6)] public UInt32 delay_sec;
		
		[ProtoMember(7)] public List<Action> context_free_actions = new List<Action>();
		
		[ProtoMember(8)] public List<Action> actions = new List<Action>();
		
		[ProtoMember(9)] public List<Extension> transaction_extensions = new List<Extension>();
    }
	[ProtoContract]
	public class ScheduledTransaction
    {
			
		[ProtoMember(1)] public string trx_id;
		
		[ProtoMember(2)] public string sender;
		
		[ProtoMember(3)] public string sender_id;
		
		[ProtoMember(4)] public string payer;
		
		[ProtoMember(5)] public DateTime? delay_until;
		
		[ProtoMember(6)] public DateTime? expiration;
		
		[ProtoMember(7)] public DateTime? published;
		
		[ProtoMember(8)] public Object transaction;
    }
	[ProtoContract]
	public class Receipt
    {
			
		[ProtoMember(1)] public string receiver;
		
		[ProtoMember(2)] public string act_digest;
		
		[ProtoMember(3)] public UInt64? global_sequence;
		
		[ProtoMember(4)] public UInt64? recv_sequence;
		
		[ProtoMember(5)] public List<List<object>> auth_sequence;
		
		[ProtoMember(6)] public UInt64? code_sequence;
		
		[ProtoMember(7)] public UInt64? abi_sequence;
    }
	[ProtoContract]
	public class ActionTrace
    {
			
		[ProtoMember(1)] public Receipt receipt;
		
		[ProtoMember(2)] public Action act;
		
		[ProtoMember(3)] public UInt32? elapsed;
		
		[ProtoMember(4)] public UInt32? cpu_usage;
		
		[ProtoMember(5)] public string console;
		
		[ProtoMember(6)] public UInt32? total_cpu_usage;
		
		[ProtoMember(7)] public string trx_id;
		
		[ProtoMember(8)] public List<ActionTrace> inline_traces;
    }
	[ProtoContract]
	public class GlobalAction
    {
			
		[ProtoMember(1)] public UInt64? global_action_seq;
		
		[ProtoMember(2)] public UInt64? account_action_seq;
		
		[ProtoMember(3)] public UInt32? block_num;
		
		[ProtoMember(4)] public DateTime? block_time;
		
		[ProtoMember(5)] public ActionTrace action_trace;
    }
	[ProtoContract]
	public class TransactionReceipt
    {
			
		[ProtoMember(1)] public string status;
		
		[ProtoMember(2)] public UInt32? cpu_usage_us;
		
		[ProtoMember(3)] public UInt32? net_usage_words;
		
		[ProtoMember(4)] public object trx;
    }
	[ProtoContract]
	public class ProcessedTransaction
    {
			
		[ProtoMember(1)] public string id;
		
		[ProtoMember(2)] public TransactionReceipt receipt;
		
		[ProtoMember(3)] public UInt32 elapsed;
		
		[ProtoMember(4)] public UInt32 net_usage;
		
		[ProtoMember(5)] public bool scheduled;
		
		[ProtoMember(6)] public string except;
		
		[ProtoMember(7)] public List<ActionTrace> action_traces;
    }
	[ProtoContract]
	public class DetailedTransaction
    {
			
		[ProtoMember(1)] public TransactionReceipt receipt;
		
		[ProtoMember(2)] public Transaction trx;
    }
	[ProtoContract]
	public class PackedTransaction
    {
			
		[ProtoMember(1)] public string compression;
		
		[ProtoMember(2)] public List<object> context_free_data;
		
		[ProtoMember(3)] public string id;
		
		[ProtoMember(4)] public string packed_context_free_data;
		
		[ProtoMember(5)] public string packed_trx;
		
		[ProtoMember(6)] public List<string> signatures;
		
		[ProtoMember(7)] public Transaction transaction;
    }
	[ProtoContract]
	public class RefundRequest
    {
			
		[ProtoMember(1)] public string cpu_amount;
		
		[ProtoMember(2)] public string net_amount;
    }
	[ProtoContract]
	public class SelfDelegatedBandwidth
    {
			
		[ProtoMember(1)] public string cpu_weight;
		
		[ProtoMember(2)] public string from;
		
		[ProtoMember(3)] public string net_weight;
		
		[ProtoMember(4)] public string to;
    }
	[ProtoContract]
	public class TotalResources
    {
			
		[ProtoMember(1)] public string cpu_weight;
		
		[ProtoMember(2)] public string net_weight;
		
		[ProtoMember(3)] public string owner;
		
		[ProtoMember(4)] public UInt64? ram_bytes;
    }
	[ProtoContract]
	public class VoterInfo
    {
			
		[ProtoMember(1)] public bool? is_proxy;
		
		[ProtoMember(2)] public double? last_vote_weight;
		
		[ProtoMember(3)] public string owner;
		
		[ProtoMember(4)] public List<string> producers;
		
		[ProtoMember(5)] public double? proxied_vote_weight;
		
		[ProtoMember(6)] public string proxy;
		
		[ProtoMember(7)] public UInt64? staked;
    }
	[ProtoContract]
	public class ExtendedAsset
    {
			
		[ProtoMember(1)] public string quantity;
		
		[ProtoMember(2)] public string contract;
    }
	[ProtoContract]
	public class TableByScopeResultRow
    {
			
		[ProtoMember(1)] public string code;
		
		[ProtoMember(2)] public string scope;
		
		[ProtoMember(3)] public string table;
		
		[ProtoMember(4)] public string payer;
		
		[ProtoMember(5)] public UInt32? count;
    }
	[ProtoContract]
	public class BlockHeader
    {
			
		[ProtoMember(1)] public DateTime timestamp;
		
		[ProtoMember(2)] public string producer;
		
		[ProtoMember(3)] public UInt32 confirmed;
		
		[ProtoMember(4)] public string previous;
		
		[ProtoMember(5)] public string transaction_mroot;
		
		[ProtoMember(6)] public string action_mroot;
		
		[ProtoMember(7)] public UInt32 schedule_version;
		
		[ProtoMember(8)] public object new_producers;
		
		[ProtoMember(9)] public object header_extensions;
    }
	[ProtoContract]
	public class SignedBlockHeader
    {
			
		[ProtoMember(1)] public DateTime timestamp;
		
		[ProtoMember(2)] public string producer;
		
		[ProtoMember(3)] public UInt32 confirmed;
		
		[ProtoMember(4)] public string previous;
		
		[ProtoMember(5)] public string transaction_mroot;
		
		[ProtoMember(6)] public string action_mroot;
		
		[ProtoMember(7)] public UInt32 schedule_version;
		
		[ProtoMember(8)] public object new_producers;
		
		[ProtoMember(9)] public object header_extensions;
		
		[ProtoMember(10)] public string producer_signature;
    }
	[ProtoContract]
	public class Merkle
    {
			
		[ProtoMember(1)] public List<string> _active_nodes;
		
		[ProtoMember(2)] public UInt32 _node_count;
    }
	[ProtoContract]
	public class ActivedProtocolFeatures
    {
			
		[ProtoMember(1)] public List<string> protocol_features;
    }
	#endregion

	#region generate api method types
	[ProtoContract]
    public class GetInfoResponse
    {
	 
		[ProtoMember(1)] public string server_version;
 
		[ProtoMember(2)] public string chain_id;
 
		[ProtoMember(3)] public UInt32 head_block_num;
 
		[ProtoMember(4)] public UInt32 last_irreversible_block_num;
 
		[ProtoMember(5)] public string last_irreversible_block_id;
 
		[ProtoMember(6)] public string head_block_id;
 
		[ProtoMember(7)] public DateTime head_block_time;
 
		[ProtoMember(8)] public string head_block_producer;
 
		[ProtoMember(9)] public string virtual_block_cpu_limit;
 
		[ProtoMember(10)] public string virtual_block_net_limit;
 
		[ProtoMember(11)] public string block_cpu_limit;
 
		[ProtoMember(12)] public string block_net_limit;
    }
	[ProtoContract]
    public class GetAccountRequest
    {
			[ProtoMember(1)] public string account_name;
    }
	[ProtoContract]
    public class GetAccountResponse
    {
	 
		[ProtoMember(1)] public string account_name;
 
		[ProtoMember(2)] public UInt32 head_block_num;
 
		[ProtoMember(3)] public DateTime head_block_time;
 
		[ProtoMember(4)] public bool privileged;
 
		[ProtoMember(5)] public DateTime last_code_update;
 
		[ProtoMember(6)] public DateTime created;
 
		[ProtoMember(7)] public Int64 ram_quota;
 
		[ProtoMember(8)] public Int64 net_weight;
 
		[ProtoMember(9)] public Int64 cpu_weight;
 
		[ProtoMember(10)] public Resource net_limit;
 
		[ProtoMember(11)] public Resource cpu_limit;
 
		[ProtoMember(12)] public UInt64 ram_usage;
 
		[ProtoMember(13)] public List<Permission> permissions;
 
		[ProtoMember(14)] public RefundRequest refund_request;
 
		[ProtoMember(15)] public SelfDelegatedBandwidth self_delegated_bandwidth;
 
		[ProtoMember(16)] public TotalResources total_resources;
 
		[ProtoMember(17)] public VoterInfo voter_info;
    }
	[ProtoContract]
    public class GetCodeRequest
    {
			[ProtoMember(1)] public string account_name;
		[ProtoMember(2)] public bool code_as_wasm;
    }
	[ProtoContract]
    public class GetCodeResponse
    {
	 
		[ProtoMember(1)] public string account_name;
 
		[ProtoMember(2)] public string wast;
 
		[ProtoMember(3)] public string wasm;
 
		[ProtoMember(4)] public string code_hash;
 
		[ProtoMember(5)] public Abi abi;
    }
	[ProtoContract]
    public class GetAbiRequest
    {
			[ProtoMember(1)] public string account_name;
    }
	[ProtoContract]
    public class GetAbiResponse
    {
	 
		[ProtoMember(1)] public string account_name;
 
		[ProtoMember(2)] public Abi abi;
    }
	[ProtoContract]
    public class GetRawCodeAndAbiRequest
    {
			[ProtoMember(1)] public string account_name;
    }
	[ProtoContract]
    public class GetRawCodeAndAbiResponse
    {
	 
		[ProtoMember(1)] public string account_name;
 
		[ProtoMember(2)] public string wasm;
 
		[ProtoMember(3)] public string abi;
    }
	[ProtoContract]
    public class GetRawAbiRequest
    {
			[ProtoMember(1)] public string account_name;
		[ProtoMember(2)] public string abi_hash;
    }
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
			[ProtoMember(1)] public string code;
		[ProtoMember(2)] public string action;
		[ProtoMember(3)] public object args;
    }
	[ProtoContract]
    public class AbiJsonToBinResponse
    {
	 
		[ProtoMember(1)] public string binargs;
    }
	[ProtoContract]
    public class AbiBinToJsonRequest
    {
			[ProtoMember(1)] public string code;
		[ProtoMember(2)] public string action;
		[ProtoMember(3)] public string binargs;
    }
	[ProtoContract]
    public class AbiBinToJsonResponse
    {
	 
		[ProtoMember(1)] public object args;
    }
	[ProtoContract]
    public class GetRequiredKeysRequest
    {
			[ProtoMember(1)] public Transaction transaction;
		[ProtoMember(2)] public List<string> available_keys;
    }
	[ProtoContract]
    public class GetRequiredKeysResponse
    {
	 
		[ProtoMember(1)] public List<string> required_keys;
    }
	[ProtoContract]
    public class GetBlockRequest
    {
			[ProtoMember(1)] public string block_num_or_id;
    }
	[ProtoContract]
    public class GetBlockResponse
    {
	 
		[ProtoMember(1)] public DateTime timestamp;
 
		[ProtoMember(2)] public string producer;
 
		[ProtoMember(3)] public UInt32 confirmed;
 
		[ProtoMember(4)] public string previous;
 
		[ProtoMember(5)] public string transaction_mroot;
 
		[ProtoMember(6)] public string action_mroot;
 
		[ProtoMember(7)] public UInt32 schedule_version;
 
		[ProtoMember(8)] public Schedule new_producers;
 
		[ProtoMember(9)] public List<Extension> block_extensions;
 
		[ProtoMember(10)] public List<Extension> header_extensions;
 
		[ProtoMember(11)] public string producer_signature;
 
		[ProtoMember(12)] public List<TransactionReceipt> transactions;
 
		[ProtoMember(13)] public string id;
 
		[ProtoMember(14)] public UInt32 block_num;
 
		[ProtoMember(15)] public UInt32 ref_block_prefix;
    }
	[ProtoContract]
    public class GetBlockHeaderStateRequest
    {
			[ProtoMember(1)] public string block_num_or_id;
    }
	[ProtoContract]
    public class GetBlockHeaderStateResponse
    {
	 
		[ProtoMember(1)] public Schedule active_schedule;
 
		[ProtoMember(2)] public UInt32 bft_irreversible_blocknum;
 
		[ProtoMember(3)] public UInt32 block_num;
 
		[ProtoMember(4)] public string block_signing_key;
 
		[ProtoMember(5)] public Merkle blockroot_merkle;
 
		[ProtoMember(6)] public List<UInt32> confirm_count;
 
		[ProtoMember(7)] public object confirmations;
 
		[ProtoMember(8)] public UInt32 dpos_irreversible_blocknum;
 
		[ProtoMember(9)] public UInt32 dpos_proposed_irreversible_blocknum;
 
		[ProtoMember(10)] public SignedBlockHeader header;
 
		[ProtoMember(11)] public string id;
 
		[ProtoMember(12)] public Schedule pending_schedule;
 
		[ProtoMember(13)] public ActivedProtocolFeatures activated_protocol_features;
 
		[ProtoMember(14)] public List<List<string>> producer_to_last_produced;
 
		[ProtoMember(15)] public List<List<string>> producer_to_last_implied_irb;
    }
	[ProtoContract]
    public class GetTableRowsRequest
    {
			[ProtoMember(1)] public bool json = false;
		[ProtoMember(2)] public string code;
		[ProtoMember(3)] public string scope;
		[ProtoMember(4)] public string table;
		[ProtoMember(5)] public string table_key;
		[ProtoMember(6)] public string lower_bound = "0";
		[ProtoMember(7)] public string upper_bound = "-1";
		[ProtoMember(8)] public Int32 limit = 10;
		[ProtoMember(9)] public string key_type;
		[ProtoMember(10)] public string index_position;
		[ProtoMember(11)] public string encode_type = "dec";
		[ProtoMember(12)] public bool reverse;
		[ProtoMember(13)] public bool show_payer;
    }
	[ProtoContract]
    public class GetTableRowsResponse
    {
	 
		[ProtoMember(1)] public List<object> rows;
 
		[ProtoMember(2)] public bool more;
    }
	[ProtoContract]
    public class GetTableRowsResponse<TRowType>
    {
	   
		[ProtoMember(1)] public List<TRowType> rows;
   
		[ProtoMember(2)] public bool more;
    }
	[ProtoContract]
    public class GetTableByScopeRequest
    {
			[ProtoMember(1)] public string code;
		[ProtoMember(2)] public string table;
		[ProtoMember(3)] public string lower_bound;
		[ProtoMember(4)] public string upper_bound;
		[ProtoMember(5)] public Int32 limit = 10;
		[ProtoMember(6)] public bool reverse;
    }
	[ProtoContract]
    public class GetTableByScopeResponse
    {
	 
		[ProtoMember(1)] public List<TableByScopeResultRow> rows;
 
		[ProtoMember(2)] public string more;
    }
	[ProtoContract]
    public class GetCurrencyBalanceRequest
    {
			[ProtoMember(1)] public string code;
		[ProtoMember(2)] public string account;
		[ProtoMember(3)] public string symbol;
    }
	[ProtoContract]
    public class GetCurrencyBalanceResponse
    {
	 
		[ProtoMember(1)] public List<string> assets;
    }
	[ProtoContract]
    public class GetCurrencyStatsRequest
    {
			[ProtoMember(1)] public string code;
		[ProtoMember(2)] public string symbol;
    }
	[ProtoContract]
    public class GetCurrencyStatsResponse
    {
	 
		[ProtoMember(1)] public Dictionary<string, CurrencyStat> stats;
    }
	[ProtoContract]
    public class GetProducersRequest
    {
			[ProtoMember(1)] public bool json = false;
		[ProtoMember(2)] public string lower_bound;
		[ProtoMember(3)] public Int32 limit = 50;
    }
	[ProtoContract]
    public class GetProducersResponse
    {
	 
		[ProtoMember(1)] public List<object> rows;
 
		[ProtoMember(2)] public double total_producer_vote_weight;
 
		[ProtoMember(3)] public string more;
    }
	[ProtoContract]
    public class GetProducerScheduleResponse
    {
	 
		[ProtoMember(1)] public Schedule active;
 
		[ProtoMember(2)] public Schedule pending;
 
		[ProtoMember(3)] public Schedule proposed;
    }
	[ProtoContract]
    public class GetScheduledTransactionsRequest
    {
			[ProtoMember(1)] public bool json = false;
		[ProtoMember(2)] public string lower_bound;
		[ProtoMember(3)] public Int32 limit = 50;
    }
	[ProtoContract]
    public class GetScheduledTransactionsResponse
    {
	 
		[ProtoMember(1)] public List<ScheduledTransaction> transactions;
 
		[ProtoMember(2)] public string more;
    }
	[ProtoContract]
    public class PushTransactionRequest
    {
			[ProtoMember(1)] public string[] signatures;
		[ProtoMember(2)] public UInt32 compression;
		[ProtoMember(3)] public string packed_context_free_data;
		[ProtoMember(4)] public string packed_trx;
		[ProtoMember(5)] public Transaction transaction;
    }
	[ProtoContract]
    public class PushTransactionResponse
    {
	 
		[ProtoMember(1)] public string transaction_id;
 
		[ProtoMember(2)] public ProcessedTransaction processed;
    }
	[ProtoContract]
    public class GetActionsRequest
    {
			[ProtoMember(1)] public string account_name;
		[ProtoMember(2)] public Int32 pos;
		[ProtoMember(3)] public Int32 offset;
    }
	[ProtoContract]
    public class GetActionsResponse
    {
	 
		[ProtoMember(1)] public List<GlobalAction> actions;
 
		[ProtoMember(2)] public UInt32 last_irreversible_block;
 
		[ProtoMember(3)] public bool time_limit_exceeded_error;
    }
	[ProtoContract]
    public class GetTransactionRequest
    {
			[ProtoMember(1)] public string id;
		[ProtoMember(2)] public string block_num_hint;
    }
	[ProtoContract]
    public class GetTransactionResponse
    {
	 
		[ProtoMember(1)] public string id;
 
		[ProtoMember(2)] public DetailedTransaction trx;
 
		[ProtoMember(3)] public DateTime block_time;
 
		[ProtoMember(4)] public UInt32 block_num;
 
		[ProtoMember(5)] public UInt32 last_irreversible_block;
 
		[ProtoMember(6)] public List<ActionTrace> traces;
    }
	[ProtoContract]
    public class GetKeyAccountsRequest
    {
			[ProtoMember(1)] public string public_key;
    }
	[ProtoContract]
    public class GetKeyAccountsResponse
    {
	 
		[ProtoMember(1)] public List<string> account_names;
    }
	[ProtoContract]
    public class GetControlledAccountsRequest
    {
			[ProtoMember(1)] public string controlling_account;
    }
	[ProtoContract]
    public class GetControlledAccountsResponse
    {
	 
		[ProtoMember(1)] public List<string> controlled_accounts;
    }
	#endregion
}

