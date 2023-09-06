namespace ecommerce.sdk.douyin;

[Description("取消发布")]
public class OpenCloudV1DeployTicketCancelReq : IDouyinReq<OpenCloudV1DeployTicketCancelRsp>
{

	public string GetMethod() { return "openCloud.v1.deployTicket.cancel"; }

	public string GetUrl() { return "/openCloud/v1/deployTicket/cancel"; }

	[JsonPropertyName("cs_id")]
	[Description("容器服务id")]
	[NotNull]
	public string CsId { get; set; }

	[JsonPropertyName("ticket_id")]
	[Description("发布单id")]
	[NotNull]
	public string TicketId { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("取消发布")]
public class OpenCloudV1DeployTicketCancelRsp
{
}
