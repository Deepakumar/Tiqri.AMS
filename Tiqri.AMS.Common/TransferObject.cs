using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Common
{
    public class BizTransObject<T>
    {
        public BizTransObject() { this.StatusInfo = new StatusInfo();  }

        public BizTransObject(T Tval,StatusInfo statusInfo)
        {
            this.StatusInfo = statusInfo;
            this.Value = Tval;
        }
        public StatusInfo StatusInfo { get; set; }

        public T Value { get; set; }
    }
}
