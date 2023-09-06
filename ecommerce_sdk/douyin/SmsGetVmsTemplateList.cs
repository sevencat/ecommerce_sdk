namespace ecommerce.sdk.douyin;

[Description("获取视频短信模板list")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:628005100","业务处理失败，请检查请求参数")]
[DouyinRetCode(40004,"非法的参数","请求入参非法","isv.parameter-invalid:628002001","请检查请求入参")]
public class SmsGetVmsTemplateListReq : IDouyinReq<SmsGetVmsTemplateListRsp>
{

	public string GetMethod() { return "sms.getVmsTemplateList"; }

	public string GetUrl() { return "/sms/getVmsTemplateList"; }

	[JsonPropertyName("sms_account")]
	[Description("短信account")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("name")]
	[Description("模板名称")]
	public string Name { get; set; }

	[JsonPropertyName("signature")]
	[Description("模板签名")]
	public string Signature { get; set; }

	[JsonPropertyName("template_id")]
	[Description("模板id")]
	public string TemplateId { get; set; }

	[JsonPropertyName("status")]
	[Description("状态,1：字节审核中,2：字节审核拒绝,3：字节审核通过,4 ：字节审核关闭,5：字节审核免审,6：运营商审核中,7：运营商审核失败,8：运营商审核通过")]
	public List<long> Status { get; set; }

	[JsonPropertyName("page_index")]
	[Description("分页页数，从1开始")]
	public long? PageIndex { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小")]
	public long? PageSize { get; set; }
}

[Description("获取视频短信模板list")]
public class SmsGetVmsTemplateListRsp
{
	[JsonPropertyName("result")]
	[Description("结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("template_id")]
		[Description("模板id")]
		public string TemplateId { get; set; }

		[JsonPropertyName("template_name")]
		[Description("模板名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("content")]
		[Description("内容,json序列化后的字符串")]
		public string Content { get; set; }

		[JsonPropertyName("status")]
		[Description("状态,1：字节审核中,2：字节审核拒绝,3：字节审核通过,4 ：字节审核关闭,5：字节审核免审,6：运营商审核中,7：运营商审核失败,8：运营商审核通过")]
		public long Status { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("channel_type")]
		[Description("发送类型，固定为CN_VMS")]
		public string ChannelType { get; set; }

		[JsonPropertyName("signature")]
		[Description("需要用到的短信签名")]
		public string Signature { get; set; }

		[JsonPropertyName("theme")]
		[Description("短信模板主题")]
		public string Theme { get; set; }

		[JsonPropertyName("desc")]
		[Description("短信模板描述")]
		public string Desc { get; set; }

		[JsonPropertyName("carrier_status")]
		[Description("运营商结果")]
		public CarrierStatusItem CarrierStatus { get; set; }

		public class CarrierStatusItem
		{
			[JsonPropertyName("china_mobile")]
			[Description("中国移动")]
			public ChinaMobileItem ChinaMobile { get; set; }

			public class ChinaMobileItem
			{
				[JsonPropertyName("status")]
				[Description("审核状态； 1: 审核中；2: 审核失败； 3: 审核通过")]
				public long Status { get; set; }

				[JsonPropertyName("reason")]
				[Description("拒审理由")]
				public string Reason { get; set; }
			}

			[JsonPropertyName("china_telecom")]
			[Description("中国电信")]
			public ChinaTelecomItem ChinaTelecom { get; set; }

			public class ChinaTelecomItem
			{
				[JsonPropertyName("status")]
				[Description("审核状态； 1: 审核中；2: 审核失败； 3: 审核通过")]
				public long Status { get; set; }

				[JsonPropertyName("reason")]
				[Description("拒审理由")]
				public string Reason { get; set; }
			}

			[JsonPropertyName("china_unicom")]
			[Description("中国联通")]
			public ChinaUnicomItem ChinaUnicom { get; set; }

			public class ChinaUnicomItem
			{
				[JsonPropertyName("status")]
				[Description("审核状态； 1: 审核中；2: 审核失败； 3: 审核通过")]
				public long Status { get; set; }

				[JsonPropertyName("reason")]
				[Description("拒审理由")]
				public string Reason { get; set; }
			}
		}
	}

	[JsonPropertyName("total")]
	[Description("数量")]
	public long Total { get; set; }
}
