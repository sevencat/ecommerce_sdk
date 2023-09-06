namespace ecommerce.sdk.douyin;

[Description("1、支持单独修改收货地址、收货人信息和收货人电话号码，,2、如果修改收货地址，那么post_addr中的所有字段都必传。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","未更改任何数据，请检查后重新提交","isv.parameter-invalid:80004","检查参数")]
[DouyinRetCode(40004,"非法的参数","订单不存在","isv.parameter-invalid:20003","校验订单之后，再提交")]
[DouyinRetCode(40004,"非法的参数","手机号格式错误，请修改后重试","isv.parameter-invalid:20002","校验参数")]
[DouyinRetCode(50002,"业务处理失败","部分发货不能修改收货地址","isv.business-failed:80001","不要重试")]
[DouyinRetCode(50002,"业务处理失败","8888:call ChangeAddress failed","isv.business-failed:8888","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","80002:详细地址长度格式不符合要求，请限制在1-60个汉字内","isv.business-failed:80002","详细地址长度格式不符合要求，请限制在1-60个汉字内")]
[DouyinRetCode(50002,"业务处理失败","40001:热门商品下单后无法修改地址","isv.business-failed:40001","热门商品下单后无法修改地址")]
[DouyinRetCode(50002,"业务处理失败","该订单部分发货，不支持修改地址。","isv.business-failed:80102","-")]
[DouyinRetCode(50002,"业务处理失败","查询订单详情错误","isv.business-failed:700007","-")]
[DouyinRetCode(50002,"业务处理失败","订单不属于当前用户","isv.business-failed:50004","-")]
[DouyinRetCode(50002,"业务处理失败","订单含有跨境商品且用户已支付，不支持修改地址。","isv.business-failed:80101","-")]
public class OrderAddressModifyReq : IDouyinReq<OrderAddressModifyRsp>
{

	public string GetMethod() { return "order.addressModify"; }

	public string GetUrl() { return "/order/addressModify"; }

	[JsonPropertyName("order_id")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("post_addr")]
	[Description("修改收货地址，post_addr中的所有字段都必传。")]
	public PostAddrItem PostAddr { get; set; }

	public class PostAddrItem
	{
		[JsonPropertyName("province")]
		[Description("省")]
		public ProvinceItem Province { get; set; }

		public class ProvinceItem
		{
			[JsonPropertyName("id")]
			[Description("省id")]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("省名称")]
			public string Name { get; set; }
		}

		[JsonPropertyName("city")]
		[Description("城市")]
		public CityItem City { get; set; }

		public class CityItem
		{
			[JsonPropertyName("id")]
			[Description("城市id")]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("城市名称")]
			public string Name { get; set; }
		}

		[JsonPropertyName("town")]
		[Description("镇")]
		public TownItem Town { get; set; }

		public class TownItem
		{
			[JsonPropertyName("id")]
			[Description("镇id")]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("镇名称")]
			public string Name { get; set; }
		}

		[JsonPropertyName("street")]
		[Description("街道")]
		public StreetItem Street { get; set; }

		public class StreetItem
		{
			[JsonPropertyName("id")]
			[Description("街道id")]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("街道名称")]
			public string Name { get; set; }
		}

		[JsonPropertyName("address_detail")]
		[Description("详细地址")]
		public string AddressDetail { get; set; }

		[JsonPropertyName("land_mark")]
		[Description("暂时未使用的字段")]
		public string LandMark { get; set; }
	}

	[JsonPropertyName("post_receiver")]
	[Description("收货人姓名")]
	public string PostReceiver { get; set; }

	[JsonPropertyName("post_tel")]
	[Description("收货人电话号码")]
	public string PostTel { get; set; }
}

[Description("1、支持单独修改收货地址、收货人信息和收货人电话号码，,2、如果修改收货地址，那么post_addr中的所有字段都必传。")]
public class OrderAddressModifyRsp
{
}
