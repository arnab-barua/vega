using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
        public MakeResource()
        {
            Model = new Collection<ModelResource>();
        }


        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<ModelResource> Model { get; set; }
    }
}
