namespace ecommerce.sdk.douyin;

[Description("该接口仅限虚拟业务使用，虚拟业务对接指南：https://bytedance.feishu.cn/docx/doxcnlqxrDostAHkmmfeo07ZGcc")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","20002:参数错误:找不到订单的审核任务","isv.business-failed:20002","修改入参")]
[DouyinRetCode(50002,"业务处理失败","20003:调用交易失败","isv.business-failed:20003","请检查请求参数")]
public class OrderReviewReq : IDouyinReq<OrderReviewRsp>
{

	public string GetMethod() { return "order.review"; }

	public string GetUrl() { return "/order/review"; }

	[JsonPropertyName("task_type")]
	[Description("表示订单审核的类型 3001 通信卡审核")]
	[NotNull]
	public long? TaskType { get; set; }

	[JsonPropertyName("reject_code")]
	[Description("0 审核通过 200001 下单身份信息180天内在该卡品运营商处重复下单，未通过审核 200002 下单身份信息已在该卡品运营商处办理了5张电话卡，未通过审核 200003 下单身份信息年龄不在16-60岁（部分卡品16-30岁），未通过审核 200004 下单地址为该卡品运营商禁售地区，未通过审核 200005 因其他原因，未能通过运营商审核，具体可联系商家")]
	[NotNull]
	public long? RejectCode { get; set; }

	[JsonPropertyName("object_id")]
	[Description("审核的单id取决于什么审核 通信卡审核 店铺单id")]
	[NotNull]
	public string ObjectId { get; set; }
}

[Description("该接口仅限虚拟业务使用，虚拟业务对接指南：https://bytedance.feishu.cn/docx/doxcnlqxrDostAHkmmfeo07ZGcc")]
public class OrderReviewRsp
{
}
