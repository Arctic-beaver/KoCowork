using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IMiniOfficeRepository
    {
        void Add(MiniOffice miniOffice);
        void DeleteMiniOfficeById(int id);
        List<MiniOffice> GetAll();
        MiniOffice GetMiniOfficeById(int id);
        void UpdateMiniOfficeById(MiniOffice miniOffice);
    }
}