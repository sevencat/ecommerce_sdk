namespace ecommerce.sdk.douyin;

[Description("isv使用此接口批量加密之前数据库中的明文记录")]
public class OrderBatchEncryptReq : IDouyinReq<OrderBatchEncryptRsp>
{

	public string GetMethod() { return "order.batchEncrypt"; }

	public string GetUrl() { return "/order/batchEncrypt"; }

	[JsonPropertyName("batch_encrypt_list")]
	[Description("待加密列表")]
	[NotNull]
	public List<BatchEncryptListItem> BatchEncryptList { get; set; }

	public class BatchEncryptListItem
	{
		[JsonPropertyName("plain_text")]
		[Description("明文")]
		[NotNull]
		public string PlainText { get; set; }

		[JsonPropertyName("auth_id")]
		[Description("业务标识，value为抖音订单号；若是三方订单，可用三方订单号作为标识或自定义标识")]
		[NotNull]
		public string AuthId { get; set; }

		[JsonPropertyName("is_support_index")]
		[Description("是否支持密文索引")]
		[NotNull]
		public bool? IsSupportIndex { get; set; }

		[JsonPropertyName("sensitive_type")]
		[Description("加密类型；1地址加密 2姓名加密 3电话加密")]
		[NotNull]
		public short? SensitiveType { get; set; }
	}

	[JsonPropertyName("sensitive_scene")]
	[Description("加密场景：OrderCode代表订单 AftersaleCode代表售后单")]
	public string SensitiveScene { get; set; }
}

[Description("isv使用此接口批量加密之前数据库中的明文记录")]
public class OrderBatchEncryptRsp
{
	[JsonPropertyName("encrypt_infos")]
	[Description("加密之后的数据")]
	public List<EncryptInfosItem> EncryptInfos { get; set; }

	public class EncryptInfosItem
	{
		[JsonPropertyName("auth_id")]
		[Description("鉴权id")]
		public string AuthId { get; set; }

		[JsonPropertyName("cipher_text")]
		[Description("密文")]
		public string CipherText { get; set; }

		[JsonPropertyName("decrypt_text")]
		[Description("明文")]
		public string DecryptText { get; set; }

		[JsonPropertyName("err_no")]
		[Description("错误码")]
		public long ErrNo { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误描述")]
		public string ErrMsg { get; set; }
	}

	[JsonPropertyName("custom_err")]
	[Description("业务错误")]
	public CustomErrItem CustomErr { get; set; }

	public class CustomErrItem
	{
		[JsonPropertyName("err_code")]
		[Description("错误码")]
		public long ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误描述")]
		public string ErrMsg { get; set; }
	}
}
