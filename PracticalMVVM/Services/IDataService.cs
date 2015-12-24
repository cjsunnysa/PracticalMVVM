using System.Collections.Generic;

namespace PracticalMVVM.Services
{
    public interface IDataService<TDataType, TIdDataType>
    {
        TDataType GetById(TIdDataType id);
        IEnumerable<TDataType> GetAll();
        void Save(TDataType record);
        void Delete(TDataType record);
    }
}