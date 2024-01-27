using System.ComponentModel.DataAnnotations.Schema;

namespace QueViagem.Model
{
    [Table("destinos")]
    public class Destinos
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; } = string.Empty;

        [Column("pais")]
        public string Pais { get; set; } = string.Empty;

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("imagem_destino")]
        public string ImagemDestino { get; set; } = string.Empty;

    }
}