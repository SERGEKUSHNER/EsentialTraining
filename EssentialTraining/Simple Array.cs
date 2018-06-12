 using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
   public class Simple_Array
    {
        public string[] GroceryList;

        public Simple_Array()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }
        public override string ToString()
        {
            return "There are " + GroceryList.Length + "and they are:" + GroceryList;

        }
    }
}
