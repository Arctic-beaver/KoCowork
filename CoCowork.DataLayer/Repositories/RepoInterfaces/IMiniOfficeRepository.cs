using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IMiniOfficeRepository
    {
        int Add(MiniOffice miniOffice);
        void DeleteMiniOffice(int id);
        List<MiniOffice> GetAll();
        MiniOffice GetMiniOffice(int id);
        void UpdateMiniOffice(MiniOffice miniOffice);
    }
}