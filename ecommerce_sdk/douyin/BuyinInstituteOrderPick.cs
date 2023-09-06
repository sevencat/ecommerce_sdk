namespace ecommerce.sdk.douyin;

[Description("接口用于查询机构指定日期的选品（通过抖店开放平台）订单明细信息。注意：不包括抖音应用选品GMV数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(40004,"非法的参数","请指定时间范围或订单号","isv.parameter-invalid:1033","请指定时间范围或订单号")]
[DouyinRetCode(40004,"非法的参数","无效开始时间","isv.parameter-invalid:1034","无效开始时间")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:1035","无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:1036","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(40004,"非法的参数","起始查询时间超过了最久查询限制","isv.parameter-invalid:4168","起始查询时间超过了最久查询限制")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","未查询到应用对应工具服务商信息，请联系开发者解决","isv.business-failed:8192","未查询到应用对应工具服务商信息，请联系开发者解决")]
public class BuyinInstituteOrderPickReq : IDouyinReq<BuyinInstituteOrderPickRsp>
{

	public string GetMethod() { return "buyin.instituteOrderPick"; }

	public string GetUrl() { return "/buyin/instituteOrderPick"; }

	[JsonPropertyName("size")]
	[Description("每页订单数目，取值区间： [1, 100]")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引（第一页传“0”）")]
	public string Cursor { get; set; }

	[JsonPropertyName("start_time")]
	[Description("支付时间开始，最早支持2022年01月01日")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("支付时间结束，该时间不能超过start_time+90")]
	public string EndTime { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public string ProductId { get; set; }

	[JsonPropertyName("search_type")]
	[Description("查询粒度（1-查询当前应用，2-查询应用所属工具服务商，不包括抖音应用选品GMV数据）")]
	public long? SearchType { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号。多个订单号用英文 , 分隔，最多支持100个订单号")]
	public string OrderIds { get; set; }
}

[Description("接口用于查询机构指定日期的选品（通过抖店开放平台）订单明细信息。注意：不包括抖音应用选品GMV数据")]
public class BuyinInstituteOrderPickRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("orders")]
		[Description("订单列表")]
		public List<OrdersItem> Orders { get; set; }

		public class OrdersItem
		{
			[JsonPropertyName("order_id")]
			[Description("订单号")]
			public string OrderId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public string ProductId { get; set; }

			[Description("GMV")]
			public long GMV { get; set; }

			[JsonPropertyName("estimate_amount")]
			[Description("百应订单显示金额，口径是预估结算金额（单位：分）")]
			public long EstimateAmount { get; set; }

			[JsonPropertyName("pick_extra")]
			[Description("选品自定义参数")]
			public string PickExtra { get; set; }

			[JsonPropertyName("pay_success_time")]
			[Description("支付时间")]
			public string PaySuccessTime { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页索引，返回空时结束")]
		public string Cursor { get; set; }
	}
}
