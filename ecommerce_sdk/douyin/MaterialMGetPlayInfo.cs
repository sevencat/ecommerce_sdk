namespace ecommerce.sdk.douyin;

[Description("该接口用于获取素材中心审核通过的视频的播放信息：,1. 视频的播放地址和封面地址带有效时间，超过有效期限将不能访问，有效时间的具体值见接口返回；,2. 如何上传视频到素材中心，请参考视频上传接口：https://op.jinritemai.com/docs/api-docs/69/1147 或 https://op.jinritemai.com/docs/api-docs/69/1617,3. 上传完视频后，如何获取素材中心视频的vid以及审核状态，请参考素材查询接口 https://op.jinritemai.com/docs/api-docs/69/1148 或 https://op.jinritemai.com/docs/api-docs/69/1145")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:20001","检查参数是否符合要求")]
[DouyinRetCode(40004,"非法的参数","审核中/审核不通过的视频不支持预览","isv.parameter-invalid:20005","等素材审核通过之后再查询")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10003","系统异常，请稍后重试")]
public class MaterialMGetPlayInfoReq : IDouyinReq<MaterialMGetPlayInfoRsp>
{

	public string GetMethod() { return "material.mGetPlayInfo"; }

	public string GetUrl() { return "/material/mGetPlayInfo"; }

	[JsonPropertyName("vid_list")]
	[Description("vid列表，列表长度(1, 20)")]
	[NotNull]
	public List<string> VidList { get; set; }
}

[Description("该接口用于获取素材中心审核通过的视频的播放信息：,1. 视频的播放地址和封面地址带有效时间，超过有效期限将不能访问，有效时间的具体值见接口返回；,2. 如何上传视频到素材中心，请参考视频上传接口：https://op.jinritemai.com/docs/api-docs/69/1147 或 https://op.jinritemai.com/docs/api-docs/69/1617,3. 上传完视频后，如何获取素材中心视频的vid以及审核状态，请参考素材查询接口 https://op.jinritemai.com/docs/api-docs/69/1148 或 https://op.jinritemai.com/docs/api-docs/69/1145")]
public class MaterialMGetPlayInfoRsp
{
	[JsonPropertyName("success_map")]
	[Description("获取成功map，key为vid，value是视频的播放信息")]
	public Dictionary<string,SuccessMapItem> SuccessMap { get; set; }

	public class SuccessMapItem
	{
		[Description("vid，素材中心搜索素材或者查素材详情接口返回的vid字段")]
		public string Vid { get; set; }

		[Description("视频高度")]
		public int Height { get; set; }

		[Description("视频宽度")]
		public int Width { get; set; }

		[Description("视频格式")]
		public string Format { get; set; }

		[Description("视频大小，单位B")]
		public long Size { get; set; }

		[Description("视频原地址")]
		public string URI { get; set; }

		[Description("视频长度(s)")]
		public decimal Duration { get; set; }

		[Description("视频封面地址")]
		public string VideoCoverUrl { get; set; }

		[Description("视频播放地址")]
		public string MainUrl { get; set; }

		[Description("视频播放地址和视频封面地址的过期时间")]
		public long MainUrlExpire { get; set; }
	}

	[JsonPropertyName("failed_map")]
	[Description("获取失败map，key为vid")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[Description("错误码")]
		public int ErrCode { get; set; }

		[Description("错误信息")]
		public string ErrMsg { get; set; }
	}
}
