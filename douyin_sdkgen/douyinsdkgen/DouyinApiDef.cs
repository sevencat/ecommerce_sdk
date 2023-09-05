namespace douyinsdkgen;

public class DouyinApiDef
{
	/// <summary>
	/// 
	/// </summary>
	public Request request { get; set; }

	/// <summary>
	/// 
	/// </summary>
	public Response response { get; set; }

	/// <summary>
	/// 
	/// </summary>
	public Error error { get; set; }

	public class BaseParamItem
	{
		/// <summary>
		/// 
		/// </summary>
		public int type { get; set; }

		public int subType { get; set; }

		public int mapKeyType { get; set; }
		public int mapValueType { get; set; }


		/// <summary>
		/// 
		/// </summary>
		public string example { get; set; }

		/// <summary>
		/// 仓库信息
		/// </summary>
		public string description { get; set; }
	}

	public class RequestParamItem : BaseParamItem
	{
		/// <summary>
		/// 
		/// </summary>
		public string requestName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string toName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool mustNeed { get; set; }


		/// <summary>
		/// 
		/// </summary>
		public int style { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int cipherTextType { get; set; }

		public List<RequestParamItem> children { get; set; }
	}

	public class Request
	{
		/// <summary>
		/// 
		/// </summary>
		public List<RequestParamItem> requestParam { get; set; }
	}


	public class ResponseDataItem : BaseParamItem
	{
		/// <summary>
		/// 
		/// </summary>
		public string responseName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string fromName { get; set; }


		/// <summary>
		/// 
		/// </summary>
		public string encryptType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string securityLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public List<ResponseDataItem> children { get; set; }
	}

	public class Response
	{
		/// <summary>
		/// 
		/// </summary>
		public List<ResponseDataItem> responseData { get; set; }
	}

	public class ErrCodeListItem
	{
		public int code { get; set; }
		public string msg { get; set; }
		public string subMsg { get; set; }

		public string subCode { get; set; }

		public string solution { get; set; }
	}

	public class Error
	{
		/// <summary>
		/// 
		/// </summary>
		public List<ErrCodeListItem> errCodeList { get; set; }
	}
}