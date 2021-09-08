using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoGamesEcommerce.Models
{
    public class Cadastro : BaseModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Telefone { get; set; }
        [Required]

        public string Endereco { get; set; }
        [Required]

        public string Complemento { get; set; }
        [Required]

        public string Bairro { get; set; }
        [Required]

        public string Cep { get; set; }
        [Required]

        public string Municipio { get; set; }
        [Required]

        public string Uf { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Cadastro()
        {
        }
    }

}

