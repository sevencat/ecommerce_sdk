namespace ecommerce.sdk.douyin;

[Description("卖家在平台卖出券后同步卡券信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:000002","参数错误")]
[DouyinRetCode(20000,"系统错误","系统异常,请稍后重试","isp.service-error:030001","数据库访问异常")]
[DouyinRetCode(20000,"系统错误","系统内部异常,请求失败,等待人工处理","isp.service-error:010003","订单为空,但是券码不为空")]
[DouyinRetCode(40004,"非法的参数","请求参数和之前的参数不一致","isv.parameter-invalid:010004","幂等性校验失败,请求参数和库中已经存在的参数不一致")]
[DouyinRetCode(50002,"业务处理失败","订单包含的卡券没有完全发放完成,不允许不允许同步订单","isv.business-failed:010005","订单包含的卡券没有完全发放完成,不允许不允许同步订单")]
[DouyinRetCode(40004,"非法的参数","卡券为空","isv.parameter-invalid:010006","卡券为空")]
[DouyinRetCode(40004,"非法的参数","履约单为空","isv.parameter-invalid:020010","履约单为空，请检查")]
[DouyinRetCode(50002,"业务处理失败","010013:并发请求,请稍后重试","isv.business-failed:010013","010013:并发请求,请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","010023:校验发放卡券数量错误","isv.business-failed:010023","010023:校验发放卡券数量错误")]
[DouyinRetCode(50002,"业务处理失败","010020:卡券映射信息重入错误","isv.business-failed:010020","010020:卡券映射信息重入错误")]
[DouyinRetCode(50002,"业务处理失败","010012:卡券同步超出24小时","isv.business-failed:010012","010012:卡券同步超出24小时")]
[DouyinRetCode(50002,"业务处理失败","000006:类型转换错误","isv.business-failed:000006","000006:类型转换错误")]
[DouyinRetCode(50002,"业务处理失败","020007:履约单查询异常","isv.business-failed:020007","020007:履约单查询异常")]
[DouyinRetCode(50002,"业务处理失败","030004:系统繁忙,请稍后重试","isv.business-failed:030004","030004:系统繁忙,请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","010008:非卡券中心业务","isv.business-failed:10008","请检查订单业务类型")]
[DouyinRetCode(50002,"业务处理失败","000008:请求已处理","isv.business-failed:000008","请求已处理")]
[DouyinRetCode(50002,"业务处理失败","000008:请求已处理","isv.business-failed:8","请求已处理")]
public class CouponsSyncV2Req : IDouyinReq<CouponsSyncV2Rsp>
{

	public string GetMethod() { return "coupons.syncV2"; }

	public string GetUrl() { return "/coupons/syncV2"; }

	[JsonPropertyName("order_id")]
	[Description("子订单id")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("sku_id")]
	[Description("skuid")]
	public long? SkuId { get; set; }

	[JsonPropertyName("cert_list")]
	[Description("卡券信息列表")]
	[NotNull]
	public List<CertListItem> CertList { get; set; }

	public class CertListItem
	{
		[JsonPropertyName("out_cert_id")]
		[Description("外部卡券id")]
		public string OutCertId { get; set; }

		[JsonPropertyName("cert_no")]
		[Description("卡券券码")]
		[NotNull]
		public string CertNo { get; set; }

		[JsonPropertyName("cert_key")]
		[Description("卡密")]
		public string CertKey { get; set; }

		[JsonPropertyName("grant_time")]
		[Description("发券时间")]
		[NotNull]
		public string GrantTime { get; set; }

		[JsonPropertyName("can_extend_valid_count")]
		[Description("可延期次数")]
		public long? CanExtendValidCount { get; set; }

		[JsonPropertyName("status")]
		[Description("状态：1未激活 2未使用")]
		public long? Status { get; set; }

		[JsonPropertyName("valid_start")]
		[Description("有效开始时间，大闸蟹场景必传")]
		public string ValidStart { get; set; }

		[JsonPropertyName("valid_end")]
		[Description("有效结束时间，大闸蟹场景必传")]
		public string ValidEnd { get; set; }
	}
}

[Description("卖家在平台卖出券后同步卡券信息")]
public class CouponsSyncV2Rsp
{
}
