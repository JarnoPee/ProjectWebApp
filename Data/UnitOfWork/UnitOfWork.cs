using ProjectWebApp.Data.Repository;
using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Algemeenheden> algemeenhedenRepository;
        private IGenericRepository<Categorie> categorieRepository;
        private IGenericRepository<Federatie> federatieRepository;
        private IGenericRepository<Klant> klantRepository;
        private IGenericRepository<Niveau> niveauRepository;
        private IGenericRepository<Omschrijving> omschrijvingRepository;
        private IGenericRepository<Opleiding> opleidingRepository;
        private IGenericRepository<Slot> slotRepository;
        private IGenericRepository<Voorwaarden> voorwaardenRepository;
        private IGenericRepository<OpgeslagenOpleidingen> opgeslagenOpleidingenRepository;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Algemeenheden> AlgemeenhedenRepository
        {
            get
            {
                if (this.algemeenhedenRepository == null)
                {
                    this.algemeenhedenRepository = new GenericRepository<Algemeenheden>(_context);
                }
                return algemeenhedenRepository;
            }
        }
        public IGenericRepository<Categorie> CategorieRepository
        {
            get
            {
                if (this.categorieRepository == null)
                {
                    this.categorieRepository = new GenericRepository<Categorie>(_context);
                }
                return categorieRepository;
            }
        }
        public IGenericRepository<Federatie> FederatieRepository
        {
            get
            {
                if (this.federatieRepository == null)
                {
                    this.federatieRepository = new GenericRepository<Federatie>(_context);
                }
                return federatieRepository;
            }
        }
        public IGenericRepository<Klant> KlantRepository
        {
            get
            {
                if (this.klantRepository == null)
                {
                    this.klantRepository = new GenericRepository<Klant>(_context);
                }
                return klantRepository;
            }
        }
        public IGenericRepository<Niveau> NiveauRepository
        {
            get
            {
                if (this.niveauRepository == null)
                {
                    this.niveauRepository = new GenericRepository<Niveau>(_context);
                }
                return niveauRepository;
            }
        }
        public IGenericRepository<Omschrijving> OmschrijvingRepository
        {
            get
            {
                if (this.omschrijvingRepository == null)
                {
                    this.omschrijvingRepository = new GenericRepository<Omschrijving>(_context);
                }
                return omschrijvingRepository;
            }
        }
        public IGenericRepository<Opleiding> OpleidingRepository
        {
            get
            {
                if (this.opleidingRepository == null)
                {
                    this.opleidingRepository = new GenericRepository<Opleiding>(_context);
                }
                return opleidingRepository;
            }
        }
        public IGenericRepository<Slot> SlotRepository
        {
            get
            {
                if (this.slotRepository == null)
                {
                    this.slotRepository = new GenericRepository<Slot>(_context);
                }
                return slotRepository;
            }
        }
        public IGenericRepository<Voorwaarden> VoorwaardenRepository
        {
            get
            {
                if (this.voorwaardenRepository == null)
                {
                    this.voorwaardenRepository = new GenericRepository<Voorwaarden>(_context);
                }
                return voorwaardenRepository;
            }
        }
        public IGenericRepository<OpgeslagenOpleidingen> OpgeslagenOpleidingenRepository
        {
            get
            {
                if (this.opgeslagenOpleidingenRepository == null)
                {
                    this.opgeslagenOpleidingenRepository = new GenericRepository<OpgeslagenOpleidingen>(_context);
                }
                return opgeslagenOpleidingenRepository;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
