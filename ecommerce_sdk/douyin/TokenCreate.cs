namespace ecommerce.sdk.douyin;

[Description("生成token API。创建token成功即可，可以定期调/token/refresh接口来刷新token避免过期，请不要频繁的调用！,推荐使用SDK进行token获取：https://op.jinritemai.com/docs/guide-docs/1041/1072#doc_anchor0.2150107369828258")]
public class TokenCreateReq : IDouyinReq<TokenCreateRsp>
{

	public string GetMethod() { return "token.create"; }

	public string GetUrl() { return "/token/create"; }

	[JsonPropertyName("code")]
	[Description("授权码；参数必传，工具型应用: 传code值；自用型应用:传")]
	public string Code { get; set; }

	[JsonPropertyName("grant_type")]
	[Description("授权类型 ；【工具型应用:authorization_code  自用型应用:authorization_self】")]
	[NotNull]
	public string GrantType { get; set; }

	[JsonPropertyName("test_shop")]
	[Description("判断测试店铺标识 ，非必传，若新增测试店铺传1，若不是则不必传")]
	public string TestShop { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public string ShopId { get; set; }

	[JsonPropertyName("auth_id")]
	[Description("授权id，用于替换shopId")]
	public string AuthId { get; set; }

	[JsonPropertyName("auth_subject_type")]
	[Description("授权主体类型，枚举值如下：YunCang -云仓；WuLiuShang -物流商；WLGongYingShang -物流供应商；MiniApp -小程序  MCN-联盟MCN机构 DouKe-联盟抖客  Colonel-联盟团长")]
	public string AuthSubjectType { get; set; }
}

[Description("生成token API。创建token成功即可，可以定期调/token/refresh接口来刷新token避免过期，请不要频繁的调用！,推荐使用SDK进行token获取：https://op.jinritemai.com/docs/guide-docs/1041/1072#doc_anchor0.2150107369828258")]
public class TokenCreateRsp
{
	[JsonPropertyName("access_token")]
	[Description("token值。 Tips： 1. 在 access_token 过期前1h之前，ISV使用 refresh_token 刷新时，会返回原来的 access_token 和 refresh_token，但是二者有效期不会变； 2. 在 access_token 过期前1h之内，ISV使用 refresh_token 刷新时，会返回新的 access_token 和 refresh_token，但是原来的 access_token 和 refresh_token 继续有效一个小时； 3. 在 access_token 过期后，ISV使用 refresh_token 刷新时，将获得新的 acces_token 和 refresh_token，同时原来的 acces_token 和 refresh_token 失效；")]
	public string AccessToken { get; set; }

	[JsonPropertyName("expires_in")]
	[Description("过期时间(秒级时间戳)")]
	public long ExpiresIn { get; set; }

	[JsonPropertyName("refresh_token")]
	[Description("刷新token值。用于刷新access_token的刷新令牌（有效期：14 天）")]
	public string RefreshToken { get; set; }

	[JsonPropertyName("scope")]
	[Description("范围")]
	public string Scope { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public long ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("authority_id")]
	[Description("授权ID")]
	public string AuthorityId { get; set; }

	[JsonPropertyName("auth_subject_type")]
	[Description("授权主体类型")]
	public string AuthSubjectType { get; set; }
}
