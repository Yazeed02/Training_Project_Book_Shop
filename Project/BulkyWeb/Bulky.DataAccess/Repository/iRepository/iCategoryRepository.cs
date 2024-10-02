using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.iRepository
{
    public interface iCategoryRepository : iRepository<Category>
    {
        void Update(Category obj); 
    }
}
