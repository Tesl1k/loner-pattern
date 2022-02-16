using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLibrary
{
    public class ChocolateBoiler
    {
        bool empty;
        bool boiled;
        static string description;

        public static ChocolateBoiler uniqueInstance;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
                description = "Бойлер создан";
            }

            return uniqueInstance;
        }
        public string Fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
            }

            return "Наполнено";
        }
        public string Drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
            }

            return "Слито";
        }
        public string Boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
            }

            return "Нагрето";
        }
        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }        

        public string Display()
        {
            return description;
        }
    }
}
