namespace ecommerce.sdk.douyin;

[Description("1、调用【/product/addV2】创建商品和【/product/editV2】更新商品时，请求参数【product_format_new】字段需传入。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前类目不存在，请重新选择类目","isv.parameter-invalid:2010003","类目已经不存在，业务预期内，不透出属于正常case")]
[DouyinRetCode(40004,"非法的参数","此类目已调整升级，请重新选择类目进行商品发布","isv.parameter-invalid:2010044","切换类目")]
[DouyinRetCode(50002,"业务处理失败","获取类目配置失败","isv.business-failed:2010202","重试")]
[DouyinRetCode(50002,"业务处理失败","获取可选品牌失败","isv.business-failed:2010013","重新调用接口获取")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:2010001","请重试")]
public class ProductGetCatePropertyV2Req : IDouyinReq<ProductGetCatePropertyV2Rsp>
{

	public string GetMethod() { return "product.getCatePropertyV2"; }

	public string GetUrl() { return "/product/getCatePropertyV2"; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目id 1、传category_leaf_id ，则不需要传first_cid、second_cid、third_cid这三个字段 2、如果没传category_leaf_id，走之前的逻辑，需要传first_cid、second_cid、third_cid这三个字段")]
	[NotNull]
	public long? CategoryLeafId { get; set; }
}

[Description("1、调用【/product/addV2】创建商品和【/product/editV2】更新商品时，请求参数【product_format_new】字段需传入。")]
public class ProductGetCatePropertyV2Rsp
{
	[JsonPropertyName("data")]
	[Description("返回参数列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("has_sub_property")]
		[Description("是否有下级级联属性")]
		public bool HasSubProperty { get; set; }

		[JsonPropertyName("cid")]
		[Description("【已废弃】老类目id，请使用category_id字段")]
		public long Cid { get; set; }

		[JsonPropertyName("property_name")]
		[Description("属性名称")]
		public string PropertyName { get; set; }

		[JsonPropertyName("options")]
		[Description("属性可选值列表，为空时需要手动填写")]
		public List<OptionsItem> Options { get; set; }

		public class OptionsItem
		{
			[JsonPropertyName("name")]
			[Description("可选值名称")]
			public string Name { get; set; }

			[JsonPropertyName("value")]
			[Description("可选值")]
			public string Value { get; set; }

			[JsonPropertyName("value_id")]
			[Description("值的id")]
			public long ValueId { get; set; }

			[JsonPropertyName("sequence")]
			[Description("属性值顺序")]
			public long Sequence { get; set; }
		}

		[JsonPropertyName("required")]
		[Description("1：创建商品时该属性字段必填 0：创建商品时该属性字段选填")]
		public long Required { get; set; }

		[JsonPropertyName("status")]
		[Description("属性状态，0：有效，1：失效")]
		public long Status { get; set; }

		[JsonPropertyName("type")]
		[Description("输入text、单选select、多选multi_select、时间戳timestamp、时间段timerange")]
		public string Type { get; set; }

		[JsonPropertyName("category_id")]
		[Description("新版类目id（优先使用）")]
		public long CategoryId { get; set; }

		[JsonPropertyName("multi_select_max")]
		[Description("最大多选数")]
		public long MultiSelectMax { get; set; }

		[JsonPropertyName("property_type")]
		[Description("属性类型，0 绑定属性 1关键属性 2售卖属性 3 商品属性")]
		public long PropertyType { get; set; }

		[JsonPropertyName("property_id")]
		[Description("属性id")]
		public long PropertyId { get; set; }

		[JsonPropertyName("sequence")]
		[Description("属性顺序")]
		public long Sequence { get; set; }

		[JsonPropertyName("relation_id")]
		[Description("关系id,SPU类目使用，表示自己的上一个关键属性ID")]
		public long RelationId { get; set; }

		[JsonPropertyName("diy_type")]
		[Description("商品属性是否有支持商家自定义，1=支持自定义，0=不支持自定义。 使用场景：当开发者传入自定义的属性值时需在创建或更新商品接口的属性时，需把【product_format_new】字段中传入diy_type=1并且value=0；")]
		public long DiyType { get; set; }

		[JsonPropertyName("important_type")]
		[Description("0:非重要属性，1:重要属性")]
		public long ImportantType { get; set; }
	}

	[JsonPropertyName("tpl_type")]
	[Description("模板类型，SPU为1，结构化为2，默认为0（无特殊需求忽略该字段即可）")]
	public long TplType { get; set; }
}
