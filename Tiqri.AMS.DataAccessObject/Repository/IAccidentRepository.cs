using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Repository
{
    public interface IAccidentRepository
    {
        int GetNextSequenceValue();

        int InsertAccident(Accident accident);

        List<Accident> QueryAccident();
    }
}
