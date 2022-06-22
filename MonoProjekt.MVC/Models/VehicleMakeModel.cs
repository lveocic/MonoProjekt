using System.ComponentModel.DataAnnotations;

namespace MonoProjekt.MVC.Models
{
    public class VehicleMakeModel
    {
        #region Properties

        public string Abrv { get; set; }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        #endregion Properties
    }
}
