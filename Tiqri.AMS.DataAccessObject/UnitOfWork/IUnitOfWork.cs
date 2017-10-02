using Tiqri.AMS.DataAccessObject.Repository;

namespace Tiqri.AMS.DataAccessObject
{
    public interface IUnitOfWork
    {
        IAccidentCategoryRepository AccidentCategoryRepository { get; }

        void Save();
    }
}