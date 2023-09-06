namespace ecommerce.sdk.douyin;

[Description("上传SPU主图或实物图(用于将外部URL转为抖店URL),- 支持jpg、jpeg、png格式图片url,- 每次最多5张,- 每张图片最大5M")]
public class SpuBatchUploadImgReq : IDouyinReq<SpuBatchUploadImgRsp>
{

	public string GetMethod() { return "spu.batchUploadImg"; }

	public string GetUrl() { return "/spu/batchUploadImg"; }

	[JsonPropertyName("image_url_list")]
	[Description("图片列表")]
	[NotNull]
	public List<ImageUrlListItem> ImageUrlList { get; set; }

	public class ImageUrlListItem
	{
		[JsonPropertyName("name")]
		[Description("图片名")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("url")]
		[Description("公网可访问URL")]
		[NotNull]
		public string Url { get; set; }
	}
}

[Description("上传SPU主图或实物图(用于将外部URL转为抖店URL),- 支持jpg、jpeg、png格式图片url,- 每次最多5张,- 每张图片最大5M")]
public class SpuBatchUploadImgRsp
{
	[JsonPropertyName("success_list")]
	[Description("成功列表")]
	public List<SuccessListItem> SuccessList { get; set; }

	public class SuccessListItem
	{
		[JsonPropertyName("name")]
		[Description("图片名称")]
		public string Name { get; set; }

		[JsonPropertyName("origin_url")]
		[Description("入参URL")]
		public string OriginUrl { get; set; }

		[JsonPropertyName("spu_url")]
		[Description("抖店SPU专用URL")]
		public string SpuUrl { get; set; }
	}

	[JsonPropertyName("failed_list")]
	[Description("失败列表")]
	public List<FailedListItem> FailedList { get; set; }

	public class FailedListItem
	{
		[JsonPropertyName("name")]
		[Description("图片名")]
		public string Name { get; set; }

		[JsonPropertyName("origin_url")]
		[Description("入参URL")]
		public string OriginUrl { get; set; }

		[JsonPropertyName("err_code")]
		[Description("失败错误码")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("失败原因")]
		public string ErrMsg { get; set; }
	}
}
