namespace ecommerce.sdk.douyin;

[Description("绑定单个地址到区域仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2:参数错误:110000-110101-0-0地址格式错误","isv.business-failed:2","请检查地址格式")]
[DouyinRetCode(50002,"业务处理失败","20002:仓库不存在","isv.business-failed:20002","请检查仓库id信息")]
public class WarehouseSetAddrReq : IDouyinReq<WarehouseSetAddrRsp>
{

	public string GetMethod() { return "warehouse.setAddr"; }

	public string GetUrl() { return "/warehouse/setAddr"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库ID")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("addr")]
	[Description("仓库地址")]
	[NotNull]
	public AddrItem Addr { get; set; }

	public class AddrItem
	{
		[JsonPropertyName("addr_id1")]
		[Description("一级地址")]
		[NotNull]
		public long? AddrId1 { get; set; }

		[JsonPropertyName("addr_id2")]
		[Description("二级地址")]
		public long? AddrId2 { get; set; }

		[JsonPropertyName("addr_id3")]
		[Description("三级地址")]
		public long? AddrId3 { get; set; }

		[JsonPropertyName("addr_id4")]
		[Description("四级地址")]
		public long? AddrId4 { get; set; }
	}
}

[Description("绑定单个地址到区域仓")]
public class WarehouseSetAddrRsp
{
}
