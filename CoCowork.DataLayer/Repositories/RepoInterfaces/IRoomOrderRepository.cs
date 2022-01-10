using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IRoomOrderRepository
    {
        int Add(RoomOrder roomorder);
        void Delete(int id);
        List<RoomOrder> GetAll();
        RoomOrder GetById(int id);
        void Update(RoomOrder roomorder);
    }
}