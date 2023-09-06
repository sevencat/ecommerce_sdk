namespace ecommerce.sdk.douyin;

[Description("提交运单号,容器号,重量/体积等操作对象信息,  获取分拣指令信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","无法识别的面单号","isv.business-failed:3000","无法识别的面单号")]
public class YuncFetchSortingInstructionReq : IDouyinReq<YuncFetchSortingInstructionRsp>
{

	public string GetMethod() { return "yunc.fetchSortingInstruction"; }

	public string GetUrl() { return "/yunc/fetchSortingInstruction"; }

	[JsonPropertyName("scene_name")]
	[Description("场景名称: 快递分拣:`express_sorting`; 详细枚举值请联系仓储团队获取")]
	[NotNull]
	public string SceneName { get; set; }

	[JsonPropertyName("hu_ident_code")]
	[Description("操作对象识别码, 如 面单号, 容器条码等")]
	[NotNull]
	public string HuIdentCode { get; set; }

	[JsonPropertyName("weight")]
	[Description("重量(单位g)")]
	public long? Weight { get; set; }

	[JsonPropertyName("labor_id")]
	[Description("劳动力ID, 对于设备来说是就是deviceId")]
	[NotNull]
	public string LaborId { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展信息")]
	public Dictionary<string,string> Extend { get; set; }
}

[Description("提交运单号,容器号,重量/体积等操作对象信息,  获取分拣指令信息")]
public class YuncFetchSortingInstructionRsp
{
	[JsonPropertyName("sorting_instruction")]
	[Description("分拣指令")]
	public SortingInstructionItem SortingInstruction { get; set; }

	public class SortingInstructionItem
	{
		[JsonPropertyName("sorting_grid_no")]
		[Description("分拣格口号")]
		public string SortingGridNo { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展信息")]
		public Dictionary<string,string> Extend { get; set; }
	}
}
