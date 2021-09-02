using EcommerceJogosEntities;
using System.Collections.Generic;


    public class Cadastro : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public IList<Pedido> Pedidos  { get; set; }

        public Cadastro()
        {
        }

        public Cadastro(string nome, string email, string telefone
            , string complemento, string bairro, string cep
            , string endereco, string municipio, string uf)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Municipio = municipio;
            Uf = uf;
        }
    }

