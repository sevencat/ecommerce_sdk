namespace ecommerce.sdk.douyin;

[Description("1、用于服务商查询已订购服务的商家/供应商等权益信息。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","权益查询失败","isv.business-failed:200","请核对应用与授权主体")]
public class RightsInfoReq : IDouyinReq<RightsInfoRsp>
{

	public string GetMethod() { return "rights.info"; }

	public string GetUrl() { return "/rights/info"; }

	[JsonPropertyName("biz_type")]
	[Description("授权主体类型，不传参默认查询店铺，2-ebill用户；3-供应商")]
	public int? BizType { get; set; }

	[JsonPropertyName("outer_biz_id")]
	[Description("外部业务ID(模板市场为模板code)，非必传，不可与service_id同传")]
	public string OuterBizId { get; set; }

	[JsonPropertyName("service_id")]
	[Description("抖店服务市场服务ID，非必传，不可与outer_biz_id同传")]
	public long? ServiceId { get; set; }
}

[Description("1、用于服务商查询已订购服务的商家/供应商等权益信息。")]
public class RightsInfoRsp
{
	[JsonPropertyName("expire_time")]
	[Description("权益到期时间")]
	public string ExpireTime { get; set; }

	[JsonPropertyName("rights_type")]
	[Description("0-试用版，1-正式版")]
	public int RightsType { get; set; }

	[JsonPropertyName("spec_type")]
	[Description("规格类型，0-版本，其他待定")]
	public int SpecType { get; set; }

	[JsonPropertyName("spec_val")]
	[Description("规格名称")]
	public string SpecVal { get; set; }
}
