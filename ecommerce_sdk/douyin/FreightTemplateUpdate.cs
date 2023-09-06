namespace ecommerce.sdk.douyin;

[Description("更新运费模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","入参校验未通过","isv.parameter-invalid:422","-")]
[DouyinRetCode(40004,"非法的参数","运费规则和普通运费规则选择的地址有冲突","isv.parameter-invalid:425","-")]
[DouyinRetCode(40004,"非法的参数","模板被锁定","isv.parameter-invalid:426","-")]
[DouyinRetCode(40004,"非法的参数","发货地址为空","isv.parameter-invalid:428","补充发货省份或者城市")]
[DouyinRetCode(40004,"非法的参数","非拍卖资质的商家不可创建运费到付的模板","isv.parameter-invalid:429","-")]
[DouyinRetCode(20000,"系统错误","内部异常，请重试","isp.service-error:500","-")]
public class FreightTemplateUpdateReq : IDouyinReq<FreightTemplateUpdateRsp>
{

	public string GetMethod() { return "freightTemplate.update"; }

	public string GetUrl() { return "/freightTemplate/update"; }

	[JsonPropertyName("template")]
	[Description("运费模板相关")]
	[NotNull]
	public TemplateItem Template { get; set; }

	public class TemplateItem
	{
		[JsonPropertyName("id")]
		[Description("要更新的运费模板id")]
		[NotNull]
		public long? Id { get; set; }

		[JsonPropertyName("template_name")]
		[Description("模板名称")]
		[NotNull]
		public string TemplateName { get; set; }

		[JsonPropertyName("product_province")]
		[Description("发货省份")]
		public long? ProductProvince { get; set; }

		[JsonPropertyName("product_city")]
		[Description("发货城市")]
		public long? ProductCity { get; set; }

		[JsonPropertyName("calculate_type")]
		[Description("计价方式-1.按重量 2.按数量；模板类型为1、2、3时，计价类型传2")]
		public long? CalculateType { get; set; }

		[JsonPropertyName("transfer_type")]
		[Description("快递方式-1.快递")]
		public long? TransferType { get; set; }

		[JsonPropertyName("rule_type")]
		[Description("模板类型-0:阶梯计价 1:固定运费 2:卖家包邮 3:货到付款")]
		public long? RuleType { get; set; }

		[JsonPropertyName("fixed_amount")]
		[Description("固定运费金额(单位:分) 固定运费模板必填 1-9900之间的整数")]
		public long? FixedAmount { get; set; }
	}

	[JsonPropertyName("columns")]
	[Description("运费模板规则信息；每种类型模板可创建的规则类型: 阶梯计价模板-默认规则，普通计价规则，包邮规则，限运规则;固定运费模板-包邮规则，限运规则;固定运费模板-包邮规则，限运规则;包邮模板-限运规则;货到付款模板-限运规则")]
	public List<ColumnsItem> Columns { get; set; }

	public class ColumnsItem
	{
		[JsonPropertyName("first_weight")]
		[Description("首重(单位:kg) 按重量计价必填 0.1-999.9之间的小数，小数点后一位")]
		public decimal? FirstWeight { get; set; }

		[JsonPropertyName("first_weight_price")]
		[Description("首重价格(单位:元) 按重量计价必填 0.00-30.00之间的小数，小数点后两位")]
		public decimal? FirstWeightPrice { get; set; }

		[JsonPropertyName("first_num")]
		[Description("首件数量(单位:个) 按数量计价必填 1-999的整数")]
		public long? FirstNum { get; set; }

		[JsonPropertyName("first_num_price")]
		[Description("首件价格(单位:元)按数量计价必填 0.00-30.00之间的小数，小数点后两位")]
		public decimal? FirstNumPrice { get; set; }

		[JsonPropertyName("add_weight")]
		[Description("续重(单位:kg) 按重量计价必填 0.1-999.9之间的小数，小数点后一位")]
		public decimal? AddWeight { get; set; }

		[JsonPropertyName("add_weight_price")]
		[Description("续重价格(单位:元) 按重量计价必填 0.00-30.00之间的小数，小数点后两位")]
		public decimal? AddWeightPrice { get; set; }

		[JsonPropertyName("add_num")]
		[Description("续件(单位：个)calculate_type=2必填 1-999的整数")]
		public long? AddNum { get; set; }

		[JsonPropertyName("add_num_price")]
		[Description("续件价格(单位:元) 按数量计价必填 0.00-30.00之间的小数，小数点后两位")]
		public decimal? AddNumPrice { get; set; }

		[JsonPropertyName("is_default")]
		[Description("是否默认计价方式(1:是；0:不是)")]
		public long? IsDefault { get; set; }

		[JsonPropertyName("is_limited")]
		[Description("是否限运规则")]
		public bool? IsLimited { get; set; }

		[JsonPropertyName("rule_address")]
		[Description("当前规则生效的地址，非默认规则必填。map<i64, map<i64, map<i64, list<i64>>>>的json格式，省->市->区->街道，填至选择到的层级即可，仅限售规则支持四级街道")]
		public string RuleAddress { get; set; }

		[JsonPropertyName("is_over_free")]
		[Description("是否包邮规则")]
		public bool? IsOverFree { get; set; }

		[JsonPropertyName("over_weight")]
		[Description("满xx重量包邮(单位:kg)0.1-10.0之间的小数，小数点后一位")]
		public decimal? OverWeight { get; set; }

		[JsonPropertyName("over_amount")]
		[Description("满xx金额包邮(单位:分)10-99900的整数")]
		public long? OverAmount { get; set; }

		[JsonPropertyName("over_num")]
		[Description("满xx件包邮 1-10之间的整数")]
		public long? OverNum { get; set; }

		[JsonPropertyName("min_sku_amount")]
		[Description("最小金额限制，单位分，不限制填-1")]
		public long? MinSkuAmount { get; set; }

		[JsonPropertyName("max_sku_amount")]
		[Description("最大金额限制，单位分，不限制填-1")]
		public long? MaxSkuAmount { get; set; }

		[JsonPropertyName("province_infos")]
		[Description("当前规则生效的地址，统一以List<Struct>结构返回，该结构为嵌套结构。对应的json格式为[{id:32,children:[{id:320500,children:[{id:320508,children:[{id:320508014},{id:320508004}]}]}]}] 注意：返回的为最新的四级地址版本（地址存储升级变更的可能，以最新的返回）")]
		public List<ProvinceInfosItem> ProvinceInfos { get; set; }

		public class ProvinceInfosItem
		{
			[JsonPropertyName("id")]
			[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
			public long? Id { get; set; }

			[JsonPropertyName("children")]
			[Description("下一级地址信息")]
			public List<ChildrenItem> Children { get; set; }

			public class ChildrenItem
			{
				[JsonPropertyName("id")]
				[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
				public long? Id { get; set; }

				[JsonPropertyName("children")]
				[Description("下一级地址信息")]
				public List<ChildrenIItem> ChildrenI { get; set; }

				public class ChildrenIItem
				{
					[JsonPropertyName("id")]
					[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
					public long? Id { get; set; }

					[JsonPropertyName("children")]
					[Description("下一级地址信息")]
					public List<ChildrenItem> Children { get; set; }

					public class ChildrenItem
					{
						[JsonPropertyName("id")]
						[Description("地址id，第一级是省份、第二级是城市、第三级是区、第四级是街道")]
						public long? Id { get; set; }
					}
				}
			}
		}
	}
}

[Description("更新运费模板")]
public class FreightTemplateUpdateRsp
{
	[JsonPropertyName("template_id")]
	[Description("运费模板id")]
	public long TemplateId { get; set; }
}
