using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategorieRepository categorie { get; }
        ISP_Call SP_Call { get; }
    }
}
