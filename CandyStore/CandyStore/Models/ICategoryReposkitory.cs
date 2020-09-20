using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public interface ICategoryReposkitory
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
