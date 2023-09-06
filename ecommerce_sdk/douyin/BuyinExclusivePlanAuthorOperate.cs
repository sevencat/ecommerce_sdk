namespace ecommerce.sdk.douyin;

[Description("店铺专属达人管理，包括添加达人、开启/关闭和达人删除")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4173","无效百应ID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","专属计划关联的作者不存在","isv.business-failed:4177","专属计划关联的作者不存在")]
[DouyinRetCode(50002,"业务处理失败","可见状态作者不允许删除","isv.business-failed:4178","可见状态作者不允许删除")]
[DouyinRetCode(50002,"业务处理失败","专属计划关联的作者已经存在","isv.business-failed:5120","专属计划关联的作者已经存在")]
[DouyinRetCode(50002,"业务处理失败","获取用户信息失败","isv.business-failed:4176","请检查参数后重试")]
public class BuyinExclusivePlanAuthorOperateReq : IDouyinReq<BuyinExclusivePlanAuthorOperateRsp>
{

	public string GetMethod() { return "buyin.exclusivePlanAuthorOperate"; }

	public string GetUrl() { return "/buyin/exclusivePlanAuthorOperate"; }

	[JsonPropertyName("op_type")]
	[Description("操作类型 0: 添加达人; 1: 开启达人； 2：关闭达人； 3: 删除达人")]
	[NotNull]
	public int? OpType { get; set; }

	[JsonPropertyName("author_buyin_id")]
	[Description("达人百应ID")]
	[NotNull]
	public long? AuthorBuyinId { get; set; }
}

[Description("店铺专属达人管理，包括添加达人、开启/关闭和达人删除")]
public class BuyinExclusivePlanAuthorOperateRsp
{
}
