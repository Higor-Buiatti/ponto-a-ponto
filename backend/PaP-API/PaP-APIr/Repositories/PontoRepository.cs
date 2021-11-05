using PaP_API.Data;
using PaP_API.Models;
using PaP_APIr.Interfaces;

namespace PaP_APIr.Repositories
{
    public class PontoRepository : Repository<Ponto>, IPontoRepository
    {
        public PontoRepository(MeuDbContext context) : base(context)
        {

        }
    }
}
