using Shop.Data;
using Shop.Models;
using System.Linq;

namespace Shop.Services
{
    public class SeedingService
    {
        private DataContext _context;

        public SeedingService(DataContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            Category cat1 = new Category("Categoria 1");
            Category cat2 = new Category("Categoria 2");
            Category cat3 = new Category("Categoria 3");

            if (_context.Category.Any())
            {
                return;
            } 
            else
            {
                _context.AddRange(cat1, cat2, cat3);
                _context.SaveChanges();
            }

            if (_context.Product.Any())
            {
                return;
            }
            else
            {
                Product pod1 = new Product("Produto 1", "pd1", 2.50m, 1, cat1);
                Product pod2 = new Product("Produto 2", "pd2", 1.00m, 1, cat1);
                Product pod3 = new Product("Produto 3", "pd3", 5.35m, 2, cat2);
                Product pod4 = new Product("Produto 4", "pd4", 16.78m, 3, cat3);

                _context.AddRange(pod1, pod2, pod3, pod4);
                _context.SaveChanges();
            }

            if(_context.User.Any())
            {
                return;
            }
            else
            {
                User employee = new User("pedro", "12345", "employee");
                User manager = new User("admin", "12345", "manager");

                _context.AddRange(employee, manager);
                _context.SaveChanges();
            }
        }
    }
}
