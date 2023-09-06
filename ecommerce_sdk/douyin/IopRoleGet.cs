namespace ecommerce.sdk.douyin;

[Description("查询店铺身份,查询店铺身份")]
public class IopRoleGetReq : IDouyinReq<IopRoleGetRsp>
{

	public string GetMethod() { return "iop.roleGet"; }

	public string GetUrl() { return "/iop/roleGet"; }

}

[Description("查询店铺身份,查询店铺身份")]
public class IopRoleGetRsp
{
	[JsonPropertyName("role_type")]
	[Description("店铺身份：0，未知身份；1，商户；2，厂家；")]
	public int RoleType { get; set; }
}
