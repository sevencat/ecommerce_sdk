namespace ecommerce.sdk.douyin;

[Description("根据搭配id批量查询搭配详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","请求缺少必传参数","isv.missing-parameter:200002","检查参数")]
[DouyinRetCode(40004,"非法的参数","超过最大查询数量","isv.parameter-invalid:200003","检查参数")]
public class ProductBatchGetCombinationReq : IDouyinReq<ProductBatchGetCombinationRsp>
{

	public string GetMethod() { return "product.batchGetCombination"; }

	public string GetUrl() { return "/product/batchGetCombination"; }

	[JsonPropertyName("params")]
	[Description("搭配id列表")]
	[NotNull]
	public List<ParamsItem> Params { get; set; }

	public class ParamsItem
	{
		[JsonPropertyName("combination_id")]
		[Description("搭配id，最多20个")]
		[NotNull]
		public long? CombinationId { get; set; }
	}
}

[Description("根据搭配id批量查询搭配详情")]
public class ProductBatchGetCombinationRsp
{
	[JsonPropertyName("combination_with_products")]
	[Description("搭配信息列表")]
	public List<CombinationWithProductsItem> CombinationWithProducts { get; set; }

	public class CombinationWithProductsItem
	{
		[JsonPropertyName("combination_info")]
		[Description("搭配信息")]
		public CombinationInfoItem CombinationInfo { get; set; }

		public class CombinationInfoItem
		{
			[JsonPropertyName("combination_id")]
			[Description("搭配id")]
			public long CombinationId { get; set; }

			[JsonPropertyName("title")]
			[Description("搭配标题")]
			public string Title { get; set; }

			[JsonPropertyName("description")]
			[Description("搭配推荐语")]
			public string Description { get; set; }

			[JsonPropertyName("image_url")]
			[Description("搭配主图")]
			public string ImageUrl { get; set; }

			[JsonPropertyName("anchor_image_info")]
			[Description("搭配锚点信息")]
			public string AnchorImageInfo { get; set; }

			[JsonPropertyName("creator_type")]
			[Description("创建者类型")]
			public long CreatorType { get; set; }

			[JsonPropertyName("creator_id")]
			[Description("创建者id")]
			public long CreatorId { get; set; }

			[JsonPropertyName("create_source")]
			[Description("创建源")]
			public long CreateSource { get; set; }

			[JsonPropertyName("cross_store_combo")]
			[Description("是否跨店搭配。1：同店搭配。2：跨店搭配")]
			public long CrossStoreCombo { get; set; }

			[JsonPropertyName("status")]
			[Description("状态。1：有效。2：失效。3：已删除")]
			public long Status { get; set; }

			[JsonPropertyName("offline_reason")]
			[Description("搭配下线原因")]
			public string OfflineReason { get; set; }

			[JsonPropertyName("create_time")]
			[Description("搭配创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("搭配更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("product_ids")]
			[Description("搭配关联的商品id")]
			public List<long> ProductIds { get; set; }

			[JsonPropertyName("reject_reason")]
			[Description("搭配驳回原因")]
			public string RejectReason { get; set; }

			[JsonPropertyName("combination_extra_info")]
			[Description("搭配扩展信息")]
			public string CombinationExtraInfo { get; set; }

			[JsonPropertyName("combination_type")]
			[Description("搭配类型")]
			public long CombinationType { get; set; }

			[JsonPropertyName("combination_sub_type")]
			[Description("搭配子类型")]
			public long CombinationSubType { get; set; }
		}

		[JsonPropertyName("products")]
		[Description("-")]
		public List<ProductsItem> Products { get; set; }

		public class ProductsItem
		{
			[JsonPropertyName("product_id")]
			[Description("-")]
			public long ProductId { get; set; }

			[JsonPropertyName("name")]
			[Description("-")]
			public string Name { get; set; }

			[JsonPropertyName("description")]
			[Description("-")]
			public string Description { get; set; }

			[JsonPropertyName("main_img")]
			[Description("-")]
			public MainImgItem MainImg { get; set; }

			public class MainImgItem
			{
				[JsonPropertyName("url")]
				[Description("-")]
				public string Url { get; set; }

				[JsonPropertyName("width")]
				[Description("-")]
				public short Width { get; set; }

				[JsonPropertyName("height")]
				[Description("-")]
				public short Height { get; set; }

				[JsonPropertyName("track_info")]
				[Description("-")]
				public string TrackInfo { get; set; }

				[JsonPropertyName("pic_type")]
				[Description("-")]
				public short PicType { get; set; }
			}

			[JsonPropertyName("sale_price")]
			[Description("-")]
			public long SalePrice { get; set; }

			[JsonPropertyName("original_price")]
			[Description("-")]
			public long OriginalPrice { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("-")]
			public long ShopId { get; set; }

			[JsonPropertyName("mobile")]
			[Description("-")]
			public string Mobile { get; set; }

			[JsonPropertyName("sell_num")]
			[Description("-")]
			public long SellNum { get; set; }

			[JsonPropertyName("spec_id")]
			[Description("-")]
			public long SpecId { get; set; }

			[JsonPropertyName("status")]
			[Description("-")]
			public short Status { get; set; }

			[JsonPropertyName("check_status")]
			[Description("-")]
			public short CheckStatus { get; set; }

			[JsonPropertyName("recommend_remark")]
			[Description("-")]
			public string RecommendRemark { get; set; }

			[JsonPropertyName("pay_type")]
			[Description("-")]
			public short PayType { get; set; }

			[JsonPropertyName("need_code")]
			[Description("-")]
			public short NeedCode { get; set; }

			[JsonPropertyName("biz_type")]
			[Description("-")]
			public short BizType { get; set; }

			[JsonPropertyName("presell_type")]
			[Description("-")]
			public int PresellType { get; set; }

			[JsonPropertyName("end_time")]
			[Description("-")]
			public long EndTime { get; set; }

			[JsonPropertyName("show_place")]
			[Description("-")]
			public int ShowPlace { get; set; }

			[JsonPropertyName("product_type")]
			[Description("-")]
			public long ProductType { get; set; }

			[JsonPropertyName("is_show")]
			[Description("-")]
			public bool IsShow { get; set; }

			[JsonPropertyName("create_time")]
			[Description("-")]
			public long CreateTime { get; set; }

			[JsonPropertyName("assoc_ids")]
			[Description("-")]
			public List<string> AssocIds { get; set; }

			[JsonPropertyName("weight")]
			[Description("-")]
			public decimal Weight { get; set; }

			[JsonPropertyName("freight_id")]
			[Description("-")]
			public long FreightId { get; set; }

			[JsonPropertyName("presell_delay")]
			[Description("-")]
			public long PresellDelay { get; set; }

			[JsonPropertyName("presell_end_time")]
			[Description("-")]
			public long PresellEndTime { get; set; }

			[JsonPropertyName("img_list")]
			[Description("-")]
			public List<ImgListItem> ImgList { get; set; }

			public class ImgListItem
			{
				[JsonPropertyName("url")]
				[Description("-")]
				public string Url { get; set; }

				[JsonPropertyName("width")]
				[Description("-")]
				public short Width { get; set; }

				[JsonPropertyName("height")]
				[Description("-")]
				public short Height { get; set; }

				[JsonPropertyName("track_info")]
				[Description("-")]
				public string TrackInfo { get; set; }

				[JsonPropertyName("pic_type")]
				[Description("-")]
				public short PicType { get; set; }
			}

			[JsonPropertyName("update_time")]
			[Description("-")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("user_limit")]
			[Description("-")]
			public bool UserLimit { get; set; }

			[JsonPropertyName("start_time")]
			[Description("-")]
			public long StartTime { get; set; }

			[JsonPropertyName("reduce_type")]
			[Description("-")]
			public long ReduceType { get; set; }

			[JsonPropertyName("out_product_id")]
			[Description("-")]
			public long OutProductId { get; set; }

			[JsonPropertyName("delivery_delay_day")]
			[Description("-")]
			public long DeliveryDelayDay { get; set; }

			[JsonPropertyName("after_sale_service")]
			[Description("-")]
			public Dictionary<string,string> AfterSaleService { get; set; }

			[JsonPropertyName("market_store_id")]
			[Description("-")]
			public long MarketStoreId { get; set; }

			[JsonPropertyName("product_source")]
			[Description("-")]
			public long ProductSource { get; set; }

			[JsonPropertyName("currency")]
			[Description("-")]
			public string Currency { get; set; }

			[JsonPropertyName("category_id")]
			[Description("-")]
			public long CategoryId { get; set; }

			[JsonPropertyName("new_category")]
			[Description("-")]
			public NewCategoryItem NewCategory { get; set; }

			public class NewCategoryItem
			{
				[JsonPropertyName("first_cid")]
				[Description("-")]
				public long FirstCid { get; set; }

				[JsonPropertyName("second_cid")]
				[Description("-")]
				public long SecondCid { get; set; }

				[JsonPropertyName("third_cid")]
				[Description("-")]
				public long ThirdCid { get; set; }

				[JsonPropertyName("fourth_cid")]
				[Description("-")]
				public long FourthCid { get; set; }

				[JsonPropertyName("first_c_name")]
				[Description("-")]
				public string FirstCName { get; set; }

				[JsonPropertyName("second_c_name")]
				[Description("-")]
				public string SecondCName { get; set; }

				[JsonPropertyName("third_c_name")]
				[Description("-")]
				public string ThirdCName { get; set; }

				[JsonPropertyName("fourth_c_name")]
				[Description("-")]
				public string FourthCName { get; set; }
			}

			[JsonPropertyName("old_category")]
			[Description("-")]
			public OldCategoryItem OldCategory { get; set; }

			public class OldCategoryItem
			{
				[JsonPropertyName("third_cid")]
				[Description("-")]
				public long ThirdCid { get; set; }

				[JsonPropertyName("second_cid")]
				[Description("-")]
				public long SecondCid { get; set; }

				[JsonPropertyName("first_cid")]
				[Description("-")]
				public long FirstCid { get; set; }
			}

			[JsonPropertyName("biz_kind")]
			[Description("-")]
			public long BizKind { get; set; }

			[JsonPropertyName("delivery_delay_date")]
			[Description("-")]
			public long DeliveryDelayDate { get; set; }

			[JsonPropertyName("appoint_delivery_day")]
			[Description("-")]
			public long AppointDeliveryDay { get; set; }

			[JsonPropertyName("sell_channel")]
			[Description("-")]
			public long SellChannel { get; set; }

			[JsonPropertyName("property_values")]
			[Description("-")]
			public List<PropertyValuesItem> PropertyValues { get; set; }

			public class PropertyValuesItem
			{
				[JsonPropertyName("property")]
				[Description("-")]
				public PropertyItem Property { get; set; }

				public class PropertyItem
				{
					[JsonPropertyName("property_id")]
					[Description("-")]
					public long PropertyId { get; set; }

					[JsonPropertyName("property_name")]
					[Description("-")]
					public string PropertyName { get; set; }

					[JsonPropertyName("spec_type")]
					[Description("-")]
					public long SpecType { get; set; }
				}

				[JsonPropertyName("values")]
				[Description("-")]
				public List<ValuesItem> Values { get; set; }

				public class ValuesItem
				{
					[JsonPropertyName("value_id")]
					[Description("-")]
					public long ValueId { get; set; }

					[JsonPropertyName("value_name")]
					[Description("-")]
					public string ValueName { get; set; }

					[JsonPropertyName("display_value_name")]
					[Description("-")]
					public string DisplayValueName { get; set; }
				}

				[JsonPropertyName("pair_id")]
				[Description("-")]
				public long PairId { get; set; }

				[JsonPropertyName("seq")]
				[Description("-")]
				public long Seq { get; set; }
			}

			[JsonPropertyName("biz_identity")]
			[Description("-")]
			public BizIdentityItem BizIdentity { get; set; }

			public class BizIdentityItem
			{
				[JsonPropertyName("bmp_seller_type")]
				[Description("-")]
				public string BmpSellerType { get; set; }

				[JsonPropertyName("bmp_vertical_market")]
				[Description("-")]
				public string BmpVerticalMarket { get; set; }

				[JsonPropertyName("bmp_source")]
				[Description("-")]
				public string BmpSource { get; set; }
			}

			[JsonPropertyName("brand_id")]
			[Description("-")]
			public long BrandId { get; set; }

			[JsonPropertyName("product_biz")]
			[Description("-")]
			public long ProductBiz { get; set; }

			[JsonPropertyName("image_detail_info")]
			[Description("-")]
			public List<ImageDetailInfoItem> ImageDetailInfo { get; set; }

			public class ImageDetailInfoItem
			{
				[JsonPropertyName("url")]
				[Description("-")]
				public string Url { get; set; }

				[JsonPropertyName("width")]
				[Description("-")]
				public short Width { get; set; }

				[JsonPropertyName("height")]
				[Description("-")]
				public short Height { get; set; }

				[JsonPropertyName("track_info")]
				[Description("-")]
				public string TrackInfo { get; set; }

				[JsonPropertyName("pic_type")]
				[Description("-")]
				public short PicType { get; set; }
			}

			[JsonPropertyName("skus")]
			[Description("-")]
			public List<SkusItem> Skus { get; set; }

			public class SkusItem
			{
				[JsonPropertyName("shop_id")]
				[Description("-")]
				public long ShopId { get; set; }

				[JsonPropertyName("id")]
				[Description("-")]
				public long Id { get; set; }

				[JsonPropertyName("product_id")]
				[Description("-")]
				public long ProductId { get; set; }

				[JsonPropertyName("price")]
				[Description("-")]
				public long Price { get; set; }

				[JsonPropertyName("code")]
				[Description("-")]
				public string Code { get; set; }

				[JsonPropertyName("spec_id")]
				[Description("-")]
				public long SpecId { get; set; }

				[JsonPropertyName("type")]
				[Description("-")]
				public long Type { get; set; }

				[JsonPropertyName("supplier_id")]
				[Description("-")]
				public string SupplierId { get; set; }

				[JsonPropertyName("outer_sku_id")]
				[Description("-")]
				public string OuterSkuId { get; set; }

				[JsonPropertyName("sku_biz")]
				[Description("-")]
				public long SkuBiz { get; set; }

				[JsonPropertyName("package_sub_sku_infos")]
				[Description("-")]
				public List<PackageSubSkuInfosItem> PackageSubSkuInfos { get; set; }

				public class PackageSubSkuInfosItem
				{
					[JsonPropertyName("package_sub_sku_item")]
					[Description("-")]
					public PackageSubSkuItemItem PackageSubSkuItem { get; set; }

					public class PackageSubSkuItemItem
					{
						[JsonPropertyName("sku_id")]
						[Description("-")]
						public long SkuId { get; set; }

						[JsonPropertyName("sub_sku_id")]
						[Description("-")]
						public long SubSkuId { get; set; }

						[JsonPropertyName("short_name")]
						[Description("-")]
						public string ShortName { get; set; }

						[JsonPropertyName("num")]
						[Description("-")]
						public long Num { get; set; }

						[JsonPropertyName("ori_price")]
						[Description("-")]
						public long OriPrice { get; set; }

						[JsonPropertyName("shop_id")]
						[Description("-")]
						public long ShopId { get; set; }

						[JsonPropertyName("sub_product_id")]
						[Description("-")]
						public long SubProductId { get; set; }
					}

					[JsonPropertyName("package_sub_sku_detail")]
					[Description("-")]
					public int PackageSubSkuDetail { get; set; }
				}

				[JsonPropertyName("sale_property_values")]
				[Description("-")]
				public List<SalePropertyValuesItem> SalePropertyValues { get; set; }

				public class SalePropertyValuesItem
				{
					[JsonPropertyName("property")]
					[Description("-")]
					public PropertyItem Property { get; set; }

					public class PropertyItem
					{
						[JsonPropertyName("property_id")]
						[Description("-")]
						public long PropertyId { get; set; }

						[JsonPropertyName("property_name")]
						[Description("-")]
						public string PropertyName { get; set; }

						[JsonPropertyName("spec_type")]
						[Description("-")]
						public long SpecType { get; set; }
					}

					[JsonPropertyName("value")]
					[Description("-")]
					public ValueItem Value { get; set; }

					public class ValueItem
					{
						[JsonPropertyName("value_id")]
						[Description("-")]
						public long ValueId { get; set; }

						[JsonPropertyName("value_name")]
						[Description("-")]
						public string ValueName { get; set; }

						[JsonPropertyName("display_value_name")]
						[Description("-")]
						public string DisplayValueName { get; set; }
					}

					[JsonPropertyName("pair_id")]
					[Description("-")]
					public long PairId { get; set; }

					[JsonPropertyName("seq")]
					[Description("-")]
					public long Seq { get; set; }

					[JsonPropertyName("pic")]
					[Description("-")]
					public PicItem Pic { get; set; }

					public class PicItem
					{
						[JsonPropertyName("url")]
						[Description("-")]
						public string Url { get; set; }

						[JsonPropertyName("width")]
						[Description("-")]
						public short Width { get; set; }

						[JsonPropertyName("height")]
						[Description("-")]
						public short Height { get; set; }

						[JsonPropertyName("track_info")]
						[Description("-")]
						public string TrackInfo { get; set; }

						[JsonPropertyName("pic_type")]
						[Description("-")]
						public short PicType { get; set; }
					}
				}

				[JsonPropertyName("extra_info")]
				[Description("-")]
				public Dictionary<string,string> ExtraInfo { get; set; }

				[JsonPropertyName("status")]
				[Description("-")]
				public short Status { get; set; }

				[JsonPropertyName("campaign_price")]
				[Description("-")]
				public long CampaignPrice { get; set; }

				[JsonPropertyName("hit_channel")]
				[Description("-")]
				public bool HitChannel { get; set; }

				[JsonPropertyName("sellable")]
				[Description("-")]
				public bool Sellable { get; set; }

				[JsonPropertyName("channel")]
				[Description("-")]
				public ChannelItem Channel { get; set; }

				public class ChannelItem
				{
					[JsonPropertyName("channel_type")]
					[Description("-")]
					public long ChannelType { get; set; }

					[JsonPropertyName("channel_id")]
					[Description("-")]
					public long ChannelId { get; set; }
				}

				[JsonPropertyName("sku_channel")]
				[Description("-")]
				public SkuChannelItem SkuChannel { get; set; }

				public class SkuChannelItem
				{
					[JsonPropertyName("channel")]
					[Description("-")]
					public ChannelItem Channel { get; set; }

					public class ChannelItem
					{
						[JsonPropertyName("channel_type")]
						[Description("-")]
						public long ChannelType { get; set; }

						[JsonPropertyName("channel_id")]
						[Description("-")]
						public long ChannelId { get; set; }
					}

					[JsonPropertyName("shop_id")]
					[Description("-")]
					public long ShopId { get; set; }

					[JsonPropertyName("product_id")]
					[Description("-")]
					public long ProductId { get; set; }

					[JsonPropertyName("sku_id")]
					[Description("-")]
					public long SkuId { get; set; }

					[JsonPropertyName("extra")]
					[Description("-")]
					public Dictionary<string,string> Extra { get; set; }
				}

				[JsonPropertyName("presell_delay")]
				[Description("-")]
				public long PresellDelay { get; set; }

				[JsonPropertyName("presell_type")]
				[Description("-")]
				public long PresellType { get; set; }

				[JsonPropertyName("poi_resource")]
				[Description("-")]
				public PoiResourceItem PoiResource { get; set; }

				public class PoiResourceItem
				{
					[JsonPropertyName("product_id")]
					[Description("-")]
					public long ProductId { get; set; }

					[JsonPropertyName("sku_id")]
					[Description("-")]
					public long SkuId { get; set; }

					[JsonPropertyName("res_id")]
					[Description("-")]
					public long ResId { get; set; }

					[JsonPropertyName("res_order_id")]
					[Description("-")]
					public long ResOrderId { get; set; }

					[JsonPropertyName("res_order_secret")]
					[Description("-")]
					public string ResOrderSecret { get; set; }

					[JsonPropertyName("code_type")]
					[Description("-")]
					public int CodeType { get; set; }

					[JsonPropertyName("status")]
					[Description("-")]
					public long Status { get; set; }
				}

				[JsonPropertyName("adapt_d_t_o")]
				[Description("-")]
				public AdaptDTOItem AdaptDTO { get; set; }

				public class AdaptDTOItem
				{
					[JsonPropertyName("adapt_result")]
					[Description("-")]
					public Dictionary<string,bool> AdaptResult { get; set; }

					[JsonPropertyName("have_adapt_data")]
					[Description("-")]
					public bool HaveAdaptData { get; set; }
				}

				[JsonPropertyName("package_main_product_sku_info")]
				[Description("-")]
				public List<PackageMainProductSkuInfoItem> PackageMainProductSkuInfo { get; set; }

				public class PackageMainProductSkuInfoItem
				{
					[JsonPropertyName("product_id")]
					[Description("-")]
					public long ProductId { get; set; }

					[JsonPropertyName("sku_id")]
					[Description("-")]
					public long SkuId { get; set; }

					[JsonPropertyName("shop_id")]
					[Description("-")]
					public long ShopId { get; set; }

					[JsonPropertyName("package_id")]
					[Description("-")]
					public long PackageId { get; set; }
				}
			}

			[JsonPropertyName("extra_info")]
			[Description("-")]
			public Dictionary<string,string> ExtraInfo { get; set; }

			[JsonPropertyName("tag_list")]
			[Description("-")]
			public List<string> TagList { get; set; }

			[JsonPropertyName("sellable")]
			[Description("-")]
			public bool Sellable { get; set; }

			[JsonPropertyName("video_item")]
			[Description("-")]
			public VideoItemItem VideoItem { get; set; }

			public class VideoItemItem
			{
				[JsonPropertyName("vid")]
				[Description("-")]
				public string Vid { get; set; }
			}

			[JsonPropertyName("package_sub_products")]
			[Description("-")]
			public List<PackageSubProductsItem> PackageSubProducts { get; set; }

			public class PackageSubProductsItem
			{
				[JsonPropertyName("package_sub_product_item")]
				[Description("-")]
				public PackageSubProductItemItem PackageSubProductItem { get; set; }

				public class PackageSubProductItemItem
				{
					[JsonPropertyName("product_id")]
					[Description("-")]
					public long ProductId { get; set; }

					[JsonPropertyName("sub_product_id")]
					[Description("-")]
					public long SubProductId { get; set; }
				}

				[JsonPropertyName("package_sub_product_detail")]
				[Description("-")]
				public int PackageSubProductDetail { get; set; }
			}

			[JsonPropertyName("product_videos")]
			[Description("-")]
			public List<ProductVideosItem> ProductVideos { get; set; }

			public class ProductVideosItem
			{
				[JsonPropertyName("product_id")]
				[Description("-")]
				public long ProductId { get; set; }

				[JsonPropertyName("shop_id")]
				[Description("-")]
				public long ShopId { get; set; }

				[JsonPropertyName("video_url")]
				[Description("-")]
				public string VideoUrl { get; set; }

				[JsonPropertyName("material_type")]
				[Description("-")]
				public long MaterialType { get; set; }

				[JsonPropertyName("extra")]
				[Description("-")]
				public string Extra { get; set; }
			}

			[JsonPropertyName("channel")]
			[Description("-")]
			public ChannelItem Channel { get; set; }

			public class ChannelItem
			{
				[JsonPropertyName("channel_type")]
				[Description("-")]
				public long ChannelType { get; set; }

				[JsonPropertyName("channel_id")]
				[Description("-")]
				public long ChannelId { get; set; }
			}

			[JsonPropertyName("hit_channel")]
			[Description("-")]
			public bool HitChannel { get; set; }

			[JsonPropertyName("product_channel")]
			[Description("-")]
			public ProductChannelItem ProductChannel { get; set; }

			public class ProductChannelItem
			{
				[JsonPropertyName("channel")]
				[Description("-")]
				public ChannelItem Channel { get; set; }

				public class ChannelItem
				{
					[JsonPropertyName("channel_type")]
					[Description("-")]
					public long ChannelType { get; set; }

					[JsonPropertyName("channel_id")]
					[Description("-")]
					public long ChannelId { get; set; }
				}

				[JsonPropertyName("shop_id")]
				[Description("-")]
				public long ShopId { get; set; }

				[JsonPropertyName("product_id")]
				[Description("-")]
				public long ProductId { get; set; }

				[JsonPropertyName("status")]
				[Description("-")]
				public long Status { get; set; }

				[JsonPropertyName("extra")]
				[Description("-")]
				public Dictionary<string,string> Extra { get; set; }
			}

			[JsonPropertyName("tag_info_str")]
			[Description("-")]
			public string TagInfoStr { get; set; }

			[JsonPropertyName("presell_config_level")]
			[Description("-")]
			public long PresellConfigLevel { get; set; }

			[JsonPropertyName("presell_delivery_type")]
			[Description("-")]
			public long PresellDeliveryType { get; set; }

			[JsonPropertyName("reason")]
			[Description("-")]
			public string Reason { get; set; }

			[JsonPropertyName("std_brand_name")]
			[Description("-")]
			public string StdBrandName { get; set; }

			[JsonPropertyName("default_combination_id")]
			[Description("-")]
			public long DefaultCombinationId { get; set; }

			[JsonPropertyName("detail_brief")]
			[Description("-")]
			public DetailBriefItem DetailBrief { get; set; }

			public class DetailBriefItem
			{
				[JsonPropertyName("component_info")]
				[Description("-")]
				public List<ComponentInfoItem> ComponentInfo { get; set; }

				public class ComponentInfoItem
				{
					[JsonPropertyName("component_type_id")]
					[Description("-")]
					public long ComponentTypeId { get; set; }

					[JsonPropertyName("image")]
					[Description("-")]
					public ImageItem Image { get; set; }

					public class ImageItem
					{
						[JsonPropertyName("pic_url")]
						[Description("-")]
						public string PicUrl { get; set; }

						[JsonPropertyName("width")]
						[Description("-")]
						public short Width { get; set; }

						[JsonPropertyName("height")]
						[Description("-")]
						public short Height { get; set; }

						[JsonPropertyName("track_info")]
						[Description("-")]
						public string TrackInfo { get; set; }
					}

					[JsonPropertyName("component_name")]
					[Description("-")]
					public string ComponentName { get; set; }

					[JsonPropertyName("component_data")]
					[Description("-")]
					public string ComponentData { get; set; }
				}
			}

			[JsonPropertyName("sell_terminal")]
			[Description("-")]
			public List<long> SellTerminal { get; set; }

			[JsonPropertyName("mpu_mount_relations")]
			[Description("-")]
			public List<MpuMountRelationsItem> MpuMountRelations { get; set; }

			public class MpuMountRelationsItem
			{
				[JsonPropertyName("cmpu_id")]
				[Description("-")]
				public long CmpuId { get; set; }

				[JsonPropertyName("relation_skus")]
				[Description("-")]
				public List<RelationSkusItem> RelationSkus { get; set; }

				public class RelationSkusItem
				{
					[JsonPropertyName("product_id")]
					[Description("-")]
					public long ProductId { get; set; }

					[JsonPropertyName("sku_id")]
					[Description("-")]
					public long SkuId { get; set; }
				}
			}

			[JsonPropertyName("priority_material_info")]
			[Description("-")]
			public PriorityMaterialInfoItem PriorityMaterialInfo { get; set; }

			public class PriorityMaterialInfoItem
			{
				[JsonPropertyName("main_img")]
				[Description("-")]
				public MainImgItem MainImg { get; set; }

				public class MainImgItem
				{
					[JsonPropertyName("img_url")]
					[Description("-")]
					public ImgUrlItem ImgUrl { get; set; }

					public class ImgUrlItem
					{
						[JsonPropertyName("url")]
						[Description("-")]
						public string Url { get; set; }

						[JsonPropertyName("width")]
						[Description("-")]
						public short Width { get; set; }

						[JsonPropertyName("height")]
						[Description("-")]
						public short Height { get; set; }

						[JsonPropertyName("track_info")]
						[Description("-")]
						public string TrackInfo { get; set; }

						[JsonPropertyName("pic_type")]
						[Description("-")]
						public short PicType { get; set; }
					}

					[JsonPropertyName("img_props")]
					[Description("-")]
					public string ImgProps { get; set; }
				}
			}

			[JsonPropertyName("store_id")]
			[Description("-")]
			public long StoreId { get; set; }

			[JsonPropertyName("product_relation")]
			[Description("-")]
			public ProductRelationItem ProductRelation { get; set; }

			public class ProductRelationItem
			{
				[JsonPropertyName("relation_type")]
				[Description("-")]
				public int RelationType { get; set; }

				[JsonPropertyName("relation_item")]
				[Description("-")]
				public List<RelationItemItem> RelationItem { get; set; }

				public class RelationItemItem
				{
					[JsonPropertyName("main_product")]
					[Description("-")]
					public MainProductItem MainProduct { get; set; }

					public class MainProductItem
					{
						[JsonPropertyName("channel")]
						[Description("-")]
						public ChannelItem Channel { get; set; }

						public class ChannelItem
						{
							[JsonPropertyName("channel_type")]
							[Description("-")]
							public long ChannelType { get; set; }

							[JsonPropertyName("channel_id")]
							[Description("-")]
							public long ChannelId { get; set; }
						}

						[JsonPropertyName("product_id")]
						[Description("-")]
						public long ProductId { get; set; }
					}

					[JsonPropertyName("sub_product")]
					[Description("-")]
					public SubProductItem SubProduct { get; set; }

					public class SubProductItem
					{
						[JsonPropertyName("channel")]
						[Description("-")]
						public ChannelItem Channel { get; set; }

						public class ChannelItem
						{
							[JsonPropertyName("channel_type")]
							[Description("-")]
							public long ChannelType { get; set; }

							[JsonPropertyName("channel_id")]
							[Description("-")]
							public long ChannelId { get; set; }
						}

						[JsonPropertyName("product_id")]
						[Description("-")]
						public long ProductId { get; set; }
					}
				}
			}

			[JsonPropertyName("package_main_product_info")]
			[Description("-")]
			public List<PackageMainProductInfoItem> PackageMainProductInfo { get; set; }

			public class PackageMainProductInfoItem
			{
				[JsonPropertyName("product_id")]
				[Description("-")]
				public long ProductId { get; set; }
			}

			[JsonPropertyName("price")]
			[Description("-")]
			public PriceItem Price { get; set; }

			public class PriceItem
			{
				[JsonPropertyName("reference_price")]
				[Description("-")]
				public long ReferencePrice { get; set; }
			}

			[JsonPropertyName("sell_num_value")]
			[Description("-")]
			public SellNumValueItem SellNumValue { get; set; }

			public class SellNumValueItem
			{
				[JsonPropertyName("outer_sell_num")]
				[Description("-")]
				public long OuterSellNum { get; set; }

				[JsonPropertyName("total_sell_num")]
				[Description("-")]
				public long TotalSellNum { get; set; }
			}

			[JsonPropertyName("custom_value_tag_infos")]
			[Description("-")]
			public List<CustomValueTagInfosItem> CustomValueTagInfos { get; set; }

			public class CustomValueTagInfosItem
			{
				[JsonPropertyName("tag_code")]
				[Description("-")]
				public string TagCode { get; set; }

				[JsonPropertyName("tag_value")]
				[Description("-")]
				public string TagValue { get; set; }
			}

			[JsonPropertyName("spu_id")]
			[Description("-")]
			public List<long> SpuId { get; set; }

			[JsonPropertyName("default_series_id")]
			[Description("-")]
			public long DefaultSeriesId { get; set; }

			[JsonPropertyName("return_policy_id")]
			[Description("-")]
			public string ReturnPolicyId { get; set; }
		}
	}
}
