namespace ecommerce.sdk.douyin;

[Description("根据结构体入参，构建并返回素材图片")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:10001","请按文档检查入参")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:10005","系统错误，请重试")]
public class ProductBatchCreatePrettifyPicReq : IDouyinReq<ProductBatchCreatePrettifyPicRsp>
{

	public string GetMethod() { return "product.batchCreatePrettifyPic"; }

	public string GetUrl() { return "/product/batchCreatePrettifyPic"; }

	[JsonPropertyName("prettify_pic_data_list")]
	[Description("数组 用于批量构建图片。每批需要小于5")]
	[NotNull]
	public List<PrettifyPicDataListItem> PrettifyPicDataList { get; set; }

	public class PrettifyPicDataListItem
	{
		[JsonPropertyName("name")]
		[Description("要转换的组件类型 目前可选:text  后续会推出其他类型的支持组件")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("prettify_pic_data_text")]
		[Description("当name=text时有效")]
		[NotNull]
		public PrettifyPicDataTextItem PrettifyPicDataText { get; set; }

		public class PrettifyPicDataTextItem
		{
			[JsonPropertyName("text")]
			[Description("文案内容 不可以超过5000字。生成的图片如果高度超过20000px会生成失败，请注意")]
			[NotNull]
			public string Text { get; set; }

			[JsonPropertyName("background_color")]
			[Description("非必填。背景色")]
			public string BackgroundColor { get; set; }

			[JsonPropertyName("font_color")]
			[Description("非必填。字颜色")]
			public string FontColor { get; set; }

			[JsonPropertyName("font_size")]
			[Description("非必填。字号大小，在13~20之间")]
			public long? FontSize { get; set; }

			[JsonPropertyName("text_align")]
			[Description("非必填。可选left、right、center；默认left")]
			public string TextAlign { get; set; }
		}
	}
}

[Description("根据结构体入参，构建并返回素材图片")]
public class ProductBatchCreatePrettifyPicRsp
{
	[JsonPropertyName("prettify_pic_list")]
	[Description("返回内容，与入参顺序对应")]
	public List<PrettifyPicListItem> PrettifyPicList { get; set; }

	public class PrettifyPicListItem
	{
		[JsonPropertyName("img_url")]
		[Description("图片url")]
		public string ImgUrl { get; set; }

		[JsonPropertyName("width")]
		[Description("图片宽度")]
		public long Width { get; set; }

		[JsonPropertyName("height")]
		[Description("图片高度")]
		public long Height { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("错误内容")]
		public string ErrorMsg { get; set; }

		[JsonPropertyName("is_success")]
		[Description("是否正确生成")]
		public bool IsSuccess { get; set; }
	}
}
