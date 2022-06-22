using System.ComponentModel.DataAnnotations;
using MonoProjekt.Service.Models;

namespace MonoProjekt.MVC.Models
{
    public class VehicleModelModel
    {
        #region Properties

        public string Abrv { get; set; }

        [Key]
        public Guid Id { get; set; }

        public Guid MakeId { get; set; }

        [Required]
        public string Name { get; set; }

        public VehicleMake VehicleMake { get; set; }

        #endregion Properties
    }
}
