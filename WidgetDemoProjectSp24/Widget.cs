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

        // overloading done with the constructors
        // overriding 
        // sub class - all classes are a sub class of the class Object, so it inherits certain this like ToString
        // property - read only
        // backing variable - a local variable that gets set by the property
        // auto-properties - a property without a specified backing variable
        // add description property to Widget
        // add more constructors (part of overloading)
        // add const colors - to show static 
        // add ToString - will show override
        // add ability to sort - sorting  is done on an array.  The class only has to define how to compare classes

        //backing  variable for description property
        private string desc;
        public static readonly string BLUE = "blue";
        public static readonly string YELLOW = "yellow";
        public static readonly string RED = "red";

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

        // Here the WidgetName property cannot be set except inside this class- this makes it readonly outside the class
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

        public override string ToString()
        {
            return ("Widget Name is  " + WidgetName + 
                " Widget Description is " + Description +
                " Widget Color is " + Color +
                " Widget Price is " + Price.ToString("C")
                
                ) ;
        }

    }
      
}
