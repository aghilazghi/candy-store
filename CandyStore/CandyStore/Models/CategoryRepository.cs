using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public class CategoryRepository : ICategoryReposkitory
    {      
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Hard Candy", CategoryDescription = "Delicous Hard Candy"},
            new Category {CategoryId = 2, CategoryName = "Chocolate Candy", CategoryDescription = "Delicous Chocolate Candy"},
            new Category {CategoryId = 3, CategoryName = "Fruit Candy", CategoryDescription = "Delicous Fruit Candy"},
        };
    }
}
