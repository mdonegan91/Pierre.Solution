using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierre.Models
{
  public class Flavor
    {
        public int FlavorId { get; set; }
        [Required(ErrorMessage = "The treat's flavor field can't be left empty!")]
        public string FlavorTown { get; set; }
        public List<TreatFlavor> JoinEntities { get;}
        public ApplicationUser User { get; set; } 
    }
}