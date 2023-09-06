namespace ecommerce.sdk.douyin;

[Description("发布商品和发布SPU前需要调用此接口查看类目是否为SPU类目，如果是，会返回对应的管控策略和SPU发布表单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","读取失败","isv.business-failed:2012013","检查参数入参")]
[DouyinRetCode(80000,"风控拦截","操作人非法","isv.risk-control-failed:20121002","查看操作人信息")]
public class SpuGetSpuRuleReq : IDouyinReq<SpuGetSpuRuleRsp>
{

	public string GetMethod() { return "spu.getSpuRule"; }

	public string GetUrl() { return "/spu/getSpuRule"; }

	[JsonPropertyName("category_id")]
	[Description("类目ID")]
	[NotNull]
	public long? CategoryId { get; set; }
}

[Description("发布商品和发布SPU前需要调用此接口查看类目是否为SPU类目，如果是，会返回对应的管控策略和SPU发布表单")]
public class SpuGetSpuRuleRsp
{
	[JsonPropertyName("spu_property_rule")]
	[Description("SPU属性规则")]
	public List<SpuPropertyRuleItem> SpuPropertyRule { get; set; }

	public class SpuPropertyRuleItem
	{
		[JsonPropertyName("property_name")]
		[Description("属性名")]
		public string PropertyName { get; set; }

		[JsonPropertyName("property_id")]
		[Description("属性ID")]
		public long PropertyId { get; set; }

		[JsonPropertyName("is_required")]
		[Description("是否必填，0:非必填，1:必填")]
		public long IsRequired { get; set; }

		[JsonPropertyName("value_type")]
		[Description("输入类型 select:单选，multi_select:多选，text:输入框，timestamp:时间戳，timeframe:时间区间")]
		public string ValueType { get; set; }

		[JsonPropertyName("property_type")]
		[Description("属性类型，0 绑定属性 1关键属性 2销售属性")]
		public long PropertyType { get; set; }

		[JsonPropertyName("diy_type")]
		[Description("是否支持枚举可输入")]
		public long DiyType { get; set; }

		[JsonPropertyName("max_select_num")]
		[Description("最大可选数量，多选时需要用")]
		public long MaxSelectNum { get; set; }

		[JsonPropertyName("values")]
		[Description("属性值")]
		public List<ValuesItem> Values { get; set; }

		public class ValuesItem
		{
			[JsonPropertyName("value_id")]
			[Description("属性值ID，对于输入框类型，填0即可")]
			public long ValueId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("属性值，属性值的中文")]
			public string ValueName { get; set; }
		}
	}

	[JsonPropertyName("spu_images_rule")]
	[Description("SPU图片规则")]
	public SpuImagesRuleItem SpuImagesRule { get; set; }

	public class SpuImagesRuleItem
	{
		[JsonPropertyName("is_required")]
		[Description("是否必填")]
		public long IsRequired { get; set; }

		[JsonPropertyName("max_num")]
		[Description("最大数量")]
		public long MaxNum { get; set; }

		[JsonPropertyName("min_num")]
		[Description("最小数量")]
		public long MinNum { get; set; }
	}

	[JsonPropertyName("spu_actual_images_rule")]
	[Description("SPU实物图规则（实物图：证明SPU存在的图片，如版权页、包装图）")]
	public SpuActualImagesRuleItem SpuActualImagesRule { get; set; }

	public class SpuActualImagesRuleItem
	{
		[JsonPropertyName("is_required")]
		[Description("是否必填")]
		public long IsRequired { get; set; }

		[JsonPropertyName("max_num")]
		[Description("最大数量")]
		public long MaxNum { get; set; }

		[JsonPropertyName("min_num")]
		[Description("最小数量")]
		public long MinNum { get; set; }
	}

	[JsonPropertyName("control_type")]
	[Description("0-不管控，商家在该类目下发布商品时，不强制要求命中SPU。 - 1-弱管控，商家在该类目下发布商品时，强制要求命中SPU（即关键属性必须一致），但绑定属性不强制要求一致。 - 2-强管控，商家在该类目下发布商品时，强制要求命中SPU，且绑定属性必须一致。")]
	public long ControlType { get; set; }

	[JsonPropertyName("support_spu_product")]
	[Description("- true 表示商家在该类目基于SPU发布商品，发商品的管控策略见管控类型。 - false 表示商家在该类目不需要基于SPU发布商品。不用发布SPU，直接发布商品即可。")]
	public bool SupportSpuProduct { get; set; }

	[JsonPropertyName("support_create_spu")]
	[Description("true-可以发布SPU，false-不能发布SPU")]
	public bool SupportCreateSpu { get; set; }

	[JsonPropertyName("spu_material_rules")]
	[Description("SPU素材规则（素材类型：主图）")]
	public List<SpuMaterialRulesItem> SpuMaterialRules { get; set; }

	public class SpuMaterialRulesItem
	{
		[JsonPropertyName("material_rule")]
		[Description("SPU素材的具体规则")]
		public MaterialRuleItem MaterialRule { get; set; }

		public class MaterialRuleItem
		{
			[JsonPropertyName("name")]
			[Description("素材名称")]
			public string Name { get; set; }

			[JsonPropertyName("is_required")]
			[Description("是否必填，0:非必填，1:必填")]
			public long IsRequired { get; set; }

			[JsonPropertyName("min_num")]
			[Description("最小数量")]
			public long MinNum { get; set; }

			[JsonPropertyName("max_num")]
			[Description("最大数量")]
			public long MaxNum { get; set; }

			[JsonPropertyName("max_size")]
			[Description("最大容量，单位为M")]
			public long MaxSize { get; set; }

			[JsonPropertyName("aspect_ratio")]
			[Description("素材类型为图片时的尺寸比")]
			public List<string> AspectRatio { get; set; }

			[JsonPropertyName("pixel")]
			[Description("素材类型为图片时的像素比")]
			public List<long> Pixel { get; set; }

			[JsonPropertyName("data_format")]
			[Description("数据格式类型，例如jpg、png等格式")]
			public List<string> DataFormat { get; set; }
		}

		[JsonPropertyName("material_type")]
		[Description("素材类型枚举值：1-主图")]
		public int MaterialType { get; set; }
	}

	[JsonPropertyName("spu_proof_rules")]
	[Description("证明材料规则（证明材料类型：实物图、版权页）")]
	public List<SpuProofRulesItem> SpuProofRules { get; set; }

	public class SpuProofRulesItem
	{
		[JsonPropertyName("proof_type")]
		[Description("实物证明类型，枚举值：2-实物图、6-版权页")]
		public int ProofType { get; set; }

		[JsonPropertyName("proof_rule")]
		[Description("SPU证明材料的具体规则")]
		public ProofRuleItem ProofRule { get; set; }

		public class ProofRuleItem
		{
			[JsonPropertyName("name")]
			[Description("证明材料名称")]
			public string Name { get; set; }

			[JsonPropertyName("is_required")]
			[Description("是否必填，0:非必填，1:必填")]
			public long IsRequired { get; set; }

			[JsonPropertyName("min_num")]
			[Description("最小数量")]
			public long MinNum { get; set; }

			[JsonPropertyName("max_num")]
			[Description("最大数量")]
			public long MaxNum { get; set; }

			[JsonPropertyName("max_size")]
			[Description("最大容量，单位为M")]
			public long MaxSize { get; set; }

			[JsonPropertyName("aspect_ratio")]
			[Description("素材类型为图片时的尺寸比")]
			public List<string> AspectRatio { get; set; }

			[JsonPropertyName("pixel")]
			[Description("素材类型为图片时的像素比")]
			public List<long> Pixel { get; set; }

			[JsonPropertyName("data_format")]
			[Description("数据格式类型")]
			public List<string> DataFormat { get; set; }
		}
	}
}
