namespace ecommerce.sdk.douyin;

[Description("使用场景：批量查询商家抖店商品信息,1、支持使用商品状态，商品类型、商品创建时间和更新时间筛选商品,2、最大支持1次查询1万条，如返回商品数据大于1万条，请增加筛选条件。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","页数从1开始","isv.parameter-invalid:2010004","请检查必传参数是否填写")]
[DouyinRetCode(20000,"系统错误","判断库存版本失败","isp.service-error:2010013","灰度时使用，现应无此报错")]
[DouyinRetCode(20000,"系统错误","查询库存失败","isp.service-error:2010001","请重试")]
[DouyinRetCode(20000,"系统错误","读取商品失败","isp.service-error:20053","请重试")]
[DouyinRetCode(50002,"业务处理失败","获取类目信息失败","isv.business-failed:2010201","请重试")]
[DouyinRetCode(50002,"业务处理失败","触发商品操作限流","isv.business-failed:2010401","请重试")]
[DouyinRetCode(50002,"业务处理失败","2010203:获取商品信息失败","isv.business-failed:2010203","请重试")]
public class ProductListV2Req : IDouyinReq<ProductListV2Rsp>
{

	public string GetMethod() { return "product.listV2"; }

	public string GetUrl() { return "/product/listV2"; }

	[JsonPropertyName("status")]
	[Description("商品在店铺中状态: 0-在线；1-下线；2-删除；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
	public long? Status { get; set; }

	[JsonPropertyName("check_status")]
	[Description("商品审核状态: 1-未提交；2-待审核；3-审核通过；4-审核未通过；5-封禁；7-审核通过待上架；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
	public long? CheckStatus { get; set; }

	[JsonPropertyName("product_type")]
	[Description("商品类型；0-普通；1-新客商品；3-虚拟；6-玉石闪购；7-云闪购 ；127-其他类型；")]
	public long? ProductType { get; set; }

	[JsonPropertyName("start_time")]
	[Description("商品创建开始时间，unix时间戳，单位：秒；")]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("商品创建结束时间，unix时间戳，单位：秒；")]
	public long? EndTime { get; set; }

	[JsonPropertyName("update_start_time")]
	[Description("商品更新开始时间，unix时间戳，单位：秒；注意：查询范围是update_start_time和update_end_time之间的数据，不包含入参时间。")]
	public long? UpdateStartTime { get; set; }

	[JsonPropertyName("update_end_time")]
	[Description("商品更新结束时间，unix时间戳，单位：秒；注意：查询范围是update_start_time和update_end_time之间的数据，不包含入参时间。")]
	public long? UpdateEndTime { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始，最大为100；page* size最大不能超过1万条")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("页数，填写范围1~100；page* size最大不能超过1万条")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("store_id")]
	[Description("小时达商家使用的门店id")]
	public long? StoreId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品标题，支持模糊匹配")]
	public string Name { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id，最大支持传入100个；")]
	public List<string> ProductId { get; set; }

	[JsonPropertyName("use_cursor")]
	[Description("是否使用游标，true 使用，false 不使用；使用游标能遍历全量商品，不会受到只能查询到10000个数据的影响。,特别说明：使用游标查询时，page字段失效，只会查询当前游标后面size条数据；根据获取查询数据为空来判断本次遍历结束；查询过程中数据发生变更，可能重复、遗漏数据；需要保证每次查询的筛选条件一致。")]
	public bool? UseCursor { get; set; }

	[JsonPropertyName("cursor_id")]
	[Description("游标id，结合use_cursor使用（use_cursor=true）;首次查询时不需要传值，每次查询结果会返回cursor_id，下一次查询时复制给该字段。当查询返回数据为空时，结束遍历。")]
	public string CursorId { get; set; }

	[JsonPropertyName("can_combine_product")]
	[Description("能否参加搭配")]
	public bool? CanCombineProduct { get; set; }

	[JsonPropertyName("lookup_option")]
	[Description("查询option")]
	public LookupOptionItem LookupOption { get; set; }

	public class LookupOptionItem
	{
		[JsonPropertyName("need_name_affix")]
		[Description("是否需要获取标题前后缀")]
		public bool? NeedNameAffix { get; set; }

		[JsonPropertyName("need_title_limit")]
		[Description("是否需要获取商品标题长度限制规则")]
		public bool? NeedTitleLimit { get; set; }
	}
}

[Description("使用场景：批量查询商家抖店商品信息,1、支持使用商品状态，商品类型、商品创建时间和更新时间筛选商品,2、最大支持1次查询1万条，如返回商品数据大于1万条，请增加筛选条件。")]
public class ProductListV2Rsp
{
	[JsonPropertyName("data")]
	[Description("商品数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("name_suffix")]
		[Description("标题后缀")]
		public string NameSuffix { get; set; }

		[JsonPropertyName("name_prefix")]
		[Description("标题前缀")]
		public string NamePrefix { get; set; }

		[JsonPropertyName("title_limit")]
		[Description("标题长度限制，长度计算逻辑：汉字算两个字符，汉字以外的其他字符都算一个字符。")]
		public TitleLimitItem TitleLimit { get; set; }

		public class TitleLimitItem
		{
			[JsonPropertyName("min_length")]
			[Description("商品标题最短长度")]
			public long MinLength { get; set; }

			[JsonPropertyName("max_length")]
			[Description("商品标题最长长度")]
			public long MaxLength { get; set; }
		}

		[JsonPropertyName("sell_num")]
		[Description("销量")]
		public long SellNum { get; set; }

		[JsonPropertyName("can_not_combine_reason")]
		[Description("不可搭配的原因，可搭配时为空")]
		public string CanNotCombineReason { get; set; }

		[JsonPropertyName("can_combine")]
		[Description("是否可搭配，只有入参传入can_combine为true才有值")]
		public bool CanCombine { get; set; }

		[JsonPropertyName("shop_category")]
		[Description("店铺装修分类")]
		public ShopCategoryItem ShopCategory { get; set; }

		public class ShopCategoryItem
		{
			[JsonPropertyName("leaf_category_ids")]
			[Description("店铺装修分类id")]
			public List<long> LeafCategoryIds { get; set; }
		}

		[JsonPropertyName("product_id")]
		[Description("商品ID，抖店系统生成，店铺下唯一")]
		public long ProductId { get; set; }

		[JsonPropertyName("status")]
		[Description("商品在店铺中状态: 0-在线；1-下线；2-删除；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
		public long Status { get; set; }

		[JsonPropertyName("check_status")]
		[Description("商品审核状态: 1-未提交；2-待审核；3-审核通过；4-审核未通过；5-封禁；7-审核通过待上架；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
		public long CheckStatus { get; set; }

		[JsonPropertyName("market_price")]
		[Description("【已废弃】划线价，单位分")]
		public long MarketPrice { get; set; }

		[JsonPropertyName("discount_price")]
		[Description("【已废弃】售价，单位分")]
		public long DiscountPrice { get; set; }

		[JsonPropertyName("img")]
		[Description("商品图片url，返回商品主图的第一张图 (主要用来辅助页面展示)")]
		public string Img { get; set; }

		[JsonPropertyName("name")]
		[Description("商品标题。 标题不规范会引起商品下架，影响您的正常销售，详见商品发布规范：https://school.jinritemai.com/doudian/web/article/101800?from=shop_article")]
		public string Name { get; set; }

		[JsonPropertyName("pay_type")]
		[Description("【已废弃】支持的支付方式：0货到付款 1在线支付 2两者都支持")]
		public long PayType { get; set; }

		[JsonPropertyName("product_type")]
		[Description("商品类型；0-普通；1-新客商品；3-虚拟；6-玉石闪购；7-云闪购 ；127-其他类型；")]
		public long ProductType { get; set; }

		[JsonPropertyName("spec_id")]
		[Description("商品规格，新增商品是全局唯一，注意：有部分历史存量商品可能存在规格复用")]
		public long SpecId { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("【已废弃】佣金比例")]
		public long CosRatio { get; set; }

		[JsonPropertyName("create_time")]
		[Description("商品创建时间，unix时间戳，单位：秒；")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("商品更新时间，unix时间戳，单位：秒；")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("out_product_id")]
		[Description("【即将废弃】外部商家编码，商家自定义字段。推荐使用，outer_product_id字段")]
		public long OutProductId { get; set; }

		[JsonPropertyName("description")]
		[Description("商品详情，最大支持50张图片，单张详情图宽高比不超2000*2000px，大小5M内，仅支持jpg/jpeg/png格式；注意：商品详情不规范，会引起商品下架，影响您的正常销售：https://school.jinritemai.com/doudian/web/article/101800?from=shop_article")]
		public string Description { get; set; }

		[JsonPropertyName("mobile")]
		[Description("【已废弃】手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("extra")]
		[Description("额外信息，如资质")]
		public string Extra { get; set; }

		[JsonPropertyName("recommend_remark")]
		[Description("【已废弃】商家推荐语")]
		public string RecommendRemark { get; set; }

		[JsonPropertyName("category_detail")]
		[Description("类目详情；商品类目id可使用【/shop/getShopCategory】查询")]
		public CategoryDetailItem CategoryDetail { get; set; }

		public class CategoryDetailItem
		{
			[JsonPropertyName("first_cid")]
			[Description("一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("fourth_cid")]
			[Description("四级类目")]
			public long FourthCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名称")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名称")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名称")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("fourth_cname")]
			[Description("四级类目名称")]
			public string FourthCname { get; set; }
		}

		[JsonPropertyName("outer_product_id")]
		[Description("外部商家编码，商家自定义字段，支持最多 255个字符")]
		public string OuterProductId { get; set; }

		[JsonPropertyName("is_package_product")]
		[Description("是否是组合商品，true-是，false-不是；")]
		public bool IsPackageProduct { get; set; }

		[JsonPropertyName("package_product_list")]
		[Description("商品关联的组合主商品ID；当is_package_product=true，返回的是组套商品的product_id； 当is_package_product=false，返回当前商品的product_id；补充返回规则：参与的组套商品，下线会展示，目前组合商品支持下线的商品作为子品进行组套，删除会展示，但重新上架组套商品时，会被从列表中删除。")]
		public List<long> PackageProductList { get; set; }

		[JsonPropertyName("sub_product_list")]
		[Description("当is_package_product=true，返回的是组套商品的子品product_id； 当is_package_product=false，不返回；补充返回规则：参与的组套商品product_id，下线会展示，目前组合商品支持下线的商品作为子品进行组套，删除会展示，但重新上架组套商品时，会被从列表中删除。")]
		public List<long> SubProductList { get; set; }

		[JsonPropertyName("channel_main_product")]
		[Description("小时达子品绑定的主品信息")]
		public ChannelMainProductItem ChannelMainProduct { get; set; }

		public class ChannelMainProductItem
		{
			[JsonPropertyName("product_id")]
			[Description("主品的商品id")]
			public long ProductId { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("店铺id")]
			public long ShopId { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("本次查询返回的商品总数")]
	public long Total { get; set; }

	[JsonPropertyName("page")]
	[Description("当前页码")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("页数（每页数量）")]
	public long Size { get; set; }

	[JsonPropertyName("cursor_id")]
	[Description("使用游标时，每次查询会返回该值，作为下次查询的入参使用。")]
	public string CursorId { get; set; }
}
