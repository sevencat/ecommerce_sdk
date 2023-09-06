namespace ecommerce.sdk.douyin;

[Description("支持团长托管计划商品审核。需要团长授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinMHandleTrusteeshipApplyReq : IDouyinReq<BuyinMHandleTrusteeshipApplyRsp>
{

	public string GetMethod() { return "buyin.mHandleTrusteeshipApply"; }

	public string GetUrl() { return "/buyin/mHandleTrusteeshipApply"; }

	[JsonPropertyName("product_ids")]
	[Description("商品 id 列表，最多20个商品ID")]
	[NotNull]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("op_type")]
	[Description("操作类型（1：通过，2：拒绝）")]
	[NotNull]
	public int? OpType { get; set; }
}

[Description("支持团长托管计划商品审核。需要团长授权")]
public class BuyinMHandleTrusteeshipApplyRsp
{
	[JsonPropertyName("fail_item")]
	[Description("添加失败的记录（key：商品id，value：失败原因）")]
	public Dictionary<long,string> FailItem { get; set; }
}
