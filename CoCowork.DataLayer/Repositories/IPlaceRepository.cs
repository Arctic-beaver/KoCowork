using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IPlaceRepository
    {
        bool Add(Place place);
        bool DeletePlace(int id);
        List<Place> GetAll();
        Place GetPlaceById(int id);
        List<Place> GetPlacesThatNotInMiniOffice();
        void UpdatePlaceById(Place place);
    }
}