namespace ecommerce.sdk.douyin;

[Description("1、支持ISV查询当前商家可用物流公司列表;,2、支持ISV通过传入订单号的方式查询除商家维度可用的物流公司外，该订单额外可用的特殊物流公司;")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","请输入正确的参数，仔细检查输入参数是否为空或联系抖店人员排查","isp.service-error:99998","联系抖店相关人员排查")]
[DouyinRetCode(20000,"系统错误","店铺ID非法，不允许小于等于0","isp.service-error:50029","联系抖店相关人员排查")]
[DouyinRetCode(40004,"非法的参数","单次请求最多支持传入20个订单号","isv.parameter-invalid:100001","减少单次请求中传入的订单号数量后重试即可")]
[DouyinRetCode(40004,"非法的参数","订单号格式错误，请修改后重试","isv.parameter-invalid:50049","检查输入的订单号是否不是抖店内的订单号")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:99999","再次重试即可")]
[DouyinRetCode(50002,"业务处理失败","文案可能会变，参考返回的具体文案","isv.business-failed:60124","根据返回的错误信息提示做处理")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:120005","再次重试即可")]
[DouyinRetCode(50002,"业务处理失败","文案可能会变，参考返回的具体文案","isv.business-failed:70009","根据返回的错误信息提示做处理")]
[DouyinRetCode(50002,"业务处理失败","文案可能会变，参考返回的具体文案","isv.business-failed:120018","根据返回的错误信息提示做处理")]
[DouyinRetCode(50002,"业务处理失败","订单不存在，请仔细检查后重试","isv.business-failed:100009","1、如果报错“订单不存在”相关，请检查输入的订单号是否存在；2、如果是“系统繁忙”或者“系统异常”类报错，可联系抖店内部工作人员排查;")]
public class OrderQueryLogisticsCompanyListReq : IDouyinReq<OrderQueryLogisticsCompanyListRsp>
{

	public string GetMethod() { return "order.queryLogisticsCompanyList"; }

	public string GetUrl() { return "/order/queryLogisticsCompanyList"; }

	[JsonPropertyName("shop_order_ids")]
	[Description("订单号列表")]
	public List<string> ShopOrderIds { get; set; }
}

[Description("1、支持ISV查询当前商家可用物流公司列表;,2、支持ISV通过传入订单号的方式查询除商家维度可用的物流公司外，该订单额外可用的特殊物流公司;")]
public class OrderQueryLogisticsCompanyListRsp
{
	[JsonPropertyName("logistics_company_list_by_shop")]
	[Description("店铺维度所有订单能够使用的物流公司列表。")]
	public List<LogisticsCompanyListByShopItem> LogisticsCompanyListByShop { get; set; }

	public class LogisticsCompanyListByShopItem
	{
		[JsonPropertyName("code")]
		[Description("物流公司的code")]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		[Description("物流公司名称")]
		public string Name { get; set; }
	}

	[JsonPropertyName("logistics_company_list_by_order_ids")]
	[Description("除logistics_company_list_by_shop外，订单维度能够使用的物流公司列表")]
	public List<LogisticsCompanyListByOrderIdsItem> LogisticsCompanyListByOrderIds { get; set; }

	public class LogisticsCompanyListByOrderIdsItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("logistcis_company_list_by_ids")]
		[Description("除logistics_company_list_by_shop外，该订单号能够使用的物流公司列表")]
		public List<LogistcisCompanyListByIdsItem> LogistcisCompanyListByIds { get; set; }

		public class LogistcisCompanyListByIdsItem
		{
			[JsonPropertyName("code")]
			[Description("订单能够使用的物流code")]
			public string Code { get; set; }

			[JsonPropertyName("name")]
			[Description("订单能够使用的物流名称")]
			public string Name { get; set; }
		}
	}

	[JsonPropertyName("fail_shop_order_id_and_reason")]
	[Description("本次请求中失败的失败的订单号以及原因列表")]
	public List<FailShopOrderIdAndReasonItem> FailShopOrderIdAndReason { get; set; }

	public class FailShopOrderIdAndReasonItem
	{
		[JsonPropertyName("fail_code")]
		[Description("订单不存在对应的错误码")]
		public string FailCode { get; set; }

		[JsonPropertyName("fail_reason")]
		[Description("失败原因")]
		public string FailReason { get; set; }

		[JsonPropertyName("order_ids")]
		[Description("本次请求中失败的订单号")]
		public List<string> OrderIds { get; set; }
	}
}
