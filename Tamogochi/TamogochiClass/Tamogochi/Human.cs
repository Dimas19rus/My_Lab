using System;
using System.Linq;

namespace Tamogochi
{
    public class Human
    {
        public string Name { get; set; }

        public Human()
        {
            
        }
        public Human(string name)
        {
            Name = name;
        }

        public void InfoCatHuman(Cat cat)
        {
            Console.WriteLine("Имя хозяина {0} \nИмя кошки {1} \nВозраст {1} равен {2} \n{3} - любимая игрушка", Name, cat.Name, cat.AgeTimeSpan,  cat.LifeToy);
            
            while(true)
            {
                Console.WriteLine("Хотите погладить животное (yes/no)");
                string a = Console.ReadLine();
                if (a=="Yes" || a== "yes" || a=="y" || a=="Y")
                {
                    cat.Caress();
                }
                else
                {
                    if (a == "No" || a == "no" || a == "n" || a == "N")
                    {
                        break;
                    }
                    Console.WriteLine("ERROR такой команды нет попрбуй еще раз");
                }
            }
        }
    }
}
