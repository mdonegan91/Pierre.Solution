using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierre.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat's name can't be empty!")]
    public string TreatName { get; set; }
    
    [Required(ErrorMessage = "The Treat's description can't be empty!")]
    public string TreatDescription { get; set; }

    public Rating Ranking { get; set; }

    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
    public string UserId { get; set; }
    
  }

  public enum Rating
  {
    excellent,
    good,
    alright
  }

}