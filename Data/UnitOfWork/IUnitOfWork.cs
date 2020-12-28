using ProjectWebApp.Data.Repository;
using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.UnitOfWork
{

    public interface IUnitOfWork
    {
        IGenericRepository<Algemeenheden> AlgemeenhedenRepository { get; }
        IGenericRepository<Categorie> CategorieRepository { get; }
        IGenericRepository<Federatie> FederatieRepository { get; }
        IGenericRepository<Klant> KlantRepository { get; }
        IGenericRepository<Niveau> NiveauRepository { get; }
        IGenericRepository<Omschrijving> OmschrijvingRepository { get; }
        IGenericRepository<Opleiding> OpleidingRepository { get; }
        IGenericRepository<Slot> SlotRepository { get; }
        IGenericRepository<Voorwaarden> VoorwaardenRepository { get; }
        IGenericRepository<OpgeslagenOpleidingen> OpgeslagenOpleidingenRepository { get; }
        Task Save();
    }
}
