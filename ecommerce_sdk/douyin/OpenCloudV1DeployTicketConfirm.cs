namespace ecommerce.sdk.douyin;

[Description("确认发布，触发服务发布")]
public class OpenCloudV1DeployTicketConfirmReq : IDouyinReq<OpenCloudV1DeployTicketConfirmRsp>
{

	public string GetMethod() { return "openCloud.v1.deployTicket.confirm"; }

	public string GetUrl() { return "/openCloud/v1/deployTicket/confirm"; }

	[JsonPropertyName("cs_id")]
	[Description("容器id")]
	[NotNull]
	public string CsId { get; set; }

	[JsonPropertyName("ticket_id")]
	[Description("发布单id")]
	[NotNull]
	public string TicketId { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("2100044514")]
	public long? VolcAccountId { get; set; }
}

[Description("确认发布，触发服务发布")]
public class OpenCloudV1DeployTicketConfirmRsp
{
}
