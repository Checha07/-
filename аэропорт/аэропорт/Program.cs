using System;

namespace аэропорт
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport airport= Initialize();
           List <Itourist> whitelist = airport whitelist; 
            foreach (var tourist in whitelist)
            {
                tourist.Show();

            }
        }
        static Airport Initialize()
        {
            Itourist Vasya = new Itourist();
        }
    }
}
