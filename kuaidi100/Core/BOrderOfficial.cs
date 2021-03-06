using Kuaidi100.Common.Request;
using Kuaidi100.Common.Request.BorderOfficial;
using Kuaidi100.Utils;
using Kuaidi100.Common;
/// <summary>
/// 商家寄件（官方快递）
/// </summary>
public static class BOrderOfficial
{

    /// <summary>
    /// 下单
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
     public static string order(BaseReq<BOrderOfficialOrderParam> param){
        
        param.method = ApiInfoConstant.B_ORDER_OFFICIAL_ORDER_METHOD;
        var request = ObjectToDictionaryUtils.ObjectToMap(param);
        
        if(request == null){
            return null;
        }
        var result = HttpUtils.doPostForm(ApiInfoConstant.B_ORDER_OFFICIAL_URL,request);
        return result;
    }

    /// <summary>
    /// 商家寄件下单价格接口
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
     public static string queryPrice(BaseReq<BOrderOfficialQueryPriceParam> param){
        
        param.method = ApiInfoConstant.B_ORDER_OFFICIAL_PRICE_METHOD;
        var request = ObjectToDictionaryUtils.ObjectToMap(param);
        
        if(request == null){
            return null;
        }
        var result = HttpUtils.doPostForm(ApiInfoConstant.B_ORDER_OFFICIAL_URL,request);
        return result;
    }

    /// <summary>
    /// 取消下单
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
     public static string cancel(BaseReq<BOrderOfficialCancelParam> param){
        
        param.method = ApiInfoConstant.B_ORDER_OFFICIAL_CANCEL_METHOD;
        var request = ObjectToDictionaryUtils.ObjectToMap(param);
        
        if(request == null){
            return null;
        }
        var result = HttpUtils.doPostForm(ApiInfoConstant.B_ORDER_OFFICIAL_URL,request);
        return result;
    }
}