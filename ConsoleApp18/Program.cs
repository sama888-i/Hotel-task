using Core.Data;
using Core.Models;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            string chooice;
            string name;
            double price;
            int capasity;
            
            do
            {
                Console.WriteLine("1.Sisteme giris 0.EXit");
                chooice = Console.ReadLine();
                switch (chooice)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("1.Otel yarat 2.Butun otelleri gor 3.Otel sec 0.Exit");
                            chooice = Console.ReadLine();

                            switch(chooice)
                            {
                                case "1":
                                    Console.WriteLine("Otel adi daxil edin:");
                                    name = Console.ReadLine();


                                    Hotel hotel = new Hotel(name);
                                    AppContextClass.AddHotel(hotel);
                                    break;
                                case "2":
                                    List<Hotel> hotels = AppContextClass.GetAllHotel();
                                    foreach (var item in hotels)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case "3":
                                    do
                                    {
                                        Console.WriteLine("1.Otaq yarat 2.Otaqlari gor 3.Rezervasiya et 4.Evvelki menyuya qayit");
                                        chooice = Console.ReadLine();
                                        switch(chooice )
                                        {
                                            case "1":
                                                bool f2;
                                                
                                                Console.WriteLine("Otaq adi daxil edin :");
                                                name = Console.ReadLine();
                                                do
                                                {
                                                    Console.WriteLine("Otaq qiymeti daxil edin:");
                                                    f2 = false;
                                                    f2 = double.TryParse(Console.ReadLine(), out price);

                                                                                                   
                                                } while (!f2);
                                                do
                                                {
                                                    Console.WriteLine("Otaq tutumu daxil edin:");
                                                    f2 = false;
                                                    f2 = int.TryParse(Console.ReadLine(), out capasity  );


                                                } while (!f2);
                                               
                                                Room room = new Room(name,price,capasity );
                                                AppContextClass.AddRoom(room);


                                                break;
                                            case "2":
                                                List<Room> rooms = AppContextClass.FindAllRoom();
                                                foreach (var item in rooms)
                                                {
                                                    Console.WriteLine(item);

                                                }

                                                break;
                                            case "3":
                                                break;
                                            case "4":

                                                return;
                                            default:
                                                Console.WriteLine("Duzgun secim edin");
                                                break;






                                        }


                                    } while (!f);




                                    break;

                                case "0":
                                    break;
                                default:
                                    Console.WriteLine("Duzgun secin");
                                    break;








                            }


                        } while (!f);



                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Duzgun secin");
                        break;




                }







            } while (!f);
        }
    }
}
