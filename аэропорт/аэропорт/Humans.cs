using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
   public class Humans
    {
        protected string name;
        protected int age;
        protected  int pasportnumber;

        public Humans(string name, int age, int pasportnumber)
        {
            this.name = name;
            this.age = age;
            this.pasportnumber = pasportnumber;
        }
        Humans Vasya = new Humans("Vasya", 25, 2345);
    }
}
