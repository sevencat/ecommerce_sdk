namespace ecommerce.sdk.douyin;

[Description("数据推送，发起店铺补偿任务")]
public class OpenCloudDdpAddShopTaskReq : IDouyinReq<OpenCloudDdpAddShopTaskRsp>
{

	public string GetMethod() { return "openCloud.ddpAddShopTask"; }

	public string GetUrl() { return "/openCloud/ddpAddShopTask"; }

	[JsonPropertyName("biz_id")]
	[Description("业务场景枚举值（订单-1,售后-2）")]
	[NotNull]
	public long? BizId { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("start_time")]
	[Description("补偿任务开始时间，秒级时间戳")]
	[NotNull]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("补偿任务结束时间，秒级时间戳")]
	[NotNull]
	public long? EndTime { get; set; }
}

[Description("数据推送，发起店铺补偿任务")]
public class OpenCloudDdpAddShopTaskRsp
{
}
