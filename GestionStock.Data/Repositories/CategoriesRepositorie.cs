using GestionStock.Data.Entities;
using GestionStock.Data.Context;

namespace GestionStock.Data.Repositories
{
    public class CategoriesRepositorie
    {
        private readonly StockDbContext _context;
        public CategoriesRepositorie(StockDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categories GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Categories categorie)
        {
            _context.Categories.Add(categorie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categorie = _context.Categories.Find(id);
            if (categorie != null)
            {
                _context.Categories.Remove(categorie);
                _context.SaveChanges();
            }
        }

        public void Update(Categories categorie)
        {
            _context.Categories.Update(categorie);
            _context.SaveChanges();
        }
    }
}
