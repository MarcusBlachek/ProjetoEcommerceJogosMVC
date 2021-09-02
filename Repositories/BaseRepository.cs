using Microsoft.EntityFrameworkCore;
using ProjetoGamesEcommerce.Data;

namespace ProjetoGamesEcommerce.Repositories
{
    public class BaseRepository<T> where T: BaseModel
    {
        protected readonly EcommerceJogosContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(EcommerceJogosContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
