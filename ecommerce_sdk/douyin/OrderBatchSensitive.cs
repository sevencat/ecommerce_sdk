namespace ecommerce.sdk.douyin;

[Description("此接口用于批量脱敏场景")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误: 输入的密文列表过长，上限为:50","isv.parameter-invalid:100000","解密数据不要超出50")]
[DouyinRetCode(50002,"业务处理失败","参数错误: 输入的密文列表过长，上限为:50","isv.business-failed:300001","列表数据不要超过50")]
public class OrderBatchSensitiveReq : IDouyinReq<OrderBatchSensitiveRsp>
{

	public string GetMethod() { return "order.batchSensitive"; }

	public string GetUrl() { return "/order/batchSensitive"; }

	[JsonPropertyName("cipher_infos")]
	[Description("待脱敏的密文列表，每次调用不超过50条")]
	[NotNull]
	public List<CipherInfosItem> CipherInfos { get; set; }

	public class CipherInfosItem
	{
		[JsonPropertyName("auth_id")]
		[Description("业务标识，value为抖音订单号")]
		[NotNull]
		public string AuthId { get; set; }

		[JsonPropertyName("cipher_text")]
		[Description("密文")]
		[NotNull]
		public string CipherText { get; set; }
	}
}

[Description("此接口用于批量脱敏场景")]
public class OrderBatchSensitiveRsp
{
	[JsonPropertyName("decrypt_infos")]
	[Description("脱敏信息列表")]
	public List<DecryptInfosItem> DecryptInfos { get; set; }

	public class DecryptInfosItem
	{
		[JsonPropertyName("auth_id")]
		[Description("业务标识，value为抖音订单号")]
		public string AuthId { get; set; }

		[JsonPropertyName("cipher_text")]
		[Description("密文")]
		public string CipherText { get; set; }

		[JsonPropertyName("decrypt_text")]
		[Description("13*******64")]
		public string DecryptText { get; set; }

		[JsonPropertyName("err_no")]
		[Description("0")]
		public long ErrNo { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("")]
		public string ErrMsg { get; set; }
	}

	[JsonPropertyName("custom_err")]
	[Description("业务错误")]
	public CustomErrItem CustomErr { get; set; }

	public class CustomErrItem
	{
		[JsonPropertyName("err_code")]
		[Description("0")]
		public long ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("")]
		public string ErrMsg { get; set; }
	}
}
