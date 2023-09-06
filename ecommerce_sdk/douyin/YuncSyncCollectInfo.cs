namespace ecommerce.sdk.douyin;

[Description("新品采集接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","缺少必选参数","isv.missing-parameter:1001","根据错误提示信息修改")]
[DouyinRetCode(50002,"业务处理失败","鉴权失败","isv.business-failed:1003","鉴权失败")]
public class YuncSyncCollectInfoReq : IDouyinReq<YuncSyncCollectInfoRsp>
{

	public string GetMethod() { return "yunc.syncCollectInfo"; }

	public string GetUrl() { return "/yunc/syncCollectInfo"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("cargo_code")]
	[Description("货品编码")]
	[NotNull]
	public string CargoCode { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	[NotNull]
	public string OwnerCode { get; set; }

	[JsonPropertyName("weight")]
	[Description("单品重量，单位为g；(为空)或(>=0且<=50000)；")]
	public long? Weight { get; set; }

	[JsonPropertyName("length")]
	[Description("单品长，单位为cm；(为空)或(>=0且<=1000)；")]
	public long? Length { get; set; }

	[JsonPropertyName("width")]
	[Description("单品宽，单位为cm；(为空)或(>=0且<=1000)；")]
	public long? Width { get; set; }

	[JsonPropertyName("height")]
	[Description("单品高，单位为cm；(为空)或(>=0且<=1000)；")]
	public long? Height { get; set; }

	[JsonPropertyName("carton_list")]
	[Description("箱规列表")]
	public List<CartonListItem> CartonList { get; set; }

	public class CartonListItem
	{
		[JsonPropertyName("carton")]
		[Description("采购箱规，单位为件；(为空)或(>=0且<=10000)； 保留2位小数；")]
		public decimal? Carton { get; set; }

		[JsonPropertyName("carton_weight")]
		[Description("箱规重量，单位为g；(为空)或(>=0且<=50000)；")]
		public long? CartonWeight { get; set; }

		[JsonPropertyName("carton_length")]
		[Description("箱规长，单位为cm；(为空)或(>=0且<=1000)；")]
		public long? CartonLength { get; set; }

		[JsonPropertyName("carton_width")]
		[Description("箱规宽，单位为cm；(为空)或(>=0且<=1000)；")]
		public long? CartonWidth { get; set; }

		[JsonPropertyName("carton_height")]
		[Description("箱规高，单位为cm；(为空)或(>=0且<=1000)；")]
		public long? CartonHeight { get; set; }

		[JsonPropertyName("loading_standard")]
		[Description("装盘标准，表示一个托盘上放置的采购箱规下的箱数； (为空)或(>=0且<=10000)； 保留2位小数；")]
		public decimal? LoadingStandard { get; set; }

		[JsonPropertyName("carton_picture_list")]
		[Description("单品净重图片列表")]
		public List<string> CartonPictureList { get; set; }
	}

	[JsonPropertyName("update_time")]
	[Description("更新时间")]
	[NotNull]
	public long? UpdateTime { get; set; }

	[JsonPropertyName("expiry_date")]
	[Description("货品保质期，单位为天；(为空)或(>=0且<=36500)；")]
	public long? ExpiryDate { get; set; }

	[JsonPropertyName("weight_picture_list")]
	[Description("单品重量图片列表")]
	public List<string> WeightPictureList { get; set; }

	[JsonPropertyName("length_picture_list")]
	[Description("单品长图片列表")]
	public List<string> LengthPictureList { get; set; }

	[JsonPropertyName("width_picture_list")]
	[Description("单品宽图片列表")]
	public List<string> WidthPictureList { get; set; }

	[JsonPropertyName("height_picture_list")]
	[Description("单品高图片列表")]
	public List<string> HeightPictureList { get; set; }

	[JsonPropertyName("expiry_date_picture_list")]
	[Description("货品保质期图片列表")]
	public List<string> ExpiryDatePictureList { get; set; }

	[JsonPropertyName("net_weight")]
	[Description("单位为g；(为空)或(>=0且<=50000)； 指货品的净重；")]
	public long? NetWeight { get; set; }

	[JsonPropertyName("net_weight_picture_list")]
	[Description("单品净重图片列表")]
	public List<string> NetWeightPictureList { get; set; }

	[JsonPropertyName("barcode_info_list")]
	[Description("条码信息列表")]
	public List<BarcodeInfoListItem> BarcodeInfoList { get; set; }

	public class BarcodeInfoListItem
	{
		[JsonPropertyName("barcode")]
		[Description("条码")]
		public string Barcode { get; set; }

		[JsonPropertyName("barcode_picture")]
		[Description("条码图片")]
		public string BarcodePicture { get; set; }
	}
}

[Description("新品采集接口")]
public class YuncSyncCollectInfoRsp
{
	[JsonPropertyName("code")]
	[Description("错误code")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }

	[JsonPropertyName("data")]
	[Description("结构体")]
	public long Data { get; set; }
}
