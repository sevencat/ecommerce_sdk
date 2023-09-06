namespace ecommerce.sdk.douyin;

[Description("open获取运费模板详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","模板丢失","isp.service-error:3","模板丢失")]
[DouyinRetCode(20000,"系统错误","模板未找到","isp.service-error:2","模板未找到")]
public class FreightTemplateDetailReq : IDouyinReq<FreightTemplateDetailRsp>
{

	public string GetMethod() { return "freightTemplate.detail"; }

	public string GetUrl() { return "/freightTemplate/detail"; }

	[JsonPropertyName("freight_id")]
	[Description("模板id")]
	[NotNull]
	public long? FreightId { get; set; }
}

[Description("open获取运费模板详情")]
public class FreightTemplateDetailRsp
{
	[JsonPropertyName("data")]
	[Description("模板详情")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("template")]
		[Description("模板信息")]
		public TemplateItem Template { get; set; }

		public class TemplateItem
		{
			[JsonPropertyName("id")]
			[Description("模板id")]
			public long Id { get; set; }

			[JsonPropertyName("template_name")]
			[Description("模板名称")]
			public string TemplateName { get; set; }

			[JsonPropertyName("product_province")]
			[Description("发货省份id")]
			public string ProductProvince { get; set; }

			[JsonPropertyName("product_city")]
			[Description("发货城市id")]
			public string ProductCity { get; set; }

			[JsonPropertyName("calculate_type")]
			[Description("计价方式-1.按重量计价 2.按数量计价")]
			public long CalculateType { get; set; }

			[JsonPropertyName("transfer_type")]
			[Description("快递方式-1.快递 目前仅支持1")]
			public long TransferType { get; set; }

			[JsonPropertyName("rule_type")]
			[Description("模板类型-0:阶梯计价 1:固定运费 2:卖家包邮 3:货到付款")]
			public long RuleType { get; set; }

			[JsonPropertyName("fixed_amount")]
			[Description("固定运费金额(单位:分) 固定运费模板必填 1-9900之间的整数")]
			public long FixedAmount { get; set; }
		}

		[JsonPropertyName("columns")]
		[Description("规则")]
		public List<ColumnsItem> Columns { get; set; }

		public class ColumnsItem
		{
			[JsonPropertyName("first_weight")]
			[Description("首重(单位:kg) 按重量计价必填 0.1-999.9之间的小数，小数点后一位")]
			public decimal FirstWeight { get; set; }

			[JsonPropertyName("first_weight_price")]
			[Description("首重价格(单位:元) 按重量计价必填 0.00-30.00之间的小数，小数点后两位")]
			public decimal FirstWeightPrice { get; set; }

			[JsonPropertyName("first_num")]
			[Description("首件数量(单位:个) 按数量计价必填 1-999的整数")]
			public long FirstNum { get; set; }

			[JsonPropertyName("first_num_price")]
			[Description("首件价格(单位:元)按数量计价必填 0.00-30.00之间的小数，小数点后两位")]
			public decimal FirstNumPrice { get; set; }

			[JsonPropertyName("add_weight")]
			[Description("续重(单位:kg) 按重量计价必填 0.1-999.9之间的小数，小数点后一位")]
			public decimal AddWeight { get; set; }

			[JsonPropertyName("add_weight_price")]
			[Description("续重价格(单位:元) 按重量计价必填 0.00-30.00之间的小数，小数点后两位")]
			public decimal AddWeightPrice { get; set; }

			[JsonPropertyName("add_num")]
			[Description("续件(单位:个) 按数量计价必填 1-999的整数")]
			public long AddNum { get; set; }

			[JsonPropertyName("add_num_price")]
			[Description("续件价格(单位:元) 按数量计价必填 0.00-30.00之间的小数，小数点后两位")]
			public decimal AddNumPrice { get; set; }

			[JsonPropertyName("is_default")]
			[Description("是否默认计价方式(1:是；0:不是)")]
			public long IsDefault { get; set; }

			[JsonPropertyName("is_limited")]
			[Description("是否限运规则")]
			public bool IsLimited { get; set; }

			[JsonPropertyName("is_over_free")]
			[Description("是否包邮规则")]
			public bool IsOverFree { get; set; }

			[JsonPropertyName("over_weight")]
			[Description("满xx重量包邮(单位:kg)0.1-10.0之间的小数，小数点后一位")]
			public decimal OverWeight { get; set; }

			[JsonPropertyName("over_amount")]
			[Description("满xx金额包邮(单位:分)10-99900的整数")]
			public long OverAmount { get; set; }

			[JsonPropertyName("over_num")]
			[Description("满xx件包邮 1-10之间的整数")]
			public long OverNum { get; set; }

			[JsonPropertyName("province_infos")]
			[Description("当前规则生效的地址，统一以List<Struct>结构返回，该结构为嵌套结构。对应的json格式为[{id:32,children:[{id:320500,children:[{id:320508,children:[{id:320508014},{id:320508004}]}]}]}] 注意：返回的为最新的四级地址版本（地址存储升级变更的可能，以最新的返回）")]
			public List<ProvinceInfosItem> ProvinceInfos { get; set; }

			public class ProvinceInfosItem
			{
				[JsonPropertyName("id")]
				[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
				public string Id { get; set; }

				[JsonPropertyName("children")]
				[Description("下一级地址信息")]
				public List<ChildrenItem> Children { get; set; }

				public class ChildrenItem
				{
					[JsonPropertyName("id")]
					[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
					public string Id { get; set; }

					[JsonPropertyName("children")]
					[Description("下一级地址信息")]
					public List<ChildrenIItem> ChildrenI { get; set; }

					public class ChildrenIItem
					{
						[JsonPropertyName("id")]
						[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
						public string Id { get; set; }

						[JsonPropertyName("children")]
						[Description("下一级地址信息")]
						public List<ChildrenItem> Children { get; set; }

						public class ChildrenItem
						{
							[JsonPropertyName("id")]
							[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
							public string Id { get; set; }
						}
					}
				}
			}
		}
	}
}
