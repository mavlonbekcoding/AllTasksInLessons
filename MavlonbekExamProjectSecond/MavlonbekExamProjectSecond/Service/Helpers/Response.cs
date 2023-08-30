using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Service.Helpers
{
    public class Response<M>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public M Data { get; set; }
    }
}
