namespace ecommerce.sdk.douyin;

[Description("上传估价,回收订单上传估价")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","状态非法，不支持流转","isv.business-failed:-1","请检查状态")]
[DouyinRetCode(50002,"业务处理失败","价格参数错误","isv.business-failed:10002","请检查价格参数信息")]
public class RecycleCreatePriceReq : IDouyinReq<RecycleCreatePriceRsp>
{

	public string GetMethod() { return "recycle.createPrice"; }

	public string GetUrl() { return "/recycle/createPrice"; }

	[JsonPropertyName("is_agree")]
	[Description("是否同意")]
	[NotNull]
	public bool? IsAgree { get; set; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单ID")]
	[NotNull]
	public string ClueOrderId { get; set; }

	[JsonPropertyName("recycle_price")]
	[Description("回收价，单位分 is_agree为true的时候recycle_price和consignment_price至少传1个 用户到手价格。")]
	public long? RecyclePrice { get; set; }

	[JsonPropertyName("consignment_price")]
	[Description("寄卖价，单位分 is_agree为true的时候recycle_price和consignment_price至少传1个 商家寄卖的价格，商家根据平台固定抽佣规则抽佣。")]
	public long? ConsignmentPrice { get; set; }

	[JsonPropertyName("refuse_reason")]
	[Description("拒绝理由 1：货品成色差； 2：货品为假； 3：其他")]
	public int? RefuseReason { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("address_id")]
	[Description("地址库id 可以通过/address/list接口获取 https://op.jinritemai.com/docs/api-docs/13/558")]
	public long? AddressId { get; set; }
}

[Description("上传估价,回收订单上传估价")]
public class RecycleCreatePriceRsp
{
}
