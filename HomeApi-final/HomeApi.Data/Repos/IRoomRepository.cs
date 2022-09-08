using System;
using System.Threading.Tasks;
using HomeApi.Data.Models;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        Task<Room> GetRoomByName(string name);
        Task<Room> GetRoomById(Guid id);
        Task UpdateRoom(Room room, string name, int area, bool gasConnected, int voltage);
        Task AddRoom(Room room);
    }
}