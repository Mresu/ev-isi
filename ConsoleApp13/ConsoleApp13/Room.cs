using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Room
    {
        private int _id;
        public int Id { get; }
        public int Price { get; set; }
        public byte PersonCapacity { get; set; }
        public bool IsAvialable { get; set; }
        public string Name { get; set; }

        public string Showinfo()
        {
            return $" room:{Id}, name:{Name},Person Capacity:{PersonCapacity}, Price:{Price}, IsAvialable:{IsAvialable}";
        }
        public Room (string name, int price , byte personcapacity)
        {
            Id = _id++;
            name = Name;
            price = Price;
            PersonCapacity = personcapacity;

                
        }
        public override string ToString()
        {
            return Showinfo();
        }
    }
}

