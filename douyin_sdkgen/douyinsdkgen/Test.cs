namespace douyinsdkgen;

public interface IDouyinReturn<T>
{
}

public interface IDouyinReq
{
	string GetMethod();
	string GetUrl();
}

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