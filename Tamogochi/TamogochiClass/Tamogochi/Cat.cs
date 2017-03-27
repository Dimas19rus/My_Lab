using System;

namespace Tamogochi
{
    public class Cat
    {
        private readonly DateTime _birthday = DateTime.Now;
        public TimeSpan AgeTimeSpan => (DateTime.Now - _birthday);

        public  Human Namehuman { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public string LifeToy { get; set; }


        public Cat(Human namehuman)
        {
            Namehuman = namehuman;
        }

        private void Bitten()
        {
            Console.WriteLine("Удача к вам не благосклонна {0} вас Укусила", _name);
        }
        private void Mew()
        {
            Console.WriteLine("Фортуна вам улыбается {0} Мяукнула", _name);
        }

        public void Caress()
        {
            Random run = new Random();
            int ins = run.Next(0, 2);

            if (ins == 0)
            {
                Bitten();
            }
            else
            {
                Mew();
            }
        }

    }
}
