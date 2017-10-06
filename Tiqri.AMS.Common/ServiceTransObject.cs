using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Common
{
    public class ServiceTransObject<T>
    {
        public ServiceTransObject() { }
        public ServiceTransObject(bool ResponseStatus, string Message,T Result) {
            this.ResponseStatus = ResponseStatus;
            this.Message = this.Message;
            this.Result = this.Result;
        }
        public T Result { get; set; }
        public bool ResponseStatus { get; set; }
        public string Message { get; set; }
    }
}
