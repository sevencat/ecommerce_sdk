namespace ecommerce.sdk.douyin;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class DouyinRetCodeAttribute : Attribute
{
	public DouyinRetCodeAttribute(int code, string msg, string subMsg, string subCode, string solution)
	{
		Code = code;
		Msg = msg;
		SubMsg = subMsg;
		SubCode = subCode;
		Solution = solution;
	}

	public int Code { get; set; }
	public string Msg { get; set; }
	public string SubMsg { get; set; }

	public string SubCode { get; set; }

	public string Solution { get; set; }
}