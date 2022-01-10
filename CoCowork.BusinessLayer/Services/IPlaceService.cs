using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IPlaceService
    {
        void DeletePlace(int id);
        List<PlaceModel> GetAll();
        List<PlaceModel> GetAllThatNotInMiniOffices();
        int InsertPlace(PlaceModel place);
        void UpdatePlace(PlaceModel place);
    }
}