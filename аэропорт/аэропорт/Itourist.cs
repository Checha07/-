using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
    public interface Itourist: Ivisa
    {
        string name { get; set; }
        int age {get; set; }
        int pasportnumber { get; set; }
        List<Iluggage> luggage { get; set; }
        bool Ivisa { get; set; }
        public void Show()
        {
            Console.WriteLine(this.name);
        }
    }
}
