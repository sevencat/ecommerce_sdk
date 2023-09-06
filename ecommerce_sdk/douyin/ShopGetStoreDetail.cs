namespace ecommerce.sdk.douyin;

[Description("单个获取门店信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","10:找不到门店","isv.business-failed:10","确认门店id是否有误")]
[DouyinRetCode(50002,"业务处理失败","参数异常","isv.business-failed:1","检查参数")]
public class ShopGetStoreDetailReq : IDouyinReq<ShopGetStoreDetailRsp>
{

	public string GetMethod() { return "shop.getStoreDetail"; }

	public string GetUrl() { return "/shop/getStoreDetail"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("is_need_poi_audit_info")]
	[Description("是否需要poi审核信息，注：只要审核状态的审核不要传true，需要详细的提交信息时传true")]
	public bool? IsNeedPoiAuditInfo { get; set; }

	[JsonPropertyName("is_need_rel_shop_user")]
	[Description("是否需要关联的抖店信息，注：只要shopId不要传true，需要关联店铺名称等信息时传true")]
	public bool? IsNeedRelShopUser { get; set; }

	[JsonPropertyName("is_need_charge_info")]
	[Description("是否需要负责人信息")]
	public bool? IsNeedChargeInfo { get; set; }
}

[Description("单个获取门店信息")]
public class ShopGetStoreDetailRsp
{
	[JsonPropertyName("ret_code")]
	[Description("返回错误码，非0即有错")]
	public long RetCode { get; set; }

	[JsonPropertyName("ret_msg")]
	[Description("错误信息")]
	public string RetMsg { get; set; }

	[JsonPropertyName("store_detail")]
	[Description("门店信息")]
	public StoreDetailItem StoreDetail { get; set; }

	public class StoreDetailItem
	{
		[JsonPropertyName("store")]
		[Description("门店信息")]
		public StoreItem Store { get; set; }

		public class StoreItem
		{
			[JsonPropertyName("store_id")]
			[Description("门店ID")]
			public long StoreId { get; set; }

			[JsonPropertyName("name")]
			[Description("门店名称")]
			public string Name { get; set; }

			[JsonPropertyName("store_code")]
			[Description("门店编码")]
			public string StoreCode { get; set; }

			[JsonPropertyName("rel_shop_id")]
			[Description("关联抖店Id")]
			public long RelShopId { get; set; }

			[JsonPropertyName("poi_id")]
			[Description("poiId")]
			public long PoiId { get; set; }

			[JsonPropertyName("longitude")]
			[Description("经度")]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("维度")]
			public string Latitude { get; set; }

			[JsonPropertyName("province")]
			[Description("省")]
			public string Province { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省份code")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("city")]
			[Description("市")]
			public string City { get; set; }

			[JsonPropertyName("city_code")]
			[Description("城市code")]
			public string CityCode { get; set; }

			[JsonPropertyName("district")]
			[Description("区")]
			public string District { get; set; }

			[JsonPropertyName("district_code")]
			[Description("区code")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("town")]
			[Description("街道/镇")]
			public string Town { get; set; }

			[JsonPropertyName("town_code")]
			[Description("街道/镇code")]
			public string TownCode { get; set; }

			[JsonPropertyName("address")]
			[Description("详细地址")]
			public string Address { get; set; }

			[JsonPropertyName("contact")]
			[Description("联系方式")]
			public string Contact { get; set; }

			[JsonPropertyName("open_time")]
			[Description("营业时间")]
			public OpenTimeItem OpenTime { get; set; }

			public class OpenTimeItem
			{
				[JsonPropertyName("day_map")]
				[Description("key:星期(1:周一、2:周二...7:周日）val:时间(多段用空格分隔，例08:30-11:00 13:00-17:00)")]
				public Dictionary<long,string> DayMap { get; set; }

				[JsonPropertyName("custom")]
				[Description("暂时不使用")]
				public string Custom { get; set; }
			}

			[JsonPropertyName("is_open_now")]
			[Description("当前时间是否在营业时间中，如果不在则是打烊中")]
			public bool IsOpenNow { get; set; }

			[JsonPropertyName("state")]
			[Description("绑定状态 1绑定中;2绑定成功;3:资质验证中;4账户认证中;5正常营业(c端可下单);6暂停营业")]
			public long State { get; set; }

			[JsonPropertyName("poi_audit_state")]
			[Description("poi审核子状态：1审核中;2绑定成功;3驳回;4部分通过")]
			public long PoiAuditState { get; set; }

			[JsonPropertyName("qual_state")]
			[Description("资质审核状态：0未提交；1审核中；2审核通过；3驳回")]
			public long QualState { get; set; }

			[JsonPropertyName("remit_state")]
			[Description("账户验证状态：0未提交；1验证中；2通过；3失败")]
			public long RemitState { get; set; }

			[JsonPropertyName("open_account_state")]
			[Description("开户状态：0未开户;1已开户")]
			public long OpenAccountState { get; set; }

			[JsonPropertyName("suspend_type")]
			[Description("停业类型:1商家主动操作;2平台处罚")]
			public long SuspendType { get; set; }

			[JsonPropertyName("bound_time")]
			[Description("绑定成功的时间")]
			public long BoundTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("qual_pass_time")]
			[Description("资质验证通过时间")]
			public long QualPassTime { get; set; }

			[JsonPropertyName("remit_pass_time")]
			[Description("账户验证通过时间")]
			public long RemitPassTime { get; set; }

			[JsonPropertyName("open_account_time")]
			[Description("变成已开户的时间")]
			public long OpenAccountTime { get; set; }
		}

		[JsonPropertyName("rel_shop_user")]
		[Description("关联抖店信息")]
		public RelShopUserItem RelShopUser { get; set; }

		public class RelShopUserItem
		{
			[JsonPropertyName("id")]
			[Description("关联店铺ID")]
			public long Id { get; set; }

			[JsonPropertyName("shop_name")]
			[Description("店铺名称")]
			public string ShopName { get; set; }

			[JsonPropertyName("shop_charge_name")]
			[Description("商家负责人")]
			public string ShopChargeName { get; set; }

			[JsonPropertyName("toutiao_id")]
			[Description("uid")]
			public long ToutiaoId { get; set; }

			[JsonPropertyName("ocean_id")]
			[Description("商业化id")]
			public long OceanId { get; set; }

			[JsonPropertyName("operate_status")]
			[Description("营业状态，0正常营业 1停业整顿")]
			public int OperateStatus { get; set; }

			[JsonPropertyName("biz_type")]
			[Description("业务类型 0二类电商 1放心购")]
			public int BizType { get; set; }

			[JsonPropertyName("v_type")]
			[Description("资质类型 11个人 41 个体 0企业")]
			public int VType { get; set; }

			[JsonPropertyName("shop_type")]
			[Description("店铺类型 0普通,1专营,2专卖,3旗舰")]
			public int ShopType { get; set; }
		}

		[JsonPropertyName("poi_audit_info")]
		[Description("poi审核信息")]
		public PoiAuditInfoItem PoiAuditInfo { get; set; }

		public class PoiAuditInfoItem
		{
			[JsonPropertyName("poi_audit_id")]
			[Description("poi审核id")]
			public string PoiAuditId { get; set; }

			[JsonPropertyName("poi_audit_state")]
			[Description("poi审核子状态：1审核中;2绑定成功;3驳回;4部分通过")]
			public long PoiAuditState { get; set; }

			[JsonPropertyName("store_id")]
			[Description("门店ID")]
			public long StoreId { get; set; }

			[JsonPropertyName("name")]
			[Description("门店名称")]
			public string Name { get; set; }

			[JsonPropertyName("store_code")]
			[Description("门店编码")]
			public string StoreCode { get; set; }

			[JsonPropertyName("longitude")]
			[Description("经度")]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("维度")]
			public string Latitude { get; set; }

			[JsonPropertyName("province")]
			[Description("省")]
			public string Province { get; set; }

			[JsonPropertyName("city")]
			[Description("市")]
			public string City { get; set; }

			[JsonPropertyName("district")]
			[Description("区")]
			public string District { get; set; }

			[JsonPropertyName("address")]
			[Description("详细地址")]
			public string Address { get; set; }

			[JsonPropertyName("contact")]
			[Description("电话")]
			public string Contact { get; set; }

			[JsonPropertyName("open_time")]
			[Description("营业时间")]
			public OpenTimeItem OpenTime { get; set; }

			public class OpenTimeItem
			{
				[JsonPropertyName("day_map")]
				[Description("营业时间")]
				public Dictionary<long,string> DayMap { get; set; }

				[JsonPropertyName("custom")]
				[Description("暂时不使用")]
				public string Custom { get; set; }
			}

			[JsonPropertyName("reject_reason")]
			[Description("拒绝原因")]
			public string RejectReason { get; set; }

			[JsonPropertyName("town")]
			[Description("街道/镇")]
			public string Town { get; set; }
		}

		[JsonPropertyName("store_charge_info")]
		[Description("负责人信息")]
		public StoreChargeInfoItem StoreChargeInfo { get; set; }

		public class StoreChargeInfoItem
		{
			[JsonPropertyName("charge_name")]
			[Description("负责人姓名")]
			public string ChargeName { get; set; }

			[JsonPropertyName("charge_mobile")]
			[Description("负责人电话")]
			public string ChargeMobile { get; set; }
		}
	}
}
