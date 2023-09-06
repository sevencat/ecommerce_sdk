namespace ecommerce.sdk.douyin;

[Description("判断一批待发货订单，哪些可以收件人信息一致，可以使用同一个包裹进行发货：,1. 批处理上限为100,2. 只支持近15天的代发货订单的合单判断；,3. 同一天创建的订单：open_address_id不同的，一定不可以合单；open_address_id相同的，一定可以合单。即同一天的订单根据open_address_id是否相同来判断是否可以合单，跨天的订单且open_address_id不同的再请求本api进行判断,4. 本api只是对订单收货地址是否相同的一个判断，并不会对订单进行合并处理")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:100000","根据提示修改入参")]
[DouyinRetCode(50002,"业务处理失败","内部错误，请重试","isv.business-failed:200101","内部错误，请重试")]
[DouyinRetCode(80000,"风控拦截","存在安全风险","isv.risk-control-failed:300011","稍后重试")]
public class OrderMergeReq : IDouyinReq<OrderMergeRsp>
{

	public string GetMethod() { return "order.merge"; }

	public string GetUrl() { return "/order/merge"; }

	[JsonPropertyName("merge_list")]
	[Description("合并需求列表，最少支持2个，最多支持100个。order_id和open_address_id必须一一对应，不可传错")]
	[NotNull]
	public List<MergeListItem> MergeList { get; set; }

	public class MergeListItem
	{
		[JsonPropertyName("order_id")]
		[Description("店铺订单id，不可重复。不支持售后单")]
		[NotNull]
		public string OrderId { get; set; }

		[JsonPropertyName("open_address_id")]
		[Description("收件人唯一id，订单列表、订单详情及售后详情API会返回，长度256以内")]
		[NotNull]
		public string OpenAddressId { get; set; }
	}
}

[Description("判断一批待发货订单，哪些可以收件人信息一致，可以使用同一个包裹进行发货：,1. 批处理上限为100,2. 只支持近15天的代发货订单的合单判断；,3. 同一天创建的订单：open_address_id不同的，一定不可以合单；open_address_id相同的，一定可以合单。即同一天的订单根据open_address_id是否相同来判断是否可以合单，跨天的订单且open_address_id不同的再请求本api进行判断,4. 本api只是对订单收货地址是否相同的一个判断，并不会对订单进行合并处理")]
public class OrderMergeRsp
{
	[JsonPropertyName("order_list")]
	[Description("合单结果。可合单的订单ID列表用逗号分隔的字符串表示。比如，1111,2222表示订单1111和订单2222可合并发货，3333表示无法合单。")]
	public List<string> OrderList { get; set; }
}
