using System.Runtime.Serialization;

namespace ProjetoGamesEcommerce.Models
{     //Classe base Id. As outras entidades que heradará dessa classe não será necessária a atribuição da propriedade ID.
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }

}