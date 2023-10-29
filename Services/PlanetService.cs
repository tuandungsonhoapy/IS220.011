using DAFramework.Models;

namespace DAFramework.Services {
    public class PlanetService : List<PlanetModel>
    {
        public PlanetService()
        {
            this.AddRange(new PlanetModel[]{
                new PlanetModel(){id_planet=1, name_planet = "Mặt trời", content = "Mạt trời rất chi là nóng!"},
                new PlanetModel(){id_planet=2, name_planet = "Mặt trăng", content = "mặt trăng rất chi là tròn!"},
                new PlanetModel(){id_planet=3, name_planet = "Sao hỏa", content = "Sao hỏa rất chi là nóng!"},
                new PlanetModel(){id_planet=4, name_planet = "Sao kim", content = "Sao kim rất chi là nóng!"},
                new PlanetModel(){id_planet=5, name_planet = "Sao mộc", content = "Sao mộc rất chi là nóng!"},
                new PlanetModel(){id_planet=6, name_planet = "Sao thủy", content = "Sao thủy rất chi là nóng!"}
            });
        }
    }
}