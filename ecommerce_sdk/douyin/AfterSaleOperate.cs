namespace ecommerce.sdk.douyin;

[Description("使用场景： ,1、调用接口前请先阅读【/afterSale/operate接口使用指南】文档：https://op.jinritemai.com/docs/question-docs/93/2752 ,2、用来对所有的售后单进行审核操作，需要通过type字段说明本次期望的操作； ,3、此接口每次最多支持对20个售后单进行操作，批量请求时任意一个售后单操作失败，整个请求均失败，推荐使用此接口每次仅操作一个售后单。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误，电话号码不合法","isv.parameter-invalid:11000","检查电话号码后重试")]
[DouyinRetCode(20000,"系统错误","存在无效的售后单","isp.service-error:10000","检查售后单后重试")]
[DouyinRetCode(20000,"系统错误","返回内容为空，重试后若错误继续存在，请联系平台","isp.service-error:10002","重试")]
[DouyinRetCode(50002,"业务处理失败","操作失败","isv.business-failed:11005","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","11001:暂不支持通过OPEN处理，请登录抖店后台人工审核售后单。如有疑问，请联系平台客服。","isv.business-failed:11001","无法重试解决")]
[DouyinRetCode(50002,"业务处理失败","售后状态错误","isv.business-failed:20309541","重新同步获取&检查售后数据，重试无效")]
public class AfterSaleOperateReq : IDouyinReq<AfterSaleOperateRsp>
{

	public string GetMethod() { return "afterSale.operate"; }

	public string GetUrl() { return "/afterSale/operate"; }

	[JsonPropertyName("type")]
	[Description("操作类型；枚举值说明文档：https://op.jinritemai.com/docs/question-docs/93/2752")]
	[NotNull]
	public int? Type { get; set; }

	[JsonPropertyName("items")]
	[Description("操作售后详情")]
	[NotNull]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("aftersale_id")]
		[Description("售后单号")]
		[NotNull]
		public string AftersaleId { get; set; }

		[JsonPropertyName("reason")]
		[Description("操作原因，拒绝操作必填")]
		public string Reason { get; set; }

		[JsonPropertyName("remark")]
		[Description("操作评论，拒绝操作必填")]
		public string Remark { get; set; }

		[JsonPropertyName("evidence")]
		[Description("操作凭证编码，当【afterSale/rejectReasonCodeList】接口响应参数evidence_need=Y时，该参数必填；使用【afterSale/rejectReasonCodeList】接口获取响应参数中的reject_reason_code字段。")]
		public List<EvidenceItem> Evidence { get; set; }

		public class EvidenceItem
		{
			[JsonPropertyName("type")]
			[Description("凭证类型，1:图片，2:视频(暂不支持)，3:音频(暂不支持展示)，4:文字(暂不支持展示)。“用户可见备注”为remark字段")]
			public int? Type { get; set; }

			[JsonPropertyName("url")]
			[Description("凭证url")]
			public string Url { get; set; }

			[JsonPropertyName("desc")]
			[Description("凭证描述")]
			public string Desc { get; set; }
		}

		[JsonPropertyName("logistics")]
		[Description("同意退货/同意换货物流信息，当前type=101，301，311是该集合需要传值。")]
		public LogisticsItem Logistics { get; set; }

		public class LogisticsItem
		{
			[JsonPropertyName("company_code")]
			[Description("物流公司code，使用【/order/logisticsCompanyList】接口获取；type=311仅换货时需要填入")]
			public string CompanyCode { get; set; }

			[JsonPropertyName("logistics_code")]
			[Description("物流单号（快递单号），仅type=311仅换货时需要填入")]
			public string LogisticsCode { get; set; }

			[JsonPropertyName("receiver_address_id")]
			[Description("商家收件地址id（推荐使用），须通过【/address/list】获取【address_id】填入。商家在同意换货/退货时，可以传入该地址id，对应的地址会买家展示进行商品退回；")]
			public long? ReceiverAddressId { get; set; }

			[JsonPropertyName("sender_address_id")]
			[Description("已废弃字段（废弃时间2022-06-10）发件地址id")]
			public long? SenderAddressId { get; set; }

			[JsonPropertyName("after_sale_address_detail")]
			[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段，商家收货地址详情；")]
			public AfterSaleAddressDetailItem AfterSaleAddressDetail { get; set; }

			public class AfterSaleAddressDetailItem
			{
				[JsonPropertyName("province_name")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段省；使用【/address/getProvince】接口获取")]
				public string ProvinceName { get; set; }

				[JsonPropertyName("city_name")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段市；需要使用【/address/getAreasByProvince】接口响应参数获取")]
				public string CityName { get; set; }

				[JsonPropertyName("town_name")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段区；需要使用【/address/getAreasByProvince】接口响应参数获取")]
				public string TownName { get; set; }

				[JsonPropertyName("street_name")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段街道名称")]
				public string StreetName { get; set; }

				[JsonPropertyName("detail")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段地址详情")]
				public string Detail { get; set; }

				[JsonPropertyName("user_name")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段收件人")]
				public string UserName { get; set; }

				[JsonPropertyName("mobile")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段联系电话，支持手机号和固定电话；固定电话需要传入区号。注意：区号和号码之间一定要传入“-”传值示例：0571-1234567；否则会报错电话号码不合法。")]
				public string Mobile { get; set; }

				[JsonPropertyName("province_id")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段省id；使用【/address/getProvince】接口获取")]
				public long? ProvinceId { get; set; }

				[JsonPropertyName("city_id")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段市id；需要使用【/address/getAreasByProvince】接口响应参数获取")]
				public long? CityId { get; set; }

				[JsonPropertyName("town_id")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段区id；需要使用【/address/getAreasByProvince】接口响应参数获取")]
				public long? TownId { get; set; }

				[JsonPropertyName("street_id")]
				[Description("【该字段将在2023年8月31日下线】，请尽快切换使用receiver_address_id字段街道id；需要使用【/address/getAreasByProvince】接口响应参数获取")]
				public long? StreetId { get; set; }
			}
		}

		[JsonPropertyName("reject_reason_code")]
		[Description("售后拒绝原因码，拒绝时必填填。通过/afterSale/rejectReasonCodeList获取")]
		public long? RejectReasonCode { get; set; }

		[JsonPropertyName("update_time")]
		[Description("用于校验售后单版本是不是最新的版本，防止售后单变更且open侧审核通过导致资损。不传就不校验，传入后就会校验isv传入的售后单版本是不是最新的版本。 需要使用【/afterSale/Detail】接口返回的update_time字段或使用售后消息推送中的update_time字段")]
		public long? UpdateTime { get; set; }
	}

	[JsonPropertyName("store_id")]
	[Description("门店ID；抖超小时达业务使用；")]
	public long? StoreId { get; set; }
}

[Description("使用场景： ,1、调用接口前请先阅读【/afterSale/operate接口使用指南】文档：https://op.jinritemai.com/docs/question-docs/93/2752 ,2、用来对所有的售后单进行审核操作，需要通过type字段说明本次期望的操作； ,3、此接口每次最多支持对20个售后单进行操作，批量请求时任意一个售后单操作失败，整个请求均失败，推荐使用此接口每次仅操作一个售后单。")]
public class AfterSaleOperateRsp
{
	[JsonPropertyName("items")]
	[Description("审核结果")]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("aftersale_id")]
		[Description("售后单号")]
		public long AftersaleId { get; set; }

		[JsonPropertyName("status_code")]
		[Description("操作结果码")]
		public long StatusCode { get; set; }

		[JsonPropertyName("status_msg")]
		[Description("操作结果描述")]
		public string StatusMsg { get; set; }
	}
}
