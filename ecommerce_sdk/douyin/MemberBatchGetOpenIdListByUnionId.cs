namespace ecommerce.sdk.douyin;

[Description("Q：同品牌下多个店铺，用户在一个店铺成为品牌会员后，其他店铺无需入会，自动成为会员，那么服务商如何获取品牌下每个店铺的用户OpenId？,A：服务商可以使用当前接口，根据品牌维度的用户唯一身份UnionId来查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","UnionId非法，无法正常解析","isv.parameter-invalid:628145021","请确保传入的unionId数据准确 且 和当前店铺有关联")]
[DouyinRetCode(50002,"业务处理失败","用户不是当前店铺的会员或者会员已解绑","isv.business-failed:628145022","仅允许当前店铺品牌会员的unionId来查询")]
[DouyinRetCode(50002,"业务处理失败","请求的店铺非品牌店铺","isv.business-failed:628145023","请确保请求店铺是品牌店铺")]
[DouyinRetCode(50002,"业务处理失败","商家未开通会员体系","isv.business-failed:628005200","请确保请求店铺已开通会员体系")]
public class MemberBatchGetOpenIdListByUnionIdReq : IDouyinReq<MemberBatchGetOpenIdListByUnionIdRsp>
{

	public string GetMethod() { return "member.batchGetOpenIdListByUnionId"; }

	public string GetUrl() { return "/member/batchGetOpenIdListByUnionId"; }

	[JsonPropertyName("union_id_list")]
	[Description("注意： 1）该接口一次最多进行10个UnionId的解析。 2）任意一个unionId不合法都可能导致整个批量请求失败，请传入正确的unionId")]
	[NotNull]
	public List<string> UnionIdList { get; set; }
}

[Description("Q：同品牌下多个店铺，用户在一个店铺成为品牌会员后，其他店铺无需入会，自动成为会员，那么服务商如何获取品牌下每个店铺的用户OpenId？,A：服务商可以使用当前接口，根据品牌维度的用户唯一身份UnionId来查询")]
public class MemberBatchGetOpenIdListByUnionIdRsp
{
	[JsonPropertyName("open_ids_info_list")]
	[Description("返回的结果列表")]
	public List<OpenIdsInfoListItem> OpenIdsInfoList { get; set; }

	public class OpenIdsInfoListItem
	{
		[JsonPropertyName("success")]
		[Description("当前这个union_id是否查询openId列表成功，true表示成功，false表示失败")]
		public bool Success { get; set; }

		[JsonPropertyName("union_id")]
		[Description("用户品牌唯一身份，对应请求中的每一个unionId")]
		public string UnionId { get; set; }

		[JsonPropertyName("open_id_list")]
		[Description("根据unionId查询到的openId列表")]
		public List<OpenIdListItem> OpenIdList { get; set; }

		public class OpenIdListItem
		{
			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("open_id")]
			[Description("店铺维度的用户身份ID")]
			public string OpenId { get; set; }
		}

		[JsonPropertyName("err_code")]
		[Description("success=false（即失败）时会返回对应的错误code和错误描述 - 628145021 UnionId非法，无法正常解析 - 628145022 用户不是当前店铺的会员或者会员已解绑 - 628145023 请求的店铺非品牌店铺 - 628005200 商家未开通会员体系")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("success=false（即失败）时会返回对应的错误code和错误描述")]
		public string ErrMsg { get; set; }
	}
}
