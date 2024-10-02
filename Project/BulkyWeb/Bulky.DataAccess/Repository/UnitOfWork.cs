using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
	public class UnitOfWork : iUnitOfWork
	{
		private ApplicationDbContext _db;
		public iCategoryRepository Category { get; private set; }
		public iProductRepository Product { get; private set; }
		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
            Category = new CategoryRepository(_db);
			Product = new ProductRepository(_db);
		}
		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
