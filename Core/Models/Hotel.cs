using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Hotel
    {
        public int _id=1;
        public string Name;

        public int Id { get; set; }
        public Hotel( string name)
        {
            _id++;
            Id = _id;
            Name = name;
                
        }
        
        public string  GetInfoHotel()
        {
            return $"Name:{Name}";
        }
        public override string ToString()
        {
            return GetInfoHotel();
        }


    }
}
