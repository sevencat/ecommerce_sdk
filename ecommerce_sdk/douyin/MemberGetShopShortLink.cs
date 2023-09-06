namespace ecommerce.sdk.douyin;

[Description("根据商家传入的链接类型，返回对应页面的跳转链接（短链），链接可发放于站外触达工具（如：短信&微信），召回用户 1.会员中心页，商家会员中心页，查看用户积分和会员可用权益 2.达人主页，与店铺人店一体绑定的达人账号主页 3.店铺首页，商家抖店店铺的首页 4.商品详情页-需额外传入商品id，进入对应商详 5.订单详情页-需额外传入订单id，用户只可查看自己账号下单的订单详情页 6.优惠券链接-需额外传入优惠券id")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","当前店铺未开通会员服务","isv.business-failed:-300002","检查类型参数，未开通店铺会员的商家无会员中心链接")]
[DouyinRetCode(20000,"系统错误","服务器开小差了，请稍后重试","isp.service-error:-500","请稍后重试")]
public class MemberGetShopShortLinkReq : IDouyinReq<MemberGetShopShortLinkRsp>
{

	public string GetMethod() { return "member.getShopShortLink"; }

	public string GetUrl() { return "/member/getShopShortLink"; }

	[JsonPropertyName("link_type")]
	[Description("链接类型（1-会员中心，2-达人主页，3-店铺首页）")]
	[NotNull]
	public long? LinkType { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id，生成商品详情页链接需要")]
	public string ProductId { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单id，生成订单详情页链接需要")]
	public string OrderId { get; set; }

	[JsonPropertyName("coupon_meta_id")]
	[Description("优惠券id，生成领取优惠券链接需要")]
	public string CouponMetaId { get; set; }
}

[Description("根据商家传入的链接类型，返回对应页面的跳转链接（短链），链接可发放于站外触达工具（如：短信&微信），召回用户 1.会员中心页，商家会员中心页，查看用户积分和会员可用权益 2.达人主页，与店铺人店一体绑定的达人账号主页 3.店铺首页，商家抖店店铺的首页 4.商品详情页-需额外传入商品id，进入对应商详 5.订单详情页-需额外传入订单id，用户只可查看自己账号下单的订单详情页 6.优惠券链接-需额外传入优惠券id")]
public class MemberGetShopShortLinkRsp
{
	[JsonPropertyName("short_link")]
	[Description("对应类型的链接")]
	public string ShortLink { get; set; }
}
