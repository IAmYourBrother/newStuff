using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibs
{
    public class Dispenser
    {
        private int numberOfItems;
        private int cost;

        public Dispenser(int numberOfItems, int cost) 
        {
            this.numberOfItems = numberOfItems;
            this.cost = cost;
        }
        public int GetCount 
        {
            get 
            {
                return numberOfItems;
            }
            set 
            {
                numberOfItems = value;
            }
        }
        public int GetProductCost() 
        {
            return cost;
        }
        public void MakeSale()
        {
            this.numberOfItems--;
        }
    }
}
