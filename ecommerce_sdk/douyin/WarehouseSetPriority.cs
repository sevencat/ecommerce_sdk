namespace ecommerce.sdk.douyin;

[Description("设置指定地址下的仓的优先级")]
public class WarehouseSetPriorityReq : IDouyinReq<WarehouseSetPriorityRsp>
{

	public string GetMethod() { return "warehouse.setPriority"; }

	public string GetUrl() { return "/warehouse/setPriority"; }

	[JsonPropertyName("addr")]
	[Description("配送地址")]
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

	[JsonPropertyName("priorities")]
	[Description("前面是out_warehouse_id，后面是仓优先级 仓优先级，0-5，0优先级最高，5最低")]
	[NotNull]
	public Dictionary<string,long> Priorities { get; set; }
}

[Description("设置指定地址下的仓的优先级")]
public class WarehouseSetPriorityRsp
{
}
