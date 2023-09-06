namespace ecommerce.sdk.douyin;

[Description("商家入驻提交资料")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","您输入的“公司名称”和“统一社会信用代码”不匹配，请再次核对是否填写正确。","isv.parameter-invalid:63001114","按提示修改")]
[DouyinRetCode(40004,"非法的参数","提交的数据未修改，请修改后再提交","isv.parameter-invalid:63001004","按提示修改")]
[DouyinRetCode(40004,"非法的参数","已入驻成功，请前往资质中心修改","isv.parameter-invalid:63001001","已经入驻完成")]
[DouyinRetCode(40004,"非法的参数","禁售类目[31994 31995 31268 31269 31271 31272 31273 31274 31275 31276 31278 31281 31282 31283 31288 31991 31992 31277 31279 31285 31286 31289 31293 31303 31305 31306 31308 31309 31310 31311 31312 31313 31315 31317 31318 31319 28945 28947 28953 28962 28963 28964 28965 28967 28968 28970 28971 28972 29003 29004 29005 29006 29007 29009 29010 29012 29013 29015 29016 29018 29019 29038 29045 29048 28974 28982 28990 29022 29033 29049 29035 29036 29044]无法提审","isv.parameter-invalid:1000004","删除禁售类目后再提")]
[DouyinRetCode(50002,"业务处理失败","1000001:系统错误，请稍后再试","isv.business-failed:1000001","系统错误，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","63001003:请等待入驻审核完成后继续操作!","isv.business-failed:63001003","请等待入驻审核完成后继续操作!")]
[DouyinRetCode(50002,"业务处理失败","63001115:店铺名称重复，请修改店铺名称","isv.business-failed:63001115","店铺名称重复，请修改店铺名称")]
[DouyinRetCode(50002,"业务处理失败","63001002:操作的太快啦，请稍后重试","isv.business-failed:63001002","操作的太快啦，请稍后重试")]
public class QualificationSettleReq : IDouyinReq<QualificationSettleRsp>
{

	public string GetMethod() { return "qualification.settle"; }

	public string GetUrl() { return "/qualification/settle"; }

	[JsonPropertyName("shop_id")]
	[Description("商家ID")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("v_type")]
	[Description("主体类型。0企业，41个体")]
	[NotNull]
	public int? VType { get; set; }

	[JsonPropertyName("company_name")]
	[Description("公司名称")]
	[NotNull]
	public string CompanyName { get; set; }

	[JsonPropertyName("license_code")]
	[Description("营业执照编号")]
	[NotNull]
	public string LicenseCode { get; set; }

	[JsonPropertyName("business_term")]
	[Description("营业执照期限，L表示长期")]
	[NotNull]
	public string BusinessTerm { get; set; }

	[JsonPropertyName("license_img")]
	[Description("营业执照图片")]
	[NotNull]
	public List<LicenseImgItem> LicenseImg { get; set; }

	public class LicenseImgItem
	{
		[JsonPropertyName("file_id")]
		[Description("加密字段，无需传递")]
		[NotNull]
		public string FileId { get; set; }

		[JsonPropertyName("url")]
		[Description("图片URL")]
		[NotNull]
		public string Url { get; set; }
	}

	[JsonPropertyName("business_address")]
	[Description("经营省市")]
	[NotNull]
	public List<BusinessAddressItem> BusinessAddress { get; set; }

	public class BusinessAddressItem
	{
		[JsonPropertyName("code")]
		[Description("省、市code")]
		[NotNull]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		[Description("省、市名称")]
		[NotNull]
		public string Name { get; set; }
	}

	[JsonPropertyName("identity_type")]
	[Description("法人/经营者证件类型")]
	[NotNull]
	public int? IdentityType { get; set; }

	[JsonPropertyName("identity_num")]
	[Description("法人/经营者身份证编号")]
	[NotNull]
	public string IdentityNum { get; set; }

	[JsonPropertyName("full_name")]
	[Description("法人/经营者姓名")]
	[NotNull]
	public string FullName { get; set; }

	[JsonPropertyName("identity_img")]
	[Description("法人/经营者身份证图片")]
	[NotNull]
	public List<IdentityImgItem> IdentityImg { get; set; }

	public class IdentityImgItem
	{
		[JsonPropertyName("file_id")]
		[Description("加密字段")]
		[NotNull]
		public string FileId { get; set; }

		[JsonPropertyName("url")]
		[Description("图片URL，无需传递")]
		[NotNull]
		public string Url { get; set; }
	}

	[JsonPropertyName("identity_term")]
	[Description("法人/经营者身份证期限，用L表示长期")]
	[NotNull]
	public string IdentityTerm { get; set; }

	[JsonPropertyName("category_ids")]
	[Description("主营类目")]
	[NotNull]
	public List<long> CategoryIds { get; set; }

	[JsonPropertyName("shop_type")]
	[Description("店铺类型")]
	[NotNull]
	public int? ShopType { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	[NotNull]
	public string ShopName { get; set; }

	[JsonPropertyName("shop_logo")]
	[Description("店铺logo")]
	[NotNull]
	public ShopLogoItem ShopLogo { get; set; }

	public class ShopLogoItem
	{
		[JsonPropertyName("file_id")]
		[Description("加密字段，无需使用")]
		[NotNull]
		public string FileId { get; set; }

		[JsonPropertyName("url")]
		[Description("图片URL")]
		[NotNull]
		public string Url { get; set; }
	}

	[JsonPropertyName("shop_base_info")]
	[Description("店铺管理人信息")]
	public ShopBaseInfoItem ShopBaseInfo { get; set; }

	public class ShopBaseInfoItem
	{
		[JsonPropertyName("shop_charge_name")]
		[Description("管理人姓名")]
		[NotNull]
		public string ShopChargeName { get; set; }

		[JsonPropertyName("shop_charge_mobile")]
		[Description("管理人手机号")]
		[NotNull]
		public string ShopChargeMobile { get; set; }
	}

	[JsonPropertyName("contracts")]
	[Description("协议信息")]
	public List<ContractsItem> Contracts { get; set; }

	public class ContractsItem
	{
		[JsonPropertyName("contract_type")]
		[Description("协议ID")]
		[NotNull]
		public long? ContractType { get; set; }
	}
}

[Description("商家入驻提交资料")]
public class QualificationSettleRsp
{
}
