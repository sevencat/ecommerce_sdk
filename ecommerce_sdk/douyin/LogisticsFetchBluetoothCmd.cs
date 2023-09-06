namespace ecommerce.sdk.douyin;

[Description("电子面单场景下，获取蓝牙的打印指令")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数有误，请检查请求参数","isv.parameter-invalid:100001","检查入参")]
[DouyinRetCode(50002,"业务处理失败","系统错误，请稍后重试","isv.business-failed:100002","联系开发人员")]
[DouyinRetCode(50002,"业务处理失败","101115:该模板不存在","isv.business-failed:101115","检查模板信息")]
[DouyinRetCode(50002,"业务处理失败","101113:暂不支持该品牌的打印机型号","isv.business-failed:101113","检查打印机名称")]
public class LogisticsFetchBluetoothCmdReq : IDouyinReq<LogisticsFetchBluetoothCmdRsp>
{

	public string GetMethod() { return "logistics.fetchBluetoothCmd"; }

	public string GetUrl() { return "/logistics/fetchBluetoothCmd"; }

	[JsonPropertyName("waybill_applies")]
	[Description("运单信息，一次最多请求200单。")]
	[NotNull]
	public List<WaybillAppliesItem> WaybillApplies { get; set; }

	public class WaybillAppliesItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		[NotNull]
		public string TrackNo { get; set; }

		[JsonPropertyName("std_template_code")]
		[Description("标准模板code。已支持的模板信息 https://bytedance.feishu.cn/sheets/VFmQsxJNth8t2OtWWDJca5BbnDb?sheet=p92gXy")]
		[NotNull]
		public string StdTemplateCode { get; set; }

		[JsonPropertyName("cus_template_url")]
		[Description("自定义区模板url。（传了cus_print_data后url和code其中一个必传）")]
		public string CusTemplateUrl { get; set; }

		[JsonPropertyName("cus_template_code")]
		[Description("自定义区模板code（支持模板设计器的模板）。设计器地址：https://cloudprint.douyinec.com/")]
		public string CusTemplateCode { get; set; }

		[JsonPropertyName("cus_print_data")]
		[Description("自定义区json数据")]
		public string CusPrintData { get; set; }
	}

	[JsonPropertyName("remote_print_config")]
	[Description("打印配置")]
	public RemotePrintConfigItem RemotePrintConfig { get; set; }

	public class RemotePrintConfigItem
	{
		[JsonPropertyName("need_top_logo")]
		[Description("是否需要打印物流商logo")]
		public bool? NeedTopLogo { get; set; }

		[JsonPropertyName("horizontal_offset")]
		[Description("水平偏移量，单位mm")]
		public int? HorizontalOffset { get; set; }

		[JsonPropertyName("vertical_offset")]
		[Description("垂直偏移量，单位mm")]
		public int? VerticalOffset { get; set; }

		[JsonPropertyName("print_direction")]
		[Description("打印方向。normal-正常；reverse-反转。")]
		public string PrintDirection { get; set; }

		[JsonPropertyName("printer_name")]
		[Description("打印机名称。查看已支持的打印机信息 https://bytedance.feishu.cn/sheets/VFmQsxJNth8t2OtWWDJca5BbnDb?sheet=44acf5")]
		[NotNull]
		public string PrinterName { get; set; }
	}

	[JsonPropertyName("cmd_type")]
	[Description("打印机指令类型。CPCL；TSPL")]
	[NotNull]
	public string CmdType { get; set; }

	[JsonPropertyName("cmd_encode")]
	[Description("编码方式。,origin：原串->字节数组->base64；,gbk：原串->字节数组->gbk->base64；,gzip_byte：原串->字节数组->gzip压缩->base64；")]
	[NotNull]
	public string CmdEncode { get; set; }
}

[Description("电子面单场景下，获取蓝牙的打印指令")]
public class LogisticsFetchBluetoothCmdRsp
{
	[JsonPropertyName("waybill_infos")]
	[Description("运单的打印指令")]
	public List<WaybillInfosItem> WaybillInfos { get; set; }

	public class WaybillInfosItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("print_data")]
		[Description("打印指令")]
		public string PrintData { get; set; }
	}

	[JsonPropertyName("err_infos")]
	[Description("错误信息")]
	public List<ErrInfosItem> ErrInfos { get; set; }

	public class ErrInfosItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("err_code")]
		[Description("错误code")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误msg")]
		public string ErrMsg { get; set; }
	}
}
