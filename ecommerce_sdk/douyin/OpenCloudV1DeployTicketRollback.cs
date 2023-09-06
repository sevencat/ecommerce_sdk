namespace ecommerce.sdk.douyin;

[Description("发布单回滚")]
public class OpenCloudV1DeployTicketRollbackReq : IDouyinReq<OpenCloudV1DeployTicketRollbackRsp>
{

	public string GetMethod() { return "openCloud.v1.deployTicket.rollback"; }

	public string GetUrl() { return "/openCloud/v1/deployTicket/rollback"; }

	[JsonPropertyName("ticket_id")]
	[Description("发布单id")]
	[NotNull]
	public string TicketId { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("发布单回滚")]
public class OpenCloudV1DeployTicketRollbackRsp
{
}
