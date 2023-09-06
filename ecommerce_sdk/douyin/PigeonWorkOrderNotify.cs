namespace ecommerce.sdk.douyin;

[Description("飞鸽工单开放模块")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数非法","isv.parameter-invalid:2008","请检查参数")]
[DouyinRetCode(40002,"缺少必选参数","缺少必要的业务参数","isv.missing-parameter:9002","请检查入参")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:9001","请重试")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:2006","请重试")]
[DouyinRetCode(40004,"非法的参数","参数过期","isv.parameter-invalid:2007","请重试")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:9003","请检查参数信息后重试")]
[DouyinRetCode(50002,"业务处理失败","关联单查询失败","isv.business-failed:2013","请重试")]
[DouyinRetCode(50002,"业务处理失败","工单卡片发送失败","isv.business-failed:2016","请检查参数信息后重试")]
[DouyinRetCode(50002,"业务处理失败","工单已存在","isv.business-failed:2018","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","工单不存在","isv.business-failed:2005","请检查参数")]
public class PigeonWorkOrderNotifyReq : IDouyinReq<PigeonWorkOrderNotifyRsp>
{

	public string GetMethod() { return "pigeon.workOrderNotify"; }

	public string GetUrl() { return "/pigeon/workOrderNotify"; }

	[JsonPropertyName("creator_id")]
	[Description("工单创建人ID")]
	[NotNull]
	public string CreatorId { get; set; }

	[JsonPropertyName("work_order_id")]
	[Description("工单唯一标识id")]
	[NotNull]
	public string WorkOrderId { get; set; }

	[JsonPropertyName("open_user_id")]
	[Description("抖店用户ID")]
	[NotNull]
	public string OpenUserId { get; set; }

	[JsonPropertyName("relation_id_type")]
	[Description("工单关联id类型，1店铺订单 2商品订单 3售后单 4商品")]
	[NotNull]
	public long? RelationIdType { get; set; }

	[JsonPropertyName("relation_id")]
	[Description("关联单Id，如1 店铺订单ID，2 商品订单ID，3 售后单ID，4 商品ID")]
	[NotNull]
	public string RelationId { get; set; }

	[JsonPropertyName("work_order_type_desc")]
	[Description("工单状态描述")]
	[NotNull]
	public string WorkOrderTypeDesc { get; set; }

	[JsonPropertyName("work_order_status")]
	[Description("工单状态  10 待处理/ 20 处理中/30 已完结/40 已失效（已删除，飞鸽内不展示）")]
	[NotNull]
	public long? WorkOrderStatus { get; set; }

	[JsonPropertyName("title")]
	[Description("工单标题")]
	[NotNull]
	public string Title { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型  1 创建事件  2 更新事件")]
	[NotNull]
	public long? EventType { get; set; }

	[JsonPropertyName("creator_id_type")]
	[Description("工单创建人 账号体系 1 飞鸽账号体系 2 ISV账号体系，若为飞鸽体系，则creator_id传递飞鸽体系的身份ID，如OpenId,若为ISV账号，则需要和飞鸽协商后确定")]
	[NotNull]
	public long? CreatorIdType { get; set; }

	[JsonPropertyName("event_time")]
	[Description("事件发生时间（单位：秒)")]
	[NotNull]
	public long? EventTime { get; set; }

	[JsonPropertyName("scene")]
	[Description("工单场景 0其他 1补发 2换货")]
	public long? Scene { get; set; }

	[JsonPropertyName("trigger_action")]
	[Description("触发操作：0无操作 1发卡片")]
	public long? TriggerAction { get; set; }

	[JsonPropertyName("extra_info")]
	[Description("扩展数据")]
	public string ExtraInfo { get; set; }
}

[Description("飞鸽工单开放模块")]
public class PigeonWorkOrderNotifyRsp
{
}
