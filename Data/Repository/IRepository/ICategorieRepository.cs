using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.Repository
{
    public interface ICategorieRepository: IRepository<Categorie>
    {
        void Update(Categorie categorie);
    }
}
