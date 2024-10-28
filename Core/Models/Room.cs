using Core.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Room
    {
        private static int _id = 1;
        public string Name;
        public double Price;
        public int _personCapasity;
        public bool _isAvialable ;
        public int Id { get; }

        public Room(string name, double price, int personCapasity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;

            PersonCapasity = personCapasity;
            IsAvialable = _isAvialable;
        }
        public int PersonCapasity
        {
            get
            {
                return _personCapasity; 
            }
            set
            {if(value > 0)
                {
                    _personCapasity = value;
                }



            }
        }
        
        public bool IsAvialable {
            get
            {
                return _isAvialable;
            }
            set
            {if(value == false)
                {
                    throw new NotAvialableException("Otaq rezerve olunub");
                }
                else
                {
                    _isAvialable = true;
                    Console.WriteLine("Rezerve deyil");
                }
                
                
            }
        }
        public string ShowInfo()
        {
           return  $"Adi:{Name},Qiymeti:{Price},Tutumu:{PersonCapasity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
