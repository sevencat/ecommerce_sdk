namespace ecommerce.sdk.douyin;

[Description("获取产品详情")]
public class SupplyChainSupplyProductGetSupplyProductDetailReq : IDouyinReq<SupplyChainSupplyProductGetSupplyProductDetailRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.getSupplyProductDetail"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/getSupplyProductDetail"; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("外部产品id")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("query_sku_stock")]
	[Description("是否查询sku信息，默认false")]
	public bool? QuerySkuStock { get; set; }

	[JsonPropertyName("query_sku_price")]
	[Description("是否查询价格信息，默认false")]
	public bool? QuerySkuPrice { get; set; }
}

[Description("获取产品详情")]
public class SupplyChainSupplyProductGetSupplyProductDetailRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("product_id")]
		[Description("产品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("name")]
		[Description("名称")]
		public string Name { get; set; }

		[JsonPropertyName("status")]
		[Description("主状态")]
		public int Status { get; set; }

		[JsonPropertyName("sub_status")]
		[Description("子状态")]
		public int SubStatus { get; set; }

		[JsonPropertyName("outer_product_id")]
		[Description("外部产品id")]
		public string OuterProductId { get; set; }

		[JsonPropertyName("description")]
		[Description("图文详情")]
		public string Description { get; set; }

		[JsonPropertyName("extends")]
		[Description("扩展信息")]
		public Dictionary<string,string> Extends { get; set; }

		[JsonPropertyName("recommend_remark")]
		[Description("推荐信息")]
		public string RecommendRemark { get; set; }

		[JsonPropertyName("category_detail")]
		[Description("类目详情")]
		public CategoryDetailItem CategoryDetail { get; set; }

		public class CategoryDetailItem
		{
			[JsonPropertyName("first_cid")]
			[Description("111")]
			public long FirstCid { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("111")]
			public long SecondCid { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("111")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("fourth_cid")]
			[Description("111")]
			public long FourthCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("fourth_cname")]
			[Description("四级类目名")]
			public string FourthCname { get; set; }
		}

		[JsonPropertyName("img")]
		[Description("主图")]
		public string Img { get; set; }

		[JsonPropertyName("sub_img_list")]
		[Description("辅图")]
		public List<string> SubImgList { get; set; }

		[JsonPropertyName("spec_pics")]
		[Description("主规格图列表")]
		public List<string> SpecPics { get; set; }

		[JsonPropertyName("category_prop_list")]
		[Description("类目属性")]
		public List<CategoryPropListItem> CategoryPropList { get; set; }

		public class CategoryPropListItem
		{
			[JsonPropertyName("property_name")]
			[Description("属性名称")]
			public string PropertyName { get; set; }

			[JsonPropertyName("options")]
			[Description("属性值列表")]
			public List<OptionsItem> Options { get; set; }

			public class OptionsItem
			{
				[JsonPropertyName("property_value_id")]
				[Description("类目属性值id")]
				public long PropertyValueId { get; set; }

				[JsonPropertyName("property_value")]
				[Description("类目属性值")]
				public string PropertyValue { get; set; }
			}

			[JsonPropertyName("property_id")]
			[Description("属性id")]
			public long PropertyId { get; set; }
		}

		[JsonPropertyName("standard_brand_id")]
		[Description("品牌id")]
		public long StandardBrandId { get; set; }

		[JsonPropertyName("skus")]
		[Description("sku列表")]
		public List<SkusItem> Skus { get; set; }

		public class SkusItem
		{
			[JsonPropertyName("sku_id")]
			[Description("skuid")]
			public long SkuId { get; set; }

			[JsonPropertyName("outer_sku_id")]
			[Description("外部skuid")]
			public string OuterSkuId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("产品id")]
			public long ProductId { get; set; }

			[JsonPropertyName("supply_price")]
			[Description("基准供货价")]
			public long SupplyPrice { get; set; }

			[JsonPropertyName("status")]
			[Description("sku主状态 1 生效 -1失效")]
			public int Status { get; set; }

			[JsonPropertyName("sub_status")]
			[Description("子状态  1生效 -1失效 -2删除 2草稿态 ,3 审批中 4供货价调整审批中 5供货价审批通过待生效（审批通过后不是立即生效） 6下架审批中 7下架审批通过待失效（审批通过后不是立即生效）8（下架审批通过后执行时下架失败（如库存被分销商活动锁定））,,20 由草稿态发起审批时失败 30上架审批被拒绝")]
			public int SubStatus { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("spec_price")]
			[Description("特定供货价")]
			public List<SpecPriceItem> SpecPrice { get; set; }

			public class SpecPriceItem
			{
				[JsonPropertyName("distributor_id_list")]
				[Description("特定供货价的分销商")]
				public List<long> DistributorIdList { get; set; }

				[JsonPropertyName("supply_price")]
				[Description("基准价格")]
				public long SupplyPrice { get; set; }
			}

			[JsonPropertyName("stock_list")]
			[Description("库存明显")]
			public List<StockListItem> StockList { get; set; }

			public class StockListItem
			{
				[JsonPropertyName("out_warehouse_id")]
				[Description("外部仓编码")]
				public string OutWarehouseId { get; set; }

				[JsonPropertyName("total_qty")]
				[Description("渠道库存总量")]
				public long TotalQty { get; set; }

				[JsonPropertyName("alloc_qty")]
				[Description("渠道库存已分配数量")]
				public long AllocQty { get; set; }

				[JsonPropertyName("remain_qty")]
				[Description("剩余可用量")]
				public long RemainQty { get; set; }
			}

			[JsonPropertyName("img")]
			[Description("sku图")]
			public string Img { get; set; }

			[JsonPropertyName("sku_prop_list")]
			[Description("规则列表")]
			public List<SkuPropListItem> SkuPropList { get; set; }

			public class SkuPropListItem
			{
				[JsonPropertyName("property_name")]
				[Description("属性名")]
				public string PropertyName { get; set; }

				[JsonPropertyName("options")]
				[Description("属性值")]
				public List<OptionsItem> Options { get; set; }

				public class OptionsItem
				{
					[JsonPropertyName("property_value")]
					[Description("属性值id")]
					public string PropertyValue { get; set; }
				}
			}

			[JsonPropertyName("barcode_list")]
			[Description("barcode列表")]
			public List<string> BarcodeList { get; set; }

			[JsonPropertyName("extends")]
			[Description("扩展信息")]
			public Dictionary<string,string> Extends { get; set; }
		}

		[JsonPropertyName("quality_list")]
		[Description("资质")]
		public List<QualityListItem> QualityList { get; set; }

		public class QualityListItem
		{
			[JsonPropertyName("quality_key")]
			[Description("资质key")]
			public string QualityKey { get; set; }

			[JsonPropertyName("quality_name")]
			[Description("资质名")]
			public string QualityName { get; set; }

			[JsonPropertyName("quality_attachments")]
			[Description("附件")]
			public List<QualityAttachmentsItem> QualityAttachments { get; set; }

			public class QualityAttachmentsItem
			{
				[JsonPropertyName("media_type")]
				[Description("1-图片，2-pdf")]
				public long MediaType { get; set; }

				[JsonPropertyName("url")]
				[Description("资质url")]
				public string Url { get; set; }
			}

			[JsonPropertyName("qualityid")]
			[Description("123123123123")]
			public long Qualityid { get; set; }
		}

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }
	}
}
