using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVCVuePost.Lib.Utils
{
    public class JsonResponseResult
    {
        public string Messages { get; set; }
        public string Url { get; set; }
        public bool Success { get; set; }

        public object Result { get; set; }

        public static JsonResponseResult CreateSuccess (string messages , string url = "" , object result = null)
        {
            return new JsonResponseResult()
            {
                Messages = messages,
                Result = result,
                Success = true,
                Url = url
            };
        }

        public static JsonResponseResult CreateError(string messages, string url = "", object result = null)
        {
            return new JsonResponseResult()
            {
                Messages = messages,
                Result = result,
                Success = false,
                Url = url
            };
        }
    }
}
