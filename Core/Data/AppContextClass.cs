using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public static  class AppContextClass
    {
        static List<Room> rooms = new List<Room>();
        static List<Hotel> hotels = new List<Hotel>();
        public static void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public static void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public static List<Hotel> GetAllHotel()
        {
            return hotels;
        }
        public static List <Room> FindAllRoom()
        {
            return rooms;
        }
        public static void MakeReservation(int? roomId ,int customerCount)
        {

        }




    }
}
