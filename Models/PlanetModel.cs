using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAFramework.Models{
    public class PlanetModel {
        [Key]
        public int id_planet {set;get;}

        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string name_planet {set;get;}
        
        [Column(TypeName = "ntext")]
        public string content {set;get;}
    }
}