using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_11
{
    class Movie
    {
        //Here is where the magic happens.
        //We set Category and Title as there own Objects that have a get and set parameter.
        //We do not need these parameters to do anything for this lab, so we are fine leaving them as get; and set;
        public string Category { get; set; }
        public string Title { get; set; }
        
        //THIS however is Movie, and uses both of the above Objects to create the rest.
        //This Object needs two parameters for the Lab, and we set those as string title, and category.
        //Because of this, whenever we need a new Movie, we need to have both parameters met.
        //Secondly, we convert the Object Parameters Category and Title to equal their respective string name.
        //We do this so that when we label these strings with new Movie's, we can use the objects above to get and set specific things.
        public Movie(string title, string category)
        {
            this.Category = category;
            this.Title = title;
        }
    }
}
