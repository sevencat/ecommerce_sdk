namespace ecommerce.sdk.douyin;

[Description("使用场景：,1、在 access_token过期时，使用 refresh_token可以获取新的acces_token 和 refresh_token；可以保证一直是有效的access_token。,2、access_token有效期7天，refresh_token用于刷新access_token的刷新令牌，有效期：14 天；,,注意点：,1.、在 access_token 过期前1h之前，ISV使用 refresh_token 刷新时，会返回原来的 access_token 和 refresh_token，但是二者有效期不会变；,2、在 access_token 过期前1h之内，ISV使用 refresh_token 刷新时，会返回新的 access_token 和 refresh_token，但是原来的 access_token 和 refresh_token 继续有效一个小时；,3、在 access_token 过期后，ISV使用 refresh_token 刷新时，将获得新的 acces_token 和 refresh_token，同时原来的 acces_token 和 refresh_token 失效；,,推荐使用SDK进行token刷新：https://op.jinritemai.com/docs/guide-docs/1041/1072#doc_anchor0.7581191566268553")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","刷新token失败，有并发请求","isv.business-failed:31012","重新调用一次进行获取最新 token")]
public class TokenRefreshReq : IDouyinReq<TokenRefreshRsp>
{

	public string GetMethod() { return "token.refresh"; }

	public string GetUrl() { return "/token/refresh"; }

	[JsonPropertyName("refresh_token")]
	[Description("用于刷新access_token的刷新令牌；有效期：14 天；")]
	[NotNull]
	public string RefreshToken { get; set; }

	[JsonPropertyName("grant_type")]
	[Description("授权类型；请传入默认值：refresh_token")]
	[NotNull]
	public string GrantType { get; set; }
}

[Description("使用场景：,1、在 access_token过期时，使用 refresh_token可以获取新的acces_token 和 refresh_token；可以保证一直是有效的access_token。,2、access_token有效期7天，refresh_token用于刷新access_token的刷新令牌，有效期：14 天；,,注意点：,1.、在 access_token 过期前1h之前，ISV使用 refresh_token 刷新时，会返回原来的 access_token 和 refresh_token，但是二者有效期不会变；,2、在 access_token 过期前1h之内，ISV使用 refresh_token 刷新时，会返回新的 access_token 和 refresh_token，但是原来的 access_token 和 refresh_token 继续有效一个小时；,3、在 access_token 过期后，ISV使用 refresh_token 刷新时，将获得新的 acces_token 和 refresh_token，同时原来的 acces_token 和 refresh_token 失效；,,推荐使用SDK进行token刷新：https://op.jinritemai.com/docs/guide-docs/1041/1072#doc_anchor0.7581191566268553")]
public class TokenRefreshRsp
{
	[JsonPropertyName("access_token")]
	[Description("用于调用API的access_token 过期时间为expires_in值 可通过refresh_token刷新获取新的access_token，过期时间仍为expires_in值")]
	public string AccessToken { get; set; }

	[JsonPropertyName("expires_in")]
	[Description("access_token过期时间；Unix时间戳：秒")]
	public long ExpiresIn { get; set; }

	[JsonPropertyName("refresh_token")]
	[Description("用于刷新access_token的刷新令牌（有效期：14 天）")]
	public string RefreshToken { get; set; }

	[JsonPropertyName("scope")]
	[Description("权限范围")]
	public string Scope { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public long ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("authority_id")]
	[Description("授权ID,店铺授权为店铺id，达人授权为达人id；")]
	public string AuthorityId { get; set; }

	[JsonPropertyName("auth_subject_type")]
	[Description("授权主体类型")]
	public string AuthSubjectType { get; set; }
}
