using System;
using System.Collections.Generic;
using System.Text;

namespace аэропорт
{
    class Airport
    {
     private List<Itourist> travellers = new List<Itourist>();

        public List<Itourist> CheckAndShow()
        {
            List<Itourist> whitelist = new List<Itourist>(); ;
            foreach (var tourist in this.travellers)
            
                if (tourist.age > 18 && tourist.Ivisa==true && this.CalculateWeight(tourist.luggage) < 30)
                    whitelist.Add(tourist);
                return whitelist;
        }
        public double CalculateWeight(List<Iluggage> luggages)
        {
           double summ = 0;
            foreach (var luggage in luggages)
                 summ += luggage.weight;
            return summ;
        }
    }  
}
   
    

