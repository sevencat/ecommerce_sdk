namespace ecommerce.sdk.douyin;

[Description("暂时只支持整单出库，即接口调用时入参只能传父订单号。,Tips：部分发货状态下的父订单，调此接口发货，会报错：该订单当前为“部分发货”状态，无法调用此接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常，请联系相关人员处理。","isp.service-error:9999","ISV开发者可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId;")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试。","isp.service-error:10005","1、商家重新点击发货按钮重试；2、如果多次重试不能解决问题，可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId。")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试。","isp.service-error:10009","1、商家重新点击发货按钮重试；2、如果多次重试不能解决问题，可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId。")]
[DouyinRetCode(20000,"系统错误","校验物流信息失败，请稍后重试","isp.service-error:10018","1、商家重新点击发货按钮重试；2、如果多次重试不能解决问题，可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId。")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试。","isp.service-error:20003","1、商家重新点击发货按钮重试；2、如果多次重试不能解决问题，可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId。")]
[DouyinRetCode(20000,"系统错误","系统异常，请联系相关人员解决。","isp.service-error:50002","ISV开发者可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一: 订单号或者请求的LogId;")]
[DouyinRetCode(40004,"非法的参数","店铺ID非法，不允许小于等于0。","isv.parameter-invalid:50029","ISV接入方式错误，调整输入的店铺ID参数，重试")]
[DouyinRetCode(40004,"非法的参数","订单号不能为空或者格式错误。","isv.parameter-invalid:50049","ISV调整输入的订单ID参数，重试")]
[DouyinRetCode(40002,"缺少必选参数","物流公司编码不允许为空。","isv.missing-parameter:60011","1、ISV自查接入的参数是否为空；2、如果不能解决问题，可以联系抖店相关运营或开发人员进行排查和解决，需要提供以下基本信息之一:   订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","物流单号不符合规则。","isv.business-failed:60017","1、商家仔细检查物流单号格式是否正确、和物流公司是否匹配，修改后重新操作；2、如果商家确定无误，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一: 订单号或者LogId。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该物流公司或物流商已失效，请检查。","isv.business-failed:60018","1、商家自行检查使用的物流公司编码是否符合平台规则；2、如果商家确定无误，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一: 订单号或者LogId。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持本类订单发货。","isv.business-failed:60111","1、ISV自查拉单、用户对订单的筛选是否符合要求；2、- 如果无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者LogId。")]
[DouyinRetCode(50002,"业务处理失败","订单已取消，禁止发货。","isv.business-failed:60021","1、ISV开发者先自行排查系统对接是否有问题；2、商家需要立即检查该订单是否已经实际线下寄出包裹，如果已经寄出，需要对物流商下达拦截操作；3、商家能否调整发货的流程，先在系统推进订单到已发货状态后再实际操作发货；4、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一: 订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","该订单为货到付款订单，不允许发货。","isv.business-failed:60022","1、线上已经取消货到付款的支付方式，因此该错误码代表抖店内部系统异常，直接联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","该订单不可自行操作发货，请联系跨境服务商进行操作。","isv.business-failed:60024","商家对返回该错误类型的订单，需要联系跨境服务商操作发货，商家无发货权限。")]
[DouyinRetCode(50002,"业务处理失败","该订单不支持使用其它物流进行发货。","isv.business-failed:60026","1、商家换用正常的物流商进行发货；2、商家可以联系平台运营，对使用其他物流添加白名单。")]
[DouyinRetCode(50002,"业务处理失败","该店铺无默认售后地址，请前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后再操作发货。","isv.business-failed:60027","商家前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置默认售后地址后再操作发货。")]
[DouyinRetCode(40004,"非法的参数","发货地址ID不允许小于0。","isv.parameter-invalid:60028","1、ISV自查接入的地址参数是否小于0；2、- 如果无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(40002,"缺少必选参数","发货订单数最多支持400单，请重新选择。","isv.missing-parameter:60032","- 引导商家减少选中的订单数量，重试。")]
[DouyinRetCode(50002,"业务处理失败","订单不存在，请仔细检查后重试。","isv.business-failed:60033","1、ISV和商家仔细检查对应的订单号是否存在，是否是本店铺的订单；2、如果无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(40002,"缺少必选参数","发货信息为空。","isv.missing-parameter:60036","需要ISV仔细确认要发货的订单信息后，重试。")]
[DouyinRetCode(50002,"业务处理失败","发货订单中有退款申请需要处理，请先处理。","isv.business-failed:60040","商家需要对返回该错误的订单检查售后信息，可以进行如下操作: 1、拒绝售前申请后重新发货；2、  - 发货选项中传递发货优先，可以优先拒绝售后；3、商家同意售前申请退款，取消对该订单的发货操作。")]
[DouyinRetCode(40004,"非法的参数","序列号长度不能超过30位字符。","isv.parameter-invalid:60046","商家检查序列号是否符合正确，修改后重试。")]
[DouyinRetCode(50002,"业务处理失败","该订单补贴商品的序列号已经上传，请重新填写。","isv.business-failed:60047","商家更换新的序列号，重试。")]
[DouyinRetCode(50002,"业务处理失败","上传序列号失败，请重试。","isv.business-failed:60051","ISV重试，如果多次重试仍无法解决问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持本类订单发货。","isv.business-failed:60057","1、ISV自查拉单、用户对订单的筛选是否符合要求；2、如果无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(40004,"非法的参数","手机序列号仅支持填写15～17位数字。","isv.parameter-invalid:60062","商家仔细检查自己填写的手机序列号长度是否在15~17位之间。")]
[DouyinRetCode(50002,"业务处理失败","该发货方式不支持质检类订单发货。","isv.business-failed:60069","商家需要到商家后台质检类订单发货操作栏操作发货。")]
[DouyinRetCode(50002,"业务处理失败","当前发货异常，请检查发货地址。","isv.business-failed:60070","商家修改手动输入的发货地址后重试。")]
[DouyinRetCode(50002,"业务处理失败","当前发货地址存在异常，请前往抖店PC端「订单-发货管理-物流工具-地址库管理」修改后重试。","isv.business-failed:60071","商家前往抖店PC端「订单-发货管理-物流工具-地址库管理」修改后之后，重试。")]
[DouyinRetCode(50002,"业务处理失败","该店铺无默认发货地址，请前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后再操作发货。","isv.business-failed:60072","商家前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置默认发货地址后再操作发货。")]
[DouyinRetCode(50002,"业务处理失败","非本店铺订单，操作失败。","isv.business-failed:60101","商家需要仔细检查对应的订单是否属于当前店铺，确认之后进行重试。")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试。","isp.service-error:60106","1、商家多重试几次；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该类型订单发货。","isv.business-failed:60107","虚拟、教育等类型订单不支持发货。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该类型订单发货。","isv.business-failed:60108","该发货方式不支持回收、寄卖、仅收款类订单发货。")]
[DouyinRetCode(50002,"业务处理失败","订单正在风控审核中，风控审核时效1~2小时，请等待订单变为“备货中”状态后重试。","isv.business-failed:60109","1、ISV开发者先自行排查系统对接是否有问题；2、商家需要立即检查该订单是否已经实际线下寄出包裹，如果已经寄出，需要对物流商下达拦截操作；3、商家能否调整发货的流程，先在系统推进订单到已发货状态后再实际操作发货；4、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","订单已发货，不允许再次执行发货。","isv.business-failed:60110","取消对该订单的发货。")]
[DouyinRetCode(50002,"业务处理失败","订单已完结，禁止发货。","isv.business-failed:60113","取消对该订单的发货。")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试。","isv.business-failed:60114","1、联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","不支持平台仓订单发货。","isv.business-failed:60116","商家取消对该订单的发货。")]
[DouyinRetCode(50002,"业务处理失败","订单售后信息异常，请稍后重试。","isv.business-failed:60118","1、商家重试；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","该订单已售前退款成功，不能发货。","isv.business-failed:60068","1、商家需要立即检查该订单是否已经实际线下寄出包裹，如果已经寄出，需要对物流商下达拦截操作；2、商家能否调整发货的流程，先在系统推进订单到已发货状态后再实际操作发货。")]
[DouyinRetCode(50002,"业务处理失败","订单正在售后中，请确认后发货。","isv.business-failed:60120","1、商家需要立即检查该订单是否已经实际线下寄出包裹，如果已经寄出，需要对物流商下达拦截操作；2、商家能否调整发货的流程，先在系统推进订单到已发货状态后再实际操作发货。")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试。","isv.business-failed:60121","1、商家重试；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(50002,"业务处理失败","该跨境订单状态暂不允许发货。","isv.business-failed:60122","服务商没有对跨境订单回传信息，商家无法对跨境订单发货。")]
[DouyinRetCode(50002,"业务处理失败","当前订单为供应链订单，商家无权自发货。","isv.business-failed:60123","商家对供应链订单操作发货，供应链订单只能通过供应链链路发货。")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试。","isp.service-error:60124","查询根据该物流单号猜想的物流公司错误，商家重试。")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:60125","1、校验其他物流订单数据异常，商家重试；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(50002,"业务处理失败","暂不支持使用寻梦同城物流发货，请重新选择物流公司或联系平台客服申请使用。","isv.business-failed:60126","商家使用“寻梦同城”物流操作发货，但是商家并不在“寻梦同城”物流的白名单内，解决方案如下: 1、商家换用正常的物流商发货；2、商家联系平台客服申请使用“寻梦同城”物流商。")]
[DouyinRetCode(50002,"业务处理失败","物流单号校验不通过，请仔细检查后重试。","isv.business-failed:60127","1、仔细检查对应的物流单号是否正确，修改后重试；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","物流公司与系统智能检测不一致。物流公司可能为:(具体根据猜想得到的物流公司名称)，若确认无误可继续发货。","isv.business-failed:60128","1、商家仔细检查对应的物流单号、物流公司是否正确，修改后重试；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","发货订单包含状态为“待用户填写定制信息”的定制商品订单，此类订单需用户填写定制信息后才能发货。","isv.business-failed:60131","商家对定制商品订单发货，但是C端该定制订单并没有填写定制信息，需要联系消费者填写定制信息后才能够发货。")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试。","isp.service-error:60132","1、商家重试；2、联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(50002,"业务处理失败","订单未支付，禁止发货。","isv.business-failed:60137","1、仔细检查订单状态；2、ISV需要重新拉取订单信息，确保和抖店系统的数据保持一致；3、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求的LogId。")]
[DouyinRetCode(20000,"系统错误","拒绝售后失败，请检查该单的售后处理流程后重试。","isp.service-error:70005","1、商家根据返回的错误文案检查订单是否存在售后流程，处理售后单；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(20000,"系统错误","发货失败，请稍后重试。","isp.service-error:70011","1、商家根据返回的错误文案检查订单检查订单并进行相应处理；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试。","isv.business-failed:70016","1、如果商家直接输入的发货地址，需要商家仔细检查自己的输入地址是否正确、是否符合平台要求；2、如果商家使用平台地址库管理的地址，需要检查下地址库是否存在该地址、地址库对该地址是否提示存在异常。")]
[DouyinRetCode(20000,"系统错误","系统错误，请稍后重试或者联系客服人员解决。","isp.service-error:80007","1、可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(20000,"系统错误","网络超时，请重试。","isp.service-error:99997","重试。")]
[DouyinRetCode(20000,"系统错误","请输入正确的参数，仔细检查输入参数是否为空或联系抖店人员排查。","isp.service-error:99998","1、ISV自查接入的参数是否为空；2、如果无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(20000,"系统错误","未知异常，请联系客服人员处理。","isp.service-error:99999","系统发生BUG，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:70009","商家重试即可。")]
[DouyinRetCode(50002,"业务处理失败","补贴商品发货时需要上传商品序列号","isv.business-failed:60056","商家对于报错的订单上传序列号。")]
[DouyinRetCode(50002,"业务处理失败","该发货地址在商家地址库不存在，请刷新或者前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后重试","isv.business-failed:60134","该发货地址在商家地址库不存在，商家重新选择可用的发货地址或者前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后重试")]
[DouyinRetCode(50002,"业务处理失败","拒绝售后失败，请检查该单的售后处理流程后重试。","isv.business-failed:10032","1、商家根据返回的错误文案检查订单是否存在售后流程，处理售后单；2、如果商家无法解决相关问题，可以联系抖店相关运营-开发人员进行排查和解决，需要提供以下基本信息之一:订单号或者请求LogId。")]
[DouyinRetCode(50002,"业务处理失败","70023:没有能发货的订单，请修改后重试","isv.business-failed:70023","请检查订单物流状态")]
[DouyinRetCode(50002,"业务处理失败","70020:物流单号收件人电话及地址与该订单买家电话及地址均不一致，请核实后更新单号","isv.business-failed:70020","请检查订单买家电话及地址均不一致")]
[DouyinRetCode(50002,"业务处理失败","70022:物流单号已被其他订单使用，且收货人手机号/收货地址不一致，请核实后更新单号","isv.business-failed:70022","请检查物流单号")]
[DouyinRetCode(50002,"业务处理失败","70018:物流单号已被快递回收或取消，无法继续使用，请核实后更新单号","isv.business-failed:70018","请检查物流单号")]
[DouyinRetCode(50002,"业务处理失败","70019:物流单号首条轨迹产生时间早于订单支付时间，请核实后更新单号","isv.business-failed:70019","请检查物流单号")]
[DouyinRetCode(50002,"业务处理失败","120032:售后请求并发，请稍后重试","isv.business-failed:120032","请重试")]
[DouyinRetCode(50002,"业务处理失败","700004:store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:700004","请检查store_id是否正确")]
[DouyinRetCode(50002,"业务处理失败","60138:订单需送货上门，请使用支持送货上门的物流公司发货","isv.business-failed:60138","请检查订单号")]
[DouyinRetCode(50002,"业务处理失败","700003:store_id为空/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:700003","请检查store_id是否正确")]
[DouyinRetCode(50002,"业务处理失败","700002:发货订单包含非本门店订单，请重试","isv.business-failed:700002","请检查订单号")]
[DouyinRetCode(50002,"业务处理失败","700005:小时购订单不支持该快递公司发货","isv.business-failed:700005","请检查物流公司是否存在")]
[DouyinRetCode(50002,"业务处理失败","请传入退货地址，提高退换货的履约准确率","isv.business-failed:700029","请传入退货地址，提高退换货的履约准确率")]
[DouyinRetCode(50002,"业务处理失败","700042:物流服务商信息异常，请传入正确的物流服务商信息或稍后重试","isv.business-failed:700042","请检查服务商")]
[DouyinRetCode(50002,"业务处理失败","120018:系统繁忙，请稍后重试","isv.business-failed:120018","请重试")]
public class OrderLogisticsAddReq : IDouyinReq<OrderLogisticsAddRsp>
{

	public string GetMethod() { return "order.logisticsAdd"; }

	public string GetUrl() { return "/order/logisticsAdd"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("logistics_id")]
	[Description("【已废弃】物流公司ID。请使用company_code字段。")]
	public long? LogisticsId { get; set; }

	[JsonPropertyName("company")]
	[Description("物流公司名称")]
	public string Company { get; set; }

	[JsonPropertyName("company_code")]
	[Description("(必填)物流公司code,可从/order/logisticsCompanyList接口获取。")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("(必填)快递单号")]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("is_refund_reject")]
	[Description("是否拒绝退款申请（true表示拒绝退款，并继续发货；不传或为false表示有退款需要处理，拒绝发货），is_refund_reject和is_reject_refund随机使用一个即可")]
	public bool? IsRefundReject { get; set; }

	[JsonPropertyName("is_reject_refund")]
	[Description("是否拒绝退款申请（true表示拒绝退款，并继续发货；不传或为false表示有退款需要处理，拒绝发货），is_refund_reject和is_reject_refund随机使用一个即可")]
	public bool? IsRejectRefund { get; set; }

	[JsonPropertyName("serial_number_list")]
	[Description("商品序列号，15-17位数字")]
	public List<string> SerialNumberList { get; set; }

	[JsonPropertyName("address_id")]
	[Description("发货地址ID,通过地址库列表【/address/list】接口查询")]
	public long? AddressId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID；抖超小时达店铺需要填写；")]
	public long? StoreId { get; set; }

	[JsonPropertyName("after_sale_address_id")]
	[Description("退货地址ID,通过地址库列表【/address/list】接口查询。当传入该字段时，可实现自动审核场景买家退货至商家指定退货地址：例如商家配置的售后小助手以及平台闪电退货规则，会获取发货时传入的after_sale_address_id地址id对应的地址给买家展示进行商品退回；")]
	public long? AfterSaleAddressId { get; set; }
}

[Description("暂时只支持整单出库，即接口调用时入参只能传父订单号。,Tips：部分发货状态下的父订单，调此接口发货，会报错：该订单当前为“部分发货”状态，无法调用此接口")]
public class OrderLogisticsAddRsp
{
}
