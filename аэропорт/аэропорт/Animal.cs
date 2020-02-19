using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
    class Animal : Itourist, Iluggage
    {
        public double weight { get ; set; }
        public string name { get ; set; }
        public int age { get; set; }
        public int pasportnumber { get; set; }
        public List<Iluggage> luggage { get; set ; }
        public bool Ivisa { get ; set ; }
    }
}
