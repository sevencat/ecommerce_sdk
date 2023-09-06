namespace ecommerce.sdk.douyin;

[Description("门店列表分页查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:100","请先重试，重试依然失败检查参数无误后发起咨询")]
public class ShopGetStoreListReq : IDouyinReq<ShopGetStoreListRsp>
{

	public string GetMethod() { return "shop.getStoreList"; }

	public string GetUrl() { return "/shop/getStoreList"; }

	[JsonPropertyName("store_name_list")]
	[Description("门店名称集合，不支持模糊")]
	public List<string> StoreNameList { get; set; }

	[JsonPropertyName("store_id_list")]
	[Description("门店id集合，用于查询门店信息")]
	public List<long> StoreIdList { get; set; }

	[JsonPropertyName("store_code_list")]
	[Description("门店编码，开发者自定义")]
	public List<string> StoreCodeList { get; set; }

	[JsonPropertyName("state")]
	[Description("绑定状态，1绑定中;2绑定成功;3:资质验证中;4账户认证中;5正常营业(c端可下单);6暂停营业")]
	public long? State { get; set; }

	[JsonPropertyName("poi_audit_state")]
	[Description("poi审核状态：0无提审;1审核中;2审核成功;3驳回;4部分通过")]
	public List<long> PoiAuditState { get; set; }

	[JsonPropertyName("province")]
	[Description("省")]
	public string Province { get; set; }

	[JsonPropertyName("city")]
	[Description("市")]
	public string City { get; set; }

	[JsonPropertyName("district")]
	[Description("区")]
	public string District { get; set; }

	[JsonPropertyName("poi_id_list")]
	[Description("门店poiId集合")]
	public List<long> PoiIdList { get; set; }

	[JsonPropertyName("name_fuzzy")]
	[Description("门店名称，支持模糊查询")]
	public string NameFuzzy { get; set; }

	[JsonPropertyName("store_code_fuzzy")]
	[Description("门店编码，支持模糊查询")]
	public string StoreCodeFuzzy { get; set; }

	[JsonPropertyName("qual_state")]
	[Description("资质审核状态，0未提交；1审核中；2审核通过；3驳回")]
	public long? QualState { get; set; }

	[JsonPropertyName("remit_state")]
	[Description("账户验证状态，0未提交；1验证中；2通过；3失败")]
	public long? RemitState { get; set; }

	[JsonPropertyName("open_account_state")]
	[Description("开户状态：0未开户;1已开户")]
	public long? OpenAccountState { get; set; }

	[JsonPropertyName("is_need_poi_audit_info")]
	[Description("是否需要poi审核信息，注：只要审核状态的审核不要传true，需要详细的提交信息时传true")]
	public bool? IsNeedPoiAuditInfo { get; set; }

	[JsonPropertyName("is_need_rel_shop_user")]
	[Description("是否需要关联的抖店信息，注：只要shopId不要传true，需要关联店铺名称等信息时传true")]
	public bool? IsNeedRelShopUser { get; set; }

	[JsonPropertyName("page")]
	[Description("第几页(从0开始)")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("门店列表分页查询")]
public class ShopGetStoreListRsp
{
	[JsonPropertyName("ret_code")]
	[Description("返回错误码")]
	public long RetCode { get; set; }

	[JsonPropertyName("ret_msg")]
	[Description("返回信息")]
	public string RetMsg { get; set; }

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }

	[JsonPropertyName("store_detail_list")]
	[Description("与getStoreDetail接口返回一致")]
	public List<StoreDetailListItem> StoreDetailList { get; set; }

	public class StoreDetailListItem
	{
		[JsonPropertyName("store")]
		[Description("与getStoreDetail接口返回一致")]
		public StoreItem Store { get; set; }

		public class StoreItem
		{
			[JsonPropertyName("store_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long StoreId { get; set; }

			[JsonPropertyName("name")]
			[Description("与getStoreDetail接口返回一致")]
			public string Name { get; set; }

			[JsonPropertyName("store_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string StoreCode { get; set; }

			[JsonPropertyName("rel_shop_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long RelShopId { get; set; }

			[JsonPropertyName("poi_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long PoiId { get; set; }

			[JsonPropertyName("longitude")]
			[Description("与getStoreDetail接口返回一致")]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("与getStoreDetail接口返回一致")]
			public string Latitude { get; set; }

			[JsonPropertyName("province")]
			[Description("与getStoreDetail接口返回一致")]
			public string Province { get; set; }

			[JsonPropertyName("province_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("city")]
			[Description("与getStoreDetail接口返回一致")]
			public string City { get; set; }

			[JsonPropertyName("city_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string CityCode { get; set; }

			[JsonPropertyName("district")]
			[Description("与getStoreDetail接口返回一致")]
			public string District { get; set; }

			[JsonPropertyName("district_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("town")]
			[Description("与getStoreDetail接口返回一致")]
			public string Town { get; set; }

			[JsonPropertyName("town_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string TownCode { get; set; }

			[JsonPropertyName("address")]
			[Description("与getStoreDetail接口返回一致")]
			public string Address { get; set; }

			[JsonPropertyName("contact")]
			[Description("与getStoreDetail接口返回一致")]
			public string Contact { get; set; }

			[JsonPropertyName("open_time")]
			[Description("与getStoreDetail接口返回一致")]
			public OpenTimeItem OpenTime { get; set; }

			public class OpenTimeItem
			{
				[JsonPropertyName("day_map")]
				[Description("与getStoreDetail接口返回一致")]
				public Dictionary<long,string> DayMap { get; set; }
			}

			[JsonPropertyName("is_open_now")]
			[Description("与getStoreDetail接口返回一致")]
			public bool IsOpenNow { get; set; }

			[JsonPropertyName("state")]
			[Description("与getStoreDetail接口返回一致")]
			public long State { get; set; }

			[JsonPropertyName("poi_audit_state")]
			[Description("与getStoreDetail接口返回一致")]
			public long PoiAuditState { get; set; }

			[JsonPropertyName("qual_state")]
			[Description("与getStoreDetail接口返回一致")]
			public long QualState { get; set; }

			[JsonPropertyName("remit_state")]
			[Description("与getStoreDetail接口返回一致")]
			public long RemitState { get; set; }

			[JsonPropertyName("open_account_state")]
			[Description("与getStoreDetail接口返回一致")]
			public long OpenAccountState { get; set; }

			[JsonPropertyName("suspend_type")]
			[Description("与getStoreDetail接口返回一致")]
			public long SuspendType { get; set; }

			[JsonPropertyName("bound_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long BoundTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("qual_pass_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long QualPassTime { get; set; }

			[JsonPropertyName("remit_pass_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long RemitPassTime { get; set; }

			[JsonPropertyName("open_account_time")]
			[Description("与getStoreDetail接口返回一致")]
			public long OpenAccountTime { get; set; }
		}

		[JsonPropertyName("rel_shop_user")]
		[Description("与getStoreDetail接口返回一致")]
		public RelShopUserItem RelShopUser { get; set; }

		public class RelShopUserItem
		{
			[JsonPropertyName("id")]
			[Description("与getStoreDetail接口返回一致")]
			public long Id { get; set; }

			[JsonPropertyName("shop_name")]
			[Description("与getStoreDetail接口返回一致")]
			public string ShopName { get; set; }

			[JsonPropertyName("shop_charge_name")]
			[Description("与getStoreDetail接口返回一致")]
			public string ShopChargeName { get; set; }

			[JsonPropertyName("toutiao_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long ToutiaoId { get; set; }

			[JsonPropertyName("ocean_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long OceanId { get; set; }

			[JsonPropertyName("operate_status")]
			[Description("与getStoreDetail接口返回一致")]
			public int OperateStatus { get; set; }

			[JsonPropertyName("biz_type")]
			[Description("与getStoreDetail接口返回一致")]
			public int BizType { get; set; }

			[JsonPropertyName("v_type")]
			[Description("与getStoreDetail接口返回一致")]
			public int VType { get; set; }

			[JsonPropertyName("shop_type")]
			[Description("与getStoreDetail接口返回一致")]
			public int ShopType { get; set; }
		}

		[JsonPropertyName("poi_audit_info")]
		[Description("与getStoreDetail接口返回一致")]
		public PoiAuditInfoItem PoiAuditInfo { get; set; }

		public class PoiAuditInfoItem
		{
			[JsonPropertyName("poi_audit_id")]
			[Description("与getStoreDetail接口返回一致")]
			public string PoiAuditId { get; set; }

			[JsonPropertyName("poi_audit_state")]
			[Description("与getStoreDetail接口返回一致")]
			public long PoiAuditState { get; set; }

			[JsonPropertyName("store_id")]
			[Description("与getStoreDetail接口返回一致")]
			public long StoreId { get; set; }

			[JsonPropertyName("name")]
			[Description("与getStoreDetail接口返回一致")]
			public string Name { get; set; }

			[JsonPropertyName("store_code")]
			[Description("与getStoreDetail接口返回一致")]
			public string StoreCode { get; set; }

			[JsonPropertyName("longitude")]
			[Description("与getStoreDetail接口返回一致")]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("与getStoreDetail接口返回一致")]
			public string Latitude { get; set; }

			[JsonPropertyName("province")]
			[Description("与getStoreDetail接口返回一致")]
			public string Province { get; set; }

			[JsonPropertyName("city")]
			[Description("与getStoreDetail接口返回一致")]
			public string City { get; set; }

			[JsonPropertyName("district")]
			[Description("与getStoreDetail接口返回一致")]
			public string District { get; set; }

			[JsonPropertyName("address")]
			[Description("与getStoreDetail接口返回一致")]
			public string Address { get; set; }

			[JsonPropertyName("contact")]
			[Description("与getStoreDetail接口返回一致")]
			public string Contact { get; set; }

			[JsonPropertyName("open_time")]
			[Description("与getStoreDetail接口返回一致")]
			public OpenTimeItem OpenTime { get; set; }

			public class OpenTimeItem
			{
				[JsonPropertyName("day_map")]
				[Description("与getStoreDetail接口返回一致")]
				public Dictionary<long,string> DayMap { get; set; }

				[JsonPropertyName("custom")]
				[Description("与getStoreDetail接口返回一致")]
				public string Custom { get; set; }
			}

			[JsonPropertyName("reject_reason")]
			[Description("与getStoreDetail接口返回一致")]
			public string RejectReason { get; set; }

			[JsonPropertyName("town")]
			[Description("与getStoreDetail接口返回一致")]
			public string Town { get; set; }
		}

		[JsonPropertyName("store_charge_info")]
		[Description("与getStoreDetail接口返回一致")]
		public StoreChargeInfoItem StoreChargeInfo { get; set; }

		public class StoreChargeInfoItem
		{
			[JsonPropertyName("charge_name")]
			[Description("与getStoreDetail接口返回一致")]
			public string ChargeName { get; set; }

			[JsonPropertyName("charge_mobile")]
			[Description("与getStoreDetail接口返回一致")]
			public string ChargeMobile { get; set; }
		}
	}
}
