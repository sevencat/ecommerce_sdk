namespace ecommerce.sdk.douyin;

[Description("地址与区域仓解绑")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误:地址格式错误","isv.parameter-invalid:2","请检查地址格式")]
[DouyinRetCode(50002,"业务处理失败","单次请求过于频繁，请稍后重试","isv.business-failed:1005","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","仓库不存在","isv.business-failed:20002","请检查确认仓库信息")]
public class WarehouseRemoveAddrReq : IDouyinReq<WarehouseRemoveAddrRsp>
{

	public string GetMethod() { return "warehouse.removeAddr"; }

	public string GetUrl() { return "/warehouse/removeAddr"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库ID")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("addr")]
	[Description("删除的地址结构体")]
	[NotNull]
	public AddrItem Addr { get; set; }

	public class AddrItem
	{
		[JsonPropertyName("addr_id1")]
		[Description("一级地址id")]
		[NotNull]
		public long? AddrId1 { get; set; }

		[JsonPropertyName("addr_id2")]
		[Description("二级地址id")]
		public long? AddrId2 { get; set; }

		[JsonPropertyName("addr_id3")]
		[Description("三级地址id")]
		public long? AddrId3 { get; set; }

		[JsonPropertyName("addr_id4")]
		[Description("四级地址id")]
		public long? AddrId4 { get; set; }
	}
}

[Description("地址与区域仓解绑")]
public class WarehouseRemoveAddrRsp
{
}
