
using GestionStock.Data.Entities;
using GestionStock.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GestionStock.Data.Repositories
{
    public class MouvementsStockRepository
    {

        private readonly StockDbContext _context;
        public MouvementsStockRepository(StockDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MouvementStock> GetAll()
        {
            return _context.MouvementsStock.ToList();
        }

        public MouvementStock GetById(int id)
        {
            return _context.MouvementsStock
                .Include(p => p.Produit)
                .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<MouvementStock> GetByProduitId(int produitId)
        {
            return _context.MouvementsStock
                .Where(m => m.ProduitId == produitId)
                .Include(p => p.Produit)
                .OrderByDescending(m => m.DateMouvement)
                .ToList();
        }
        public IEnumerable<MouvementStock> GetByType(string type)
        {
            return _context.MouvementsStock
                .Where(m => m.TypeMouvement == type)
                .Include(p => p.Produit)
                .OrderByDescending(m => m.DateMouvement)
                .ToList();
        }
        public void Add(MouvementStock mouvement)
        {
            _context.MouvementsStock.Add(mouvement);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var mouvement = _context.MouvementsStock.Find(id);
            if (mouvement != null)
            {
                _context.MouvementsStock.Remove(mouvement);
                _context.SaveChanges();
            }
        }

        public void Update(MouvementStock mouvement)
        {
            _context.MouvementsStock.Update(mouvement);
            _context.SaveChanges();
        }
    }
}

