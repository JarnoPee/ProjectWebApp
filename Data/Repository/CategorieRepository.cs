using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.Repository
{
    public class CategorieRepository : GenericRepository<Categorie>, ICategorieRepository
    {
        private readonly ApplicationDbContext _db;
        public CategorieRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Categorie categorie)
        {
            var objFromDb = _db.Categorieen.FirstOrDefault(s => s.CategorieID == categorie.CategorieID);
            if (objFromDb != null)
            {
                objFromDb.Naam = categorie.Naam;
                _db.SaveChanges();
            }

        }
    }
}
