namespace ecommerce.sdk.douyin;

[Description("创建店铺地址库")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","已达到50条新建地址上限","isv.parameter-invalid:100003","删除多余")]
[DouyinRetCode(40004,"非法的参数","已有对应的记录","isv.parameter-invalid:100002","重新创建")]
[DouyinRetCode(40004,"非法的参数","系统繁忙，请稍后重试","isv.parameter-invalid:6000","系统繁忙，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","联系人不能超过32字","isv.parameter-invalid:4000","请修改联系人信息")]
[DouyinRetCode(50002,"业务处理失败","操作过于频繁，请稍后重试","isv.business-failed:100001","操作过于频繁，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该区号","isv.business-failed:100009","暂不支持该区号")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:5001","系统繁忙，请稍后重试")]
public class AddressCreateReq : IDouyinReq<AddressCreateRsp>
{

	public string GetMethod() { return "address.create"; }

	public string GetUrl() { return "/address/create"; }

	[JsonPropertyName("address")]
	[Description("地址信息")]
	[NotNull]
	public AddressItem Address { get; set; }

	public class AddressItem
	{
		[JsonPropertyName("user_name")]
		[Description("联系人姓名")]
		[NotNull]
		public string UserName { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号码")]
		public string Mobile { get; set; }

		[JsonPropertyName("province_id")]
		[Description("省份ID")]
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
		[Description("售后备注，限制200字符")]
		public string Remark { get; set; }
	}

	[JsonPropertyName("store_id")]
	[Description("门店ID（新建地址绑定在该门店下，非门店场景无需填写）")]
	public long? StoreId { get; set; }
}

[Description("创建店铺地址库")]
public class AddressCreateRsp
{
	[JsonPropertyName("address_id")]
	[Description("新建地址ID")]
	public long AddressId { get; set; }
}
