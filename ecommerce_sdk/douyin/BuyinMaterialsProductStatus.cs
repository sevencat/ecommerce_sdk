namespace ecommerce.sdk.douyin;

[Description("本接口用于查询某个/批商品是否投放到联盟，以及商品的推广状态和上下架状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
public class BuyinMaterialsProductStatusReq : IDouyinReq<BuyinMaterialsProductStatusRsp>
{

	public string GetMethod() { return "buyin.materialsProductStatus"; }

	public string GetUrl() { return "/buyin/materialsProductStatus"; }

	[JsonPropertyName("products")]
	[Description("商品 URL 列表，不超过50个")]
	[NotNull]
	public List<string> Products { get; set; }
}

[Description("本接口用于查询某个/批商品是否投放到联盟，以及商品的推广状态和上下架状态")]
public class BuyinMaterialsProductStatusRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("product_url")]
		[Description("商品 URL")]
		public string ProductUrl { get; set; }

		[JsonPropertyName("status")]
		[Description("上下架状态。 -2:彻底删除；-1:创建成功，提审失败（废弃）；0:在线；1:下线；2:删除")]
		public short Status { get; set; }

		[JsonPropertyName("join_alliance")]
		[Description("是否加入精选联盟")]
		public bool JoinAlliance { get; set; }

		[JsonPropertyName("promotion_status")]
		[Description("推广状态。  1:终止推广；  2.开启推广； 3.商家关闭推广计划； 4.商品下架 ； 6.平台治理关闭； 99.商家删除")]
		public long PromotionStatus { get; set; }

		[JsonPropertyName("can_share")]
		[Description("商品是否可分销")]
		public bool CanShare { get; set; }
	}
}
