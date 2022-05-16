using Newtonsoft.Json;

namespace Kuaidi100.Common.Request.cloud
{
    public class DevStatusParam {
        /// <summary>
        /// 设备码
        /// </summary>
        public string siid {get; set;}

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented,new JsonSerializerSettings(){NullValueHandling = NullValueHandling.Ignore});
        }
    }
}