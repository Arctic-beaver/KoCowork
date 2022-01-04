using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IRoomRepository
    {
        void Add(Room room);
        void Delete(int id);
        List<Room> GetAll();
        Room GetById(int id);
        void Update(Room room);
    }
}