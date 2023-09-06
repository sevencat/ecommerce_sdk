namespace ecommerce.sdk.douyin;

[Description("批量获取索引串接口,此接口用于批量生成索引串场景")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","业务错误: 手机号长度过长","isv.parameter-invalid:300002","请检查手机号码")]
[DouyinRetCode(40004,"非法的参数","参数错误: 输入的明文列表过长，上限为:50","isv.parameter-invalid:100000","请检查列表数据")]
[DouyinRetCode(50002,"业务处理失败","参数错误: appId缺失","isv.business-failed:100002","请检查参数")]
public class OrderBatchSearchIndexReq : IDouyinReq<OrderBatchSearchIndexRsp>
{

	public string GetMethod() { return "order.BatchSearchIndex"; }

	public string GetUrl() { return "/order/BatchSearchIndex"; }

	[JsonPropertyName("plain_text_list")]
	[Description("明文列表")]
	[NotNull]
	public List<PlainTextListItem> PlainTextList { get; set; }

	public class PlainTextListItem
	{
		[JsonPropertyName("plain_text")]
		[Description("明文")]
		[NotNull]
		public string PlainText { get; set; }

		[JsonPropertyName("encrypt_type")]
		[Description("加密类型；1地址加密 2姓名加密 3电话加密")]
		[NotNull]
		public short? EncryptType { get; set; }
	}
}

[Description("批量获取索引串接口,此接口用于批量生成索引串场景")]
public class OrderBatchSearchIndexRsp
{
	[JsonPropertyName("plain_to_encrypt_index_list")]
	[Description("明文转化为索引穿列表")]
	public List<PlainToEncryptIndexListItem> PlainToEncryptIndexList { get; set; }

	public class PlainToEncryptIndexListItem
	{
		[JsonPropertyName("plain")]
		[Description("明文")]
		public string Plain { get; set; }

		[JsonPropertyName("search_index")]
		[Description("索引串")]
		public string SearchIndex { get; set; }
	}

	[JsonPropertyName("custom_err")]
	[Description("业务错误")]
	public CustomErrItem CustomErr { get; set; }

	public class CustomErrItem
	{
		[JsonPropertyName("err_code")]
		[Description("被风控状态码")]
		public long ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("产生索引串被风控返回次信息")]
		public string ErrMsg { get; set; }
	}
}
