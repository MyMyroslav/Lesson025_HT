using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson025_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var theFirstCollection = new List<Car>
            {
                new Car() {mark = "MERC", model = "CUPE", year = "2010", color = "yellow"},
                new Car() {mark = "BMW", model = "BUS", year = "2012", color = "green"},
                new Car() { mark = "HONDA", model = "CABROLET", year = "2019", color = "dark" }
            };
            var theSecondCollection = new List<Car>
            {
                new Car() {model = "Cupe", ownerName = "Ivan", phoneNumber = "+380678337442"},
                new Car() {model = "Bus", ownerName = "Petro", phoneNumber = "+380675469941"},
                new Car() {model = "Cabriolet", ownerName = "Vika", phoneNumber = "+380972688063"}
            };
            object auto = theFirstCollection.ElementAt(1).mark + " " + theFirstCollection.ElementAt(1).model + " " + theFirstCollection.ElementAt(1).year + " " + theFirstCollection.ElementAt(1).color + " ";
            object person = theSecondCollection.ElementAt(1).ownerName + " " + theSecondCollection.ElementAt(1).phoneNumber;
            Console.WriteLine("\n\t" + auto + "Buyed by: " + person);
        }
    }
}
