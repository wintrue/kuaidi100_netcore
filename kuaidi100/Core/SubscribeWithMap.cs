
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using Kuaidi100.Utils;
using Kuaidi100.Common;
using Kuaidi100.Common.Request.Subscribe;

public class SubscribeWithMap{


    public static string subscribe(SubscribeReq subscribeReq){
        
        var request = ObjectToDictionaryUtils.ObjectToMap(subscribeReq);
        
        if(request == null){
            return null;
        }
        var result = HttpUtils.doPostForm(ApiInfoConstant.SUBSCRIBE_URL_WITH_MAP,request);
        return result;
    }
}   