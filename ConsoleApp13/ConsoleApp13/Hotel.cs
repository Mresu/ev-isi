using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Hotel
    { 
        public string Name {  get; set; }
        public object Id { get;set; }
        List<Room> rooms= new List<Room>();
        public Hotel( string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public Room MakeReservation( int? roomId)
        {
            if(roomId == null)
            {
                throw new NullReferanceException("rezev olunub");
            }
            foreach(Room room in rooms)
            {
                if (roomId = room.Id)
                {
                    Console.WriteLine("rezev oldu");
                    room.IsAvialable = true;
                    return room;
                    
                }
                else
                {
                    throw new NotAvailableEXception("rezev olunub");
                }
                return room;

            }
            

        }
        public  double FindAllroom(Room room)
        {
            bool RoomsName=false;
            foreach(Room rooms in rooms)
            {
                if (rooms.Name = room.Name)
                {
                    RoomsName= true;
                }
                return room.Id;
            }

        }
    }
}
