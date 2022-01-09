using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IMiniOfficeService
    {
        void DeleteMiniOffice(int id);
        List<MiniOfficeModel> GetAll();
        void InsertMiniOffice(MiniOfficeModel miniOffice);
        void UpdateMiniOffice(MiniOfficeModel miniOffice);
    }
}