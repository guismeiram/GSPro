using DevIO.Bussines.models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.interfaces
{
    public interface IRepositorySiati<Siati>:IDisposable where Siati:Entity
    {
        Task Adicionar(Siati siati);
        Task Atualizar(Siati siati);
        Task Remover(Guid id);
        Task<IEnumerable<Siati>> Buscar(Expression<Func<Siati, bool>> predicate);
        Task<int> SaveChanges();
        Task<Siati> ObterPorId(Guid id);
        Task<List<Siati>> ObterTodos();

    }
}
