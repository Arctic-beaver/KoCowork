using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IPlaceRepository
    {
        int Add(Place place);
        void DeletePlaceById(int id);
        List<Place> GetAll();
        Place GetPlaceById(int id);
        List<Place> GetPlacesThatNotInMiniOffice();
        void UpdatePlaceById(Place place);
    }
}