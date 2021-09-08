using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ProjetoGamesEcommerce.Models
{
    public class Produto : BaseModel
    {
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Preco { get; set; }

        public Produto()
        {
        }
        public Produto(string codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

    }

}



