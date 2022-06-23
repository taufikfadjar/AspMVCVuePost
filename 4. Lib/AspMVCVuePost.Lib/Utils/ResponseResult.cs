using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVCVuePost.Lib.Utils
{

    public interface IResponseResult
    {
        string Messages { get; set; }
        bool Success { get; set; }

    }

    public interface IResponseResult<T> : IResponseResult
    {
        T Result { get; set; }
    }
    public class ResponseResult : IResponseResult
    {
        public string Messages { get; set; }
        public bool Success { get; set; }

        public static ResponseResult CreateSuccess(string message = "")
        {
            var result = new ResponseResult();
            result.Success = true;
            result.Messages = message;

            return result;
        }

        public static ResponseResult CreateFail(string message = "")
        {
            var result = new ResponseResult();
            result.Success = false;
            result.Messages = message;

            return result;
        }
    }

    public class ResponseResult<T> : IResponseResult<T>
    {
        public string Messages { get; set; }
        public bool Success { get; set; }
        public T Result { get; set; }

    }
}
