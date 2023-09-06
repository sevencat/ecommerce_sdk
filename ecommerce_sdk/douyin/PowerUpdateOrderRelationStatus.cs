namespace ecommerce.sdk.douyin;

[Description("用于拦截服务商家订购成功后，网点对应的服务商回传订购关系审核结果。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:40001","检查字段类型")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:40002","重新发起请求")]
[DouyinRetCode(50002,"业务处理失败","重复推送","isv.business-failed:40003","不再推送")]
[DouyinRetCode(50002,"业务处理失败","其他","isv.business-failed:40100","请找接口负责人处理")]
public class PowerUpdateOrderRelationStatusReq : IDouyinReq<PowerUpdateOrderRelationStatusRsp>
{

	public string GetMethod() { return "power.updateOrderRelationStatus"; }

	public string GetUrl() { return "/power/updateOrderRelationStatus"; }

	[JsonPropertyName("book_id")]
	[Description("订购id")]
	[NotNull]
	public string BookId { get; set; }

	[JsonPropertyName("shop_id_compatible")]
	[Description("店铺id")]
	[NotNull]
	public long? ShopIdCompatible { get; set; }

	[JsonPropertyName("netsite_code")]
	[Description("网点编码")]
	[NotNull]
	public string NetsiteCode { get; set; }

	[JsonPropertyName("result")]
	[Description("审核结果")]
	[NotNull]
	public bool? Result { get; set; }

	[JsonPropertyName("remark")]
	[Description("审核备注")]
	public string Remark { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("操作时间")]
	[NotNull]
	public string OperationTime { get; set; }
}

[Description("用于拦截服务商家订购成功后，网点对应的服务商回传订购关系审核结果。")]
public class PowerUpdateOrderRelationStatusRsp
{
}
