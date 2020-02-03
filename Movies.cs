using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_11
{
    class Movies
    {

        //I don't even know if I did any of this right. I don't know if I actually have to set get; and set; as something more or not.
        //I want to understand this stuff, because I guaruntee it is extremely helpful once you figure it out. Currently though, I dont know what to do.
        public string Category { get; set; }
        public string Title { get; set; }
        
        public Movies(string Category, string Title)
        {
            this.Category = Category;
            this.Title = Title;
        }
    }
}
