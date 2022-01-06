using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IMiniOfficeRepository
    {
        int Add(MiniOffice miniOffice);
        bool DeleteMiniOfficeById(int id);
        List<MiniOffice> GetAll();
        MiniOffice GetMiniOfficeById(int id);
        void UpdateMiniOffice(MiniOffice miniOffice);
    }
}