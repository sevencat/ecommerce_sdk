using System.Text;
using System.Text.Json;

namespace douyinsdkgen;

public class DouyinGenApi
{
	public void Gen(TDouyinSdkItem item, string ns, StringBuilder sb)
	{
		var api = JsonSerializer.Deserialize<DouyinApiDef>(item.ctx);
		//namespace douyinsdkgen;
		sb.AppendFormat($"namespace {ns};\r\n\r\n");
		Gen(item, api, sb, 0);
	}

	//1-long 2-string  ,3 list 4-bool 5-struct 8-map 
	public void Gen(TDouyinSdkItem item, DouyinApiDef api, StringBuilder sb, int tabnum)
	{
		var baseclsName = ToCamelCase(item.title);
		if (!String.IsNullOrWhiteSpace(item.description))
			sb.AddChar(tabnum, '\t').Append($"[Description(\"{TrimDesc(item.description)}\")]\r\n");
		if (api.error is { errCodeList: not null })
		{
			foreach (var e in api.error.errCodeList)
			{
				//[DouyinRetCode(200,"","","","")]
				sb.AddChar(tabnum, '\t')
					.Append(
						$"[DouyinRetCode({e.code},\"{TrimDesc(e.msg)}\",\"{TrimDesc(e.subMsg)}\",\"{TrimDesc(e.subCode)}\",\"{TrimDesc(e.solution)}\")]\r\n");
			}
		}

		sb.AddChar(tabnum, '\t').Append($"public class {baseclsName}Req : IDouyinReq<{baseclsName}Rsp>")
			.AppendLine();
		sb.AddChar(tabnum, '\t').AppendLine("{");

		var m = item.title.Replace('/', '.').TrimStart('.');
		sb.AppendLine();
		sb.AddChar(tabnum + 1, '\t').Append($"public string GetMethod() {{ return \"{m}\"; }}\r\n");
		sb.AppendLine();
		sb.AddChar(tabnum + 1, '\t').Append($"public string GetUrl() {{ return \"{item.title}\"; }}\r\n");
		sb.AppendLine();
		if (api.request is { requestParam: not null })
		{
			for (var i = 0; i < api.request.requestParam.Count; i++)
			{
				var rpi = api.request.requestParam[i];
				Gen(rpi, sb, tabnum + 1,baseclsName);
				if (i != api.request.requestParam.Count - 1)
					sb.AppendLine();
			}
		}


		sb.AddChar(tabnum, '\t').AppendLine("}");

		sb.AppendLine();

		if (!String.IsNullOrWhiteSpace(item.description))
			sb.AddChar(tabnum, '\t').Append($"[Description(\"{TrimDesc(item.description)}\")]\r\n");
		sb.AddChar(tabnum, '\t').Append($"public class {baseclsName}Rsp").AppendLine();
		sb.AddChar(tabnum, '\t').AppendLine("{");
		if (api.response is { responseData: not null })
		{
			for (var i = 0; i < api.response.responseData.Count; i++)
			{
				var rpi = api.response.responseData[i];
				Gen(rpi, sb, tabnum + 1,baseclsName);
				if (i != api.response.responseData.Count - 1)
					sb.AppendLine();
			}
		}

		sb.AddChar(tabnum, '\t').AppendLine("}");
	}

	public string GetTypeStr(int t, bool nullable)
	{
		string postfix = nullable ? "?" : "";
		switch (t)
		{
			case 0:
				return "object";
			case 3:
				return "object";
			case 1:
				return "long" + postfix;
			case 2:
				return "string";
			case 4:
				return "bool" + postfix;
			case 6:
				return "short" + postfix;
			case 7:
				return "int" + postfix;
			case 9:
				return "decimal" + postfix;
			default:
				Console.WriteLine("unknown GetTypeStr:" + t);
				break;
		}

		return "unknown " + t;
	}

	public string GetMapTypeStr(DouyinApiDef.BaseParamItem rpi, string ppname)
	{
		if (rpi.mapValueType != 5)
		{
			var ks = GetTypeStr(rpi.mapKeyType, false);
			var vs = GetTypeStr(rpi.mapValueType, false);
			return $"Dictionary<{ks},{vs}>";
		}
		else
		{
			var ks = GetTypeStr(rpi.mapKeyType, false);
			return $"Dictionary<{ks},{ppname}Item>";
		}
	}

	public string GetListTypeStr(DouyinApiDef.BaseParamItem rpi, string ppname)
	{
		if (rpi.subType == 5)
		{
			return $"List<{ppname}Item>";
		}

		var ks = GetTypeStr(rpi.subType, false);
		return $"List<{ks}>";
	}

	public void GenClass(DouyinApiDef.RequestParamItem prpi, string ppname, StringBuilder sb, int tabnum)
	{
		sb.AddChar(tabnum, '\t').AppendFormat($"public class {ppname}Item").AppendLine();
		sb.AddChar(tabnum, '\t').AppendLine("{");
		for (var i = 0; i < prpi.children.Count; i++)
		{
			var rpi = prpi.children[i];
			Gen(rpi, sb, tabnum + 1,ppname);
			if (i != prpi.children.Count - 1)
				sb.AppendLine();
		}

		sb.AddChar(tabnum, '\t').AppendLine("}");
	}

	public void Gen(DouyinApiDef.RequestParamItem rpi, StringBuilder sb, int tabnum,string parppname)
	{
		var ppname = ToCamelCase(rpi.requestName);
		if (ppname == parppname)
			ppname = ppname + "I";
		if (ppname != rpi.requestName)
			sb.AddChar(tabnum, '\t').Append($"[JsonPropertyName(\"{rpi.requestName}\")]\r\n");
		if (!String.IsNullOrWhiteSpace(rpi.description))
			sb.AddChar(tabnum, '\t').Append($"[Description(\"{TrimDesc(rpi.description)}\")]\r\n");
		if (rpi.mustNeed)
			sb.AddChar(tabnum, '\t').Append($"[NotNull]\r\n");
		switch (rpi.type)
		{
			case 0:
				sb.AddChar(tabnum, '\t').Append($"public object {ppname} {{ get; set; }}\r\n");
				break;
			case 1:
				sb.AddChar(tabnum, '\t').Append($"public long? {ppname} {{ get; set; }}\r\n");
				break;
			case 2:
				sb.AddChar(tabnum, '\t').Append($"public string {ppname} {{ get; set; }}\r\n");
				break;
			case 3:
				var ld = GetListTypeStr(rpi, ppname);
				sb.AddChar(tabnum, '\t').Append($"public {ld} {ppname} {{ get; set; }}\r\n");
				if (rpi.subType == 5)
				{
					sb.AppendLine();
					GenClass(rpi, ppname, sb, tabnum);
				}

				break;
			case 4:
				sb.AddChar(tabnum, '\t').Append($"public bool? {ppname} {{ get; set; }}\r\n");
				break;
			case 5:
				sb.AddChar(tabnum, '\t').Append($"public {ppname}Item {ppname} {{ get; set; }}\r\n");
				sb.AppendLine();
				GenClass(rpi, ppname, sb, tabnum);
				break;
			case 6:
				sb.AddChar(tabnum, '\t').Append($"public short? {ppname} {{ get; set; }}\r\n");
				break;
			case 7:
				sb.AddChar(tabnum, '\t').Append($"public int? {ppname} {{ get; set; }}\r\n");
				break;
			case 8:
				var d = GetMapTypeStr(rpi, ppname);
				sb.AddChar(tabnum, '\t').Append($"public {d} {ppname} {{ get; set; }}\r\n");
				if (rpi.mapValueType == 5)
				{
					sb.AppendLine();
					GenClass(rpi, ppname, sb, tabnum);
				}

				break;
			case 9:
				sb.AddChar(tabnum, '\t').Append($"public decimal? {ppname} {{ get; set; }}\r\n");
				break;
			default:
				break;
		}
	}

	// ppname 当前字段的class名称，prappname 父类的名称
	public void GenClass(DouyinApiDef.ResponseDataItem prpi, string ppname, StringBuilder sb, int tabnum)
	{
		sb.AddChar(tabnum, '\t').AppendFormat($"public class {ppname}Item").AppendLine();
		sb.AddChar(tabnum, '\t').AppendLine("{");
		if (prpi.children != null)
		{
			for (var i = 0; i < prpi.children.Count; i++)
			{
				var rpi = prpi.children[i];
				Gen(rpi, sb, tabnum + 1,ppname);
				if (i != prpi.children.Count - 1)
					sb.AppendLine();
			}
		}

		sb.AddChar(tabnum, '\t').AppendLine("}");
	}

	public void Gen(DouyinApiDef.ResponseDataItem rpi, StringBuilder sb, int tabnum,string parppname)
	{
		var ppname = ToCamelCase(rpi.responseName);
		if (ppname == parppname)
			ppname = ppname + "I";
		if (ppname != rpi.responseName)
			sb.AddChar(tabnum, '\t').Append($"[JsonPropertyName(\"{rpi.responseName}\")]\r\n");
		if (!String.IsNullOrWhiteSpace(rpi.description))
			sb.AddChar(tabnum, '\t').Append($"[Description(\"{TrimDesc(rpi.description)}\")]\r\n");
		switch (rpi.type)
		{
			case 1:
				sb.AddChar(tabnum, '\t').Append($"public long {ppname} {{ get; set; }}\r\n");
				break;
			case 2:
				sb.AddChar(tabnum, '\t').Append($"public string {ppname} {{ get; set; }}\r\n");
				break;
			case 3:
				var ld = GetListTypeStr(rpi, ppname);
				sb.AddChar(tabnum, '\t').Append($"public {ld} {ppname} {{ get; set; }}\r\n");
				if (rpi.subType == 5)
				{
					sb.AppendLine();
					GenClass(rpi, ppname, sb, tabnum);
				}

				break;
			case 4:
				sb.AddChar(tabnum, '\t').Append($"public bool {ppname} {{ get; set; }}\r\n");
				break;
			case 5:
				sb.AddChar(tabnum, '\t').Append($"public {ppname}Item {ppname} {{ get; set; }}\r\n");
				sb.AppendLine();
				GenClass(rpi, ppname, sb, tabnum);
				break;
			case 6:
				sb.AddChar(tabnum, '\t').Append($"public short {ppname} {{ get; set; }}\r\n");
				break;
			case 7:
				sb.AddChar(tabnum, '\t').Append($"public int {ppname} {{ get; set; }}\r\n");
				break;
			case 8:
				var d = GetMapTypeStr(rpi, ppname);
				sb.AddChar(tabnum, '\t').Append($"public {d} {ppname} {{ get; set; }}\r\n");
				if (rpi.mapValueType == 5)
				{
					sb.AppendLine();
					GenClass(rpi, ppname, sb, tabnum);
				}

				break;
			case 9:
				sb.AddChar(tabnum, '\t').Append($"public decimal {ppname} {{ get; set; }}\r\n");
				break;
			default:
				Console.WriteLine("unknown");
				break;
		}
	}

	public static string TrimDesc(string desc)
	{
		if (desc == null)
			return "";
		return desc.Replace("\r\n", ",").Replace('\n', ',').Replace("\"", "").Replace('\\', ',');
	}

	public static string ToCamelCase(string the_string)
	{
		if (the_string == null || the_string.Length < 2)
			return the_string;

		string[] words = the_string.Split(
			new char[] { ' ', '_', '/' },
			StringSplitOptions.RemoveEmptyEntries);

		string result = "";
		for (int i = 0; i < words.Length; i++)
		{
			result +=
				words[i].Substring(0, 1).ToUpper() +
				words[i].Substring(1);
		}

		return result;
	}
}