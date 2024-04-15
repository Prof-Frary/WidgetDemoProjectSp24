using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemoProjectSp24
{
    internal class Widget
    {
        // constructor - must be public and no return type
        public Widget(string name, string color) {
            WidgetName = name;
            Color = color;
        
        }


        public string WidgetName { get; set; }  
        public string Color { get; set; }
        public double Price { get; set; }


    }
}
