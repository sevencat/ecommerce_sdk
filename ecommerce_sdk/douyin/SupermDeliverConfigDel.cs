namespace ecommerce.sdk.douyin;

[Description("时效管理删除")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
public class SupermDeliverConfigDelReq : IDouyinReq<SupermDeliverConfigDelRsp>
{

	public string GetMethod() { return "superm.deliverConfig.del"; }

	public string GetUrl() { return "/superm/deliverConfig/del"; }

	[JsonPropertyName("config_ids")]
	[Description("配置id列表")]
	[NotNull]
	public List<long> ConfigIds { get; set; }
}

[Description("时效管理删除")]
public class SupermDeliverConfigDelRsp
{
}
