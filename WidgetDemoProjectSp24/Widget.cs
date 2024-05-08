using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemoProjectSp24
{
    internal class Widget
    {
        //for most methods and properties in a class there will be a copy for each object created.
        // If you want the objects to share methods or properties you must use the staiuc keyword
        // usage - keep a count of how many object of this type are created
        // consts that will will be the same for all instances

        // overloading
        // overriding
        // sub class
        // property - read only
        // backing variable
        // auto-properties
        // add description property
        // add more constructors
        // add const colors
        // add ToString
        // add ability to sort

        //backing  variable for description property
        private string desc;
        public static string BLUE = "blue";
        public static string YELLOW = "yellow";
        public static string RED = "red";

        // constructor - must be public and no return type
        public Widget(string name, string color, string d) {
            WidgetName = name;
            desc = d;
            Color = color;
            Price = 0;

        }
        public Widget(string name, string d, double p )
        {
            WidgetName = name;
            desc = d;
            Color = BLUE;
            Price = p;


        }
        public Widget(string name,  string d)
        {
            WidgetName = name;
            desc = d;
            Color = BLUE;
            Price = 0;

        }
        public Widget(string name, string color, string d, double p)
        {
            WidgetName = name;
            desc = d;
            Color = color;
            Price = p;


        }

        //uses auto- properties
        public string WidgetName { get; private set; }
        public string Color { get; set; }
        public double Price { get; set; }
        
        // uses backing variable
        // it also sets the description to be read only
        // we will use this to only set the description on creation of the object

        public string Description { 
             get {            
                return desc;       
            }
            private  set {          
                desc = value;     
            }
         }   

    }

   
}
