using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace douyinsdkgen;

[Table("sdk_douyinitem")]
[Index("snap")]
public class DouyinSdkItem
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int id { get; set; }

	public string title { get; set; }

	public string subtitle { get; set; }

	public int dirId { get; set; }

	public int status { get; set; }

	public long createTime { get; set; }
	public long updateTime { get; set; }
	public string version { get; set; }
	public string userSceneDesc { get; set; }
	public string description { get; set; }
	public string url { get; set; }
	public int apiChargeType { get; set; }

	public int snap { get; set; }
	public string ctx { get; set; }
}