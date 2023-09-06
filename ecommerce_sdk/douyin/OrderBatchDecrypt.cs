namespace ecommerce.sdk.douyin;

[Description("1、接口支持解密在文档字段有“密文”红色标识字段值：收件人电话收件人姓名；详细地址；账号值；证件号；证件姓名,2、不支持解密doudian_open_id字段加密用户ID串,3、最大支持一次解密50条数据,4、cipher_infos字段待解密的密文列表示例，,入参结构{cipher_infos:[{auth_id”:”订单号”,”cipher_text”:”待解密值”},{“auth_id”:”订单号”,”cipher_text”:”待解密值”}]},入参示例{cipher_infos:[{auth_id:4933609365066313446,cipher_text:#ML3B#0BB1W4adLHYf+1s8VI3eLeeK0Kq0kc8A=#1##},,{auth_id:4933609365066313446,cipher_text:#IuxSQE5bRVX8PJCWnZJoMf62ZFoLqBrE0vhkDX1Ua3tAA1IdkoaJ1R#1##}]},5、decrypt_text响应参数手机号场景下：当is_virtual_tel=fasle时，decrypt_text返回值明文手机号，当is_virtual_tel=true时，并且解密入参是手机号时，decrypt_text返回值为虚拟号主机(phone_no_a)-虚拟号分机号(phone_no_b)的拼接值，返回示例值：”18400913965-7576”")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败,详情请看sub_msg","isv.business-failed:300003","无")]
[DouyinRetCode(50002,"业务处理失败","300008:解密接口存在部分失败","isv.business-failed:300008","无")]
public class OrderBatchDecryptReq : IDouyinReq<OrderBatchDecryptRsp>
{

	public string GetMethod() { return "order.batchDecrypt"; }

	public string GetUrl() { return "/order/batchDecrypt"; }

	[JsonPropertyName("cipher_infos")]
	[Description("待解密值集合，最大支持一次解密50条。待解密的密文列表示例，入参结构{cipher_infos:[{auth_id”:”订单号”,”cipher_text”:”待解密值”},{“auth_id”:”订单号”,”cipher_text”:”待解密值”}]}")]
	[NotNull]
	public List<CipherInfosItem> CipherInfos { get; set; }

	public class CipherInfosItem
	{
		[JsonPropertyName("auth_id")]
		[Description("订单号")]
		[NotNull]
		public string AuthId { get; set; }

		[JsonPropertyName("cipher_text")]
		[Description("待解密值")]
		[NotNull]
		public string CipherText { get; set; }
	}

	[JsonPropertyName("account_id")]
	[Description("服务商账号体系中，商户的账户ID，每个ISV下需要保证唯一，可选格式:独立生成的账户唯一标识")]
	public string AccountId { get; set; }

	[JsonPropertyName("account_type")]
	[Description("商户的账户ID类型；服务商账号中的主-main_account；子账号-sub_account；")]
	public string AccountType { get; set; }
}

[Description("1、接口支持解密在文档字段有“密文”红色标识字段值：收件人电话收件人姓名；详细地址；账号值；证件号；证件姓名,2、不支持解密doudian_open_id字段加密用户ID串,3、最大支持一次解密50条数据,4、cipher_infos字段待解密的密文列表示例，,入参结构{cipher_infos:[{auth_id”:”订单号”,”cipher_text”:”待解密值”},{“auth_id”:”订单号”,”cipher_text”:”待解密值”}]},入参示例{cipher_infos:[{auth_id:4933609365066313446,cipher_text:#ML3B#0BB1W4adLHYf+1s8VI3eLeeK0Kq0kc8A=#1##},,{auth_id:4933609365066313446,cipher_text:#IuxSQE5bRVX8PJCWnZJoMf62ZFoLqBrE0vhkDX1Ua3tAA1IdkoaJ1R#1##}]},5、decrypt_text响应参数手机号场景下：当is_virtual_tel=fasle时，decrypt_text返回值明文手机号，当is_virtual_tel=true时，并且解密入参是手机号时，decrypt_text返回值为虚拟号主机(phone_no_a)-虚拟号分机号(phone_no_b)的拼接值，返回示例值：”18400913965-7576”")]
public class OrderBatchDecryptRsp
{
	[JsonPropertyName("decrypt_infos")]
	[Description("解密列表")]
	public List<DecryptInfosItem> DecryptInfos { get; set; }

	public class DecryptInfosItem
	{
		[JsonPropertyName("auth_id")]
		[Description("业务标识；解密抖音官方密文数据使用订单号即可。如果开发者使用【/order/batchEncrypt】加密接口自定义auth_id值，需要传自己定义的标识。")]
		public string AuthId { get; set; }

		[JsonPropertyName("cipher_text")]
		[Description("密文值，具体内容参考[数据安全加密对接文档](https://op.jinritemai.com/docs/guide-docs/56/589)")]
		public string CipherText { get; set; }

		[JsonPropertyName("decrypt_text")]
		[Description("解密后明文信息；手机号场景下规则：当is_virtual_tel=fasle时，decrypt_text返回值明文手机号，当is_virtual_tel=true时，并且解密入参是手机号时，decrypt_text返回值为虚拟号主机(phone_no_a)-虚拟号分机号(phone_no_b)的拼接值，返回示例值：”18400913965-7576”")]
		public string DecryptText { get; set; }

		[JsonPropertyName("err_no")]
		[Description("错误码")]
		public long ErrNo { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误描述")]
		public string ErrMsg { get; set; }

		[JsonPropertyName("data_type")]
		[Description("加密类型 1、 地址加密类型 2、 姓名加密类型 3、 手机号加密类型 4、身份证类型 5、手机号加密类型(不会返回虚拟号)")]
		public long DataType { get; set; }

		[JsonPropertyName("is_virtual_tel")]
		[Description("手机号描述；false-真实手机号，true-虚拟手机号")]
		public bool IsVirtualTel { get; set; }

		[JsonPropertyName("expire_time")]
		[Description("虚拟号过期时间（商家自有呼叫中心记录，在到期后还需要则再次请求获取）")]
		public long ExpireTime { get; set; }

		[JsonPropertyName("phone_no_a")]
		[Description("虚拟号主机号；当is_virtual_tel=true时，有值返回，当is_virtual_tel=fasle时，返回为空；")]
		public string PhoneNoA { get; set; }

		[JsonPropertyName("phone_no_b")]
		[Description("虚拟号分机号；当is_virtual_tel=true时，有值返回，当is_virtual_tel=fasle时，返回为空；")]
		public string PhoneNoB { get; set; }
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
		[Description("错误内容描述")]
		public string ErrMsg { get; set; }
	}
}
