using System;
using Tamogochi;

namespace TamogochiProgram
{
    class Program
    {
        static void Main()
        {

            Human master = new Human {Name = "Cучков Дима"};

            Cat cat = new Cat(master)
            {
                Name = "Мурка",
                LifeToy = "Плюшевый мишка"
            };
            master.InfoCatHuman(cat);
            Console.WriteLine("Для выхода нажмите любую клавишу!!!");

            Console.ReadKey();
        }
    }
}
