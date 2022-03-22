using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.Model
{
    public class Prop : BaseEntity
    {
        public Prop(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
        public bool Finished { get; set; }

    }
}
