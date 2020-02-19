using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
    public class Prosto: Humans, Itourist
    {
        public Prosto(string name, int age, int pasportnumber,List<Iluggage> iluggage, bool Ivisa): base (name, age, pasportnumber)
        {
            this.luggage = iluggage;
            this.Ivisa = Ivisa;

        }
        public bool Ivisa { get ; set; }
        public string name {
            get
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public int age { get
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }
        public int pasportnumber { get 
            {
                return pasportnumber;
            }
            set 
            {
                pasportnumber = value;
            }
        }
        public List<Iluggage> luggage { get; set ; }
    }
}
