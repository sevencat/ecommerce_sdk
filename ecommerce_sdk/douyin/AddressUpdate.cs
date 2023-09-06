namespace ecommerce.sdk.douyin;

[Description("该接口支持店铺修改单条售后地址信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","已有对应的记录","isv.parameter-invalid:100002","重新创建")]
[DouyinRetCode(50002,"业务处理失败","信息未修改，提交失败","isv.business-failed:100005","信息未修改，提交失败")]
[DouyinRetCode(20000,"系统错误","操作过于频繁，请稍后重试","isp.service-error:100001","操作过于频繁，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该地址不存在，请刷新后重试","isv.business-failed:5001","请检查地址信息")]
[DouyinRetCode(50002,"业务处理失败","手机号格式有误","isv.business-failed:4000","请检查手机号码")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:6000","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该区号","isv.business-failed:100009","请检查区地址信息")]
[DouyinRetCode(50002,"业务处理失败","地址已删除，请检查地址后重试","isv.business-failed:5004","地址已删除，请检查地址后重试")]
[DouyinRetCode(50002,"业务处理失败","修改地址失败，该地址正用于电子面单订购，请新建地址或取消订购关系后修改","isv.business-failed:5005","修改地址失败，该地址正用于电子面单订购，请新建地址或取消订购关系后修改")]
public class AddressUpdateReq : IDouyinReq<AddressUpdateRsp>
{

	public string GetMethod() { return "address.update"; }

	public string GetUrl() { return "/address/update"; }

	[JsonPropertyName("address")]
	[Description("地址信息")]
	[NotNull]
	public AddressItem Address { get; set; }

	public class AddressItem
	{
		[JsonPropertyName("id")]
		[Description("地址ID")]
		[NotNull]
		public long? Id { get; set; }

		[JsonPropertyName("user_name")]
		[Description("联系人姓名")]
		[NotNull]
		public string UserName { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号码")]
		public string Mobile { get; set; }

		[JsonPropertyName("province_id")]
		[Description("省ID")]
		[NotNull]
		public long? ProvinceId { get; set; }

		[JsonPropertyName("city_id")]
		[Description("城市ID")]
		[NotNull]
		public long? CityId { get; set; }

		[JsonPropertyName("town_id")]
		[Description("区ID")]
		[NotNull]
		public long? TownId { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		[NotNull]
		public string Detail { get; set; }

		[JsonPropertyName("street_id")]
		[Description("街道ID")]
		[NotNull]
		public long? StreetId { get; set; }

		[JsonPropertyName("link_type")]
		[Description("联系方式类型(0-手机,1-普通座机,2-企业座机)")]
		[NotNull]
		public int? LinkType { get; set; }

		[JsonPropertyName("fixed_phone")]
		[Description("普通座机格式：区号-座机号-分机号(分机号选填)、区号3~4位、座机号7~8位、分机号不超过5位。企业座机：400/800开头不超过10位、95开头在5~8we")]
		public string FixedPhone { get; set; }

		[JsonPropertyName("remark")]
		[Description("售后备注，限制200个字符")]
		public string Remark { get; set; }
	}

	[JsonPropertyName("store_id")]
	[Description("门店场景需要传门店ID，其他场景默认值0即可")]
	public long? StoreId { get; set; }
}

[Description("该接口支持店铺修改单条售后地址信息")]
public class AddressUpdateRsp
{
}
