namespace ecommerce.sdk.douyin;

[Description("该接口可用于识别电商用户是否为潜客和流失用户（只支持定向申请）。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数校验失败","isv.missing-parameter:4097","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","当前账户无该接口访问权限","isv.business-failed:4417","当前账户无该接口访问权限")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinDoukeCrowdMatchReq : IDouyinReq<BuyinDoukeCrowdMatchRsp>
{

	public string GetMethod() { return "buyin.doukeCrowdMatch"; }

	public string GetUrl() { return "/buyin/doukeCrowdMatch"; }

	[JsonPropertyName("device_fingerprint_info")]
	[Description("设备指纹信息")]
	[NotNull]
	public DeviceFingerprintInfoItem DeviceFingerprintInfo { get; set; }

	public class DeviceFingerprintInfoItem
	{
		[JsonPropertyName("device_fingerprint_id")]
		[Description("设备指纹ID")]
		[NotNull]
		public string DeviceFingerprintId { get; set; }

		[JsonPropertyName("device_fingerprint_type")]
		[Description("设备指纹类型。1: IDFA，2: IMEI，3: ANDROID_ID，4: GOOGLE_AID，5: OAID")]
		[NotNull]
		public int? DeviceFingerprintType { get; set; }

		[JsonPropertyName("is_md5")]
		[Description("支持md5值，原值toUppercase之后的md5值")]
		[NotNull]
		public bool? IsMd5 { get; set; }
	}
}

[Description("该接口可用于识别电商用户是否为潜客和流失用户（只支持定向申请）。")]
public class BuyinDoukeCrowdMatchRsp
{
	[JsonPropertyName("is_potential_customer")]
	[Description("是否为潜客")]
	public bool IsPotentialCustomer { get; set; }

	[JsonPropertyName("is_lost_customer")]
	[Description("是否为流失用户")]
	public bool IsLostCustomer { get; set; }
}
