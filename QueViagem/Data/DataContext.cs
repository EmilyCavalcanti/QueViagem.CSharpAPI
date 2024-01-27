using QueViagem.Model; 
using Microsoft.EntityFrameworkCore;

namespace QueViagem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Destinos> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destinos>().HasData(
                new Destinos
                {
                    Id = 1, Cidade = "Amsterdã", Pais = "Holanda", Valor = 3100, ImagemDestino = "https://www.melhoresdestinos.com.br/wp-content/uploads/2019/02/passagens-aereas-amsterda-capa2019-03-820x430.jpg"
                },
                new Destinos
                {
                     Id = 2, Cidade = "Paris", Pais = "França", Valor = 3600, ImagemDestino = "https://viagemeturismo.abril.com.br/wp-content/uploads/2016/11/thinkstockphotos-4549879531.jpeg?quality=90"
                },
                new Destinos
                {
                      Id = 3, Cidade = "Santiago", Pais = "Chile", Valor = 3300, ImagemDestino = "https://www.vrbo.com/pt-br/dicas-viagem/wp-content/uploads/67PoRLlKbEDl0ZGSgeKs2E/eff02c3a63848a35d322b172ebee7645/AdobeStock_209940755.jpeg"
                },
                 new Destinos
                {
                      Id = 4, Cidade = "Buenos Aires", Pais = "Argentina", Valor = 2950, ImagemDestino = "https://aguiarbuenosaires.com/wp-content/uploads/2015/10/Obelisco-Mapa-de-Buenos-Aires-Foto-Wikipedia2-800x600.jpg"
                },
                 new Destinos
                {
                      Id = 5, Cidade = "Fernando de Noronha", Pais = "Brasil", Valor = 5500, ImagemDestino = "https://www.melhoresdestinos.com.br/wp-content/uploads/2022/02/fernando-noronha-capa-2022-820x430.jpg"
                },
                 new Destinos
                {
                      Id = 6, Cidade = "Orlando", Pais = "EUA", Valor = 4850, ImagemDestino = "https://res.klook.com/image/upload/c_fill,w_1265,h_712/q_80/activities/alg3puq4hmpeobqhumjd.webp"
                }
            );
        }

    }
}