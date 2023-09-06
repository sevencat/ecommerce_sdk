namespace ecommerce.sdk.douyin;

[Description("略")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","11009:手机号不存在","isv.business-failed:11009","修改入参")]
[DouyinRetCode(50002,"业务处理失败","11004:不支持该物流服务商","isv.business-failed:11004","修改入参")]
[DouyinRetCode(50002,"业务处理失败","11000:expressCompany is nil","isv.business-failed:11000","修改入参")]
[DouyinRetCode(50002,"业务处理失败","11003:系统异常","isv.business-failed:11003","重试")]
public class PowerIsByteDancePackageReq : IDouyinReq<PowerIsByteDancePackageRsp>
{

	public string GetMethod() { return "power.isByteDancePackage"; }

	public string GetUrl() { return "/power/isByteDancePackage"; }

	[JsonPropertyName("waybill_code")]
	[Description("-")]
	public string WaybillCode { get; set; }

	[JsonPropertyName("express_company")]
	[Description("-")]
	public string ExpressCompany { get; set; }
}

[Description("略")]
public class PowerIsByteDancePackageRsp
{
	[JsonPropertyName("is_bytedance_waybill")]
	[Description("是否是字节包裹")]
	public string IsBytedanceWaybill { get; set; }

	[JsonPropertyName("is_bytedance_dec")]
	[Description("是否是字节面单")]
	public string IsBytedanceDec { get; set; }

	[JsonPropertyName("sender")]
	[Description("寄件人信息")]
	public SenderItem Sender { get; set; }

	public class SenderItem
	{
		[JsonPropertyName("name")]
		[Description("-")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("-")]
		public string Mobile { get; set; }

		[JsonPropertyName("is_virtual_no")]
		[Description("-")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtual_no")]
		[Description("-")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtual_status")]
		[Description("-")]
		public string VirtualStatus { get; set; }
	}

	[JsonPropertyName("receiver")]
	[Description("收件人信息")]
	public ReceiverItem Receiver { get; set; }

	public class ReceiverItem
	{
		[JsonPropertyName("name")]
		[Description("-")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("-")]
		public string Mobile { get; set; }

		[JsonPropertyName("is_virtual_no")]
		[Description("-")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtual_no")]
		[Description("-")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtual_status")]
		[Description("-")]
		public string VirtualStatus { get; set; }
	}

	[JsonPropertyName("privacy_flag")]
	[Description("是否是虚拟号")]
	public string PrivacyFlag { get; set; }
}
