using System.Text;

namespace douyinsdkgen;

public static class Ext
{
	public static StringBuilder AddChar(this StringBuilder sb, int num, char c)
	{
		for (var i = 0; i < num; i++)
			sb.Append(c);
		return sb;
	}
}