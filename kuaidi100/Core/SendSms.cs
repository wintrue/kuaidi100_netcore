
using Kuaidi100.Utils;
using Kuaidi100.Common;
using Kuaidi100.Common.Request;
using Kuaidi100.Common.Request.Sms;

public class SendSms{


    public static string query(SendSmsReq query){
        
        var request = ObjectToDictionaryUtils.ObjectToMap(query);
        if(request == null){
            return null;
        }
        var result = HttpUtils.doPostForm(ApiInfoConstant.SEND_SMS_URL,request);
        return result;
    }
}   