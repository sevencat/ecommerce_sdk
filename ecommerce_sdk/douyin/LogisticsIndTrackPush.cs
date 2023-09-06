namespace ecommerce.sdk.douyin;

[Description("当注册成功后，有新的轨迹产生，需要由即时配公司将最新内容推送给我方")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:-10001","检查入参")]
[DouyinRetCode(40004,"非法的参数","company参数错误","isv.parameter-invalid:-20005","检查入参")]
public class LogisticsIndTrackPushReq : IDouyinReq<LogisticsIndTrackPushRsp>
{

	public string GetMethod() { return "logistics.indTrackPush"; }

	public string GetUrl() { return "/logistics/indTrackPush"; }

	[JsonPropertyName("cur_time")]
	[Description("请求时间")]
	[NotNull]
	public string CurTime { get; set; }

	[JsonPropertyName("company")]
	[Description("公司编码")]
	[NotNull]
	public string Company { get; set; }

	[JsonPropertyName("trace_msgs")]
	[Description("轨迹信息")]
	[NotNull]
	public List<TraceMsgsItem> TraceMsgs { get; set; }

	public class TraceMsgsItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		[NotNull]
		public string TrackNo { get; set; }

		[JsonPropertyName("traces")]
		[Description("轨迹列表")]
		[NotNull]
		public List<TracesItem> Traces { get; set; }

		public class TracesItem
		{
			[JsonPropertyName("opcode")]
			[Description("事件编码")]
			[NotNull]
			public string Opcode { get; set; }

			[JsonPropertyName("op_time")]
			[Description("事件操作时间")]
			[NotNull]
			public string OpTime { get; set; }

			[JsonPropertyName("content")]
			[Description("文案")]
			[NotNull]
			public string Content { get; set; }

			[JsonPropertyName("rider")]
			[Description("骑手信息")]
			public RiderItem Rider { get; set; }

			public class RiderItem
			{
				[JsonPropertyName("name")]
				[Description("骑手姓名")]
				[NotNull]
				public string Name { get; set; }

				[JsonPropertyName("mobile")]
				[Description("骑手电话号码")]
				[NotNull]
				public string Mobile { get; set; }
			}

			[JsonPropertyName("third_party_company")]
			[Description("三方运力公司，顺丰同城 sftc 闪送 shansong 达达 dada UU uupt 美团 meituan 蜂鸟 fengniao")]
			public string ThirdPartyCompany { get; set; }

			[JsonPropertyName("exception_code")]
			[Description("异常编码,“1001” 联系不上门店 “1002” 门店地址错误 “2001” 联系不上顾客 “2002” 顾客地址错误 “2003” 更改顾客配送地址 “3001” 托寄物损坏 “3002” 托寄物丢失 “4001” 服务商系统异常 “5001” 内部系统异常 “9000” 其他分类 “9999” 未知分类")]
			public string ExceptionCode { get; set; }

			[JsonPropertyName("exception_desc")]
			[Description("异常原因")]
			public string ExceptionDesc { get; set; }

			[JsonPropertyName("cancel_code")]
			[Description("取消编码，“1000” 商户原因取消 “2000” 消费者原因取消 “3000” 骑手原因取消 “4000” 即时配公司原因取消")]
			public string CancelCode { get; set; }

			[JsonPropertyName("cancel_desc")]
			[Description("取消原因")]
			public string CancelDesc { get; set; }
		}
	}
}

[Description("当注册成功后，有新的轨迹产生，需要由即时配公司将最新内容推送给我方")]
public class LogisticsIndTrackPushRsp
{
}
