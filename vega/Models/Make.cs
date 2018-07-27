using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Make
    {
        public Make()
        {
            Model = new HashSet<Model>();
        }


        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public virtual ICollection<Model> Model { get; set; }
        
    }
}
