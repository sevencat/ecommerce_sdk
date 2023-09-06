namespace ecommerce.sdk.douyin;

[Description("接口用于查询商品 sku 信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","商品没有加入精选联盟","isv.business-failed:4133","商品没有加入精选联盟")]
[DouyinRetCode(50002,"业务处理失败","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。","isv.business-failed:8193","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。")]
[DouyinRetCode(50002,"业务处理失败","无效商品ID","isv.business-failed:265","无效商品ID")]
public class BuyinProductSkusReq : IDouyinReq<BuyinProductSkusRsp>
{

	public string GetMethod() { return "buyin.productSkus"; }

	public string GetUrl() { return "/buyin/productSkus"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("接口用于查询商品 sku 信息")]
public class BuyinProductSkusRsp
{
	[JsonPropertyName("specs")]
	[Description("商品规格信息列表")]
	public List<SpecsItem> Specs { get; set; }

	public class SpecsItem
	{
		[JsonPropertyName("name")]
		[Description("规格名字")]
		public string Name { get; set; }

		[JsonPropertyName("spec_items")]
		[Description("当前规格列表")]
		public List<SpecItemsItem> SpecItems { get; set; }

		public class SpecItemsItem
		{
			[JsonPropertyName("id")]
			[Description("规格ID")]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("规格名字")]
			public string Name { get; set; }
		}
	}

	[JsonPropertyName("pictures")]
	[Description("图片")]
	public Dictionary<string,PicturesItem> Pictures { get; set; }

	public class PicturesItem
	{
		[JsonPropertyName("little_picture")]
		[Description("小图")]
		public string LittlePicture { get; set; }

		[JsonPropertyName("big_picture")]
		[Description("大图")]
		public string BigPicture { get; set; }
	}

	[JsonPropertyName("skus")]
	[Description("sku 信息")]
	public Dictionary<string,SkusItem> Skus { get; set; }

	public class SkusItem
	{
		[JsonPropertyName("sku_id")]
		[Description("sku_id")]
		public long SkuId { get; set; }

		[JsonPropertyName("effective_price")]
		[Description("价格（单位：分）")]
		public long EffectivePrice { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("库存")]
		public long StockNum { get; set; }
	}
}
