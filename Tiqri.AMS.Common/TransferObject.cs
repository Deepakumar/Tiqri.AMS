using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.AMS.Common
{
    public class TransferObject<T>
    {
        public TransferObject() { this.StatusInfo = new StatusInfo();  }

        public TransferObject(T Tval,StatusInfo statusInfo)
        {
            this.StatusInfo = statusInfo;
            this.Value = Tval;
        }
        public StatusInfo StatusInfo { get; set; }

        public T Value { get; set; }
    }
}
