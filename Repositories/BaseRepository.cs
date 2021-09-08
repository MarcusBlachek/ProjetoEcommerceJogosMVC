using Microsoft.EntityFrameworkCore;
using ProjetoGamesEcommerce.Data;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce.Repositories
{
    public class BaseRepository<T> where T: BaseModel
    {
        protected readonly EcommerceJogosContext _contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(EcommerceJogosContext contexto)
        {
            _contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
