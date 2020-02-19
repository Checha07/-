using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
    class Voenn : Humans, Itourist
    {
        public Voenn(string name, int age, int pasportnumber) : base(name, age, pasportnumber)
        {

        }
        public List<Iluggage> luggage { get ; set ; }
        public bool Ivisa { get; set; }
        string Itourist.name { get ; set ; }
        int Itourist.age { get; set ; }
        int Itourist.pasportnumber { get ; set ; }
    }
}
