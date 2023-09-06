namespace ecommerce.sdk.douyin;

[Description("支持商家通过API给店铺&达人设置子商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","商品没有加入精选联盟","isv.parameter-invalid:4133","商品没有加入精选联盟")]
[DouyinRetCode(40004,"非法的参数","非法渠道信息","isv.parameter-invalid:4371","非法渠道信息")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4173","无效百应ID")]
[DouyinRetCode(40004,"非法的参数","无效uid","isv.parameter-invalid:1078","无效uid")]
[DouyinRetCode(40004,"非法的参数","渠道品为全部达人，则不允许指定达人id","isv.parameter-invalid:4366","渠道品为全部达人，则不允许指定达人id")]
[DouyinRetCode(40004,"非法的参数","渠道品设置为专属达人，只能指定一个达人","isv.parameter-invalid:4367","渠道品设置为专属达人，只能指定一个达人")]
[DouyinRetCode(40004,"非法的参数","渠道品每次最多绑定500个达人","isv.parameter-invalid:4368","渠道品每次最多绑定500个达人")]
[DouyinRetCode(40004,"非法的参数","非法渠道/未查到该渠道达人信息","isv.parameter-invalid:4369","非法渠道/未查到该渠道达人信息")]
[DouyinRetCode(40004,"非法的参数","渠道品只能绑定一个全部达人","isv.parameter-invalid:4370","渠道品只能绑定一个全部达人")]
public class BuyinBindChannelProductReq : IDouyinReq<BuyinBindChannelProductRsp>
{

	public string GetMethod() { return "buyin.bindChannelProduct"; }

	public string GetUrl() { return "/buyin/bindChannelProduct"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	[NotNull]
	public long? ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型：1: 店铺自卖，2：达人带货")]
	[NotNull]
	public int? ChannelType { get; set; }

	[JsonPropertyName("is_all")]
	[Description("是否指定全部达人/全部店播达人")]
	public bool? IsAll { get; set; }

	[JsonPropertyName("author_ids")]
	[Description("需要绑定的达人uid 指定特定达人（is_all参数为false）时，该参数生效")]
	public List<long> AuthorIds { get; set; }

	[JsonPropertyName("buyin_ids")]
	[Description("需要绑定的达人百应Id 指定特定达人（is_all参数为false）时，该参数生效")]
	public List<long> BuyinIds { get; set; }
}

[Description("支持商家通过API给店铺&达人设置子商品")]
public class BuyinBindChannelProductRsp
{
	[JsonPropertyName("success")]
	[Description("成功绑定的数量")]
	public long Success { get; set; }

	[JsonPropertyName("failed")]
	[Description("绑定失败的帐号和原因")]
	public List<FailedItem> Failed { get; set; }

	public class FailedItem
	{
		[JsonPropertyName("id")]
		[Description("绑定失败的达人id，可能是uid或者buyinId，结合id_type字段使用")]
		public long Id { get; set; }

		[JsonPropertyName("id_type")]
		[Description("id字段的类型：0: 达人uid 1:buyinID")]
		public long IdType { get; set; }

		[JsonPropertyName("reason")]
		[Description("绑定失败的原因")]
		public string Reason { get; set; }
	}
}
