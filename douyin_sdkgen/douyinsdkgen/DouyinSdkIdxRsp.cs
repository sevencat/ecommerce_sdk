namespace douyinsdkgen;

public class DouyinSdkIdxRsp 
{

	public int code { get; set; }
	public string message { get; set; }

	public Data data { get; set; }

	public class Data
	{
		public List<DirItem> dirs { get; set; }
	}

	public class DirItem
	{
		public int id { get; set; }
		public string name { get; set; }
		public List<ApiItem> articles { get; set; }
	}

	public class ApiItem
	{
		public int id { get; set; }

		public string title { get; set; }

		public string subtitle { get; set; }

		public int dirId { get; set; }
		public string dirName { get; set; }

		public int status { get; set; }

		public long createTime { get; set; }
		public long updateTime { get; set; }
		public string version { get; set; }
		public string userSceneDesc { get; set; }
		public string description { get; set; }
		public string url { get; set; }
		public int apiChargeType { get; set; }
	}
}