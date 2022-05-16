using Kuaidi100.Common;
using Kuaidi100.Utils;

public static class AutoNum
{
    public static string query(string num, string key)
    {
        var url = string.Format(ApiInfoConstant.AUTO_NUM_URL,num,key);
        var result = HttpUtils.doGet(url);
        return result;
    }
}
