namespace ecommerce.sdk.douyin;

[Description("open侧图文创意店铺准入校验")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统处理失败","isv.business-failed:2012001","重试或者联系")]
public class ProductMaterialImageTextShopAccessThresholdReq : IDouyinReq<ProductMaterialImageTextShopAccessThresholdRsp>
{

	public string GetMethod() { return "product.material.imageTextShopAccessThreshold"; }

	public string GetUrl() { return "/product/material/imageTextShopAccessThreshold"; }

}

[Description("open侧图文创意店铺准入校验")]
public class ProductMaterialImageTextShopAccessThresholdRsp
{
	[JsonPropertyName("have_threshold")]
	[Description("整体校验是否有权限，false-无权限，true-有权限")]
	public bool HaveThreshold { get; set; }

	[JsonPropertyName("threshold_detail_info")]
	[Description("具体几项校验结果")]
	public Dictionary<string,ThresholdDetailInfoItem> ThresholdDetailInfo { get; set; }

	public class ThresholdDetailInfoItem
	{
		[JsonPropertyName("have_threshold")]
		[Description("false-无权限,true-有权限")]
		public bool HaveThreshold { get; set; }

		[JsonPropertyName("threshold_name")]
		[Description("official_account_threshold：商家人店一体账号,ecommerce_sales_permission：电商直播带货权限：")]
		public string ThresholdName { get; set; }

		[JsonPropertyName("reject_name")]
		[Description("失败原因")]
		public string RejectName { get; set; }
	}
}
