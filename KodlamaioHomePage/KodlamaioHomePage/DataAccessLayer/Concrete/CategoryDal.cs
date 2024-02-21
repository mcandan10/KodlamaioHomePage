using KodlamaioHomePage.Data_Access_Layer.Abstract;
using KodlamaioHomePage.Entity.Abstract;
using KodlamaioHomePage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.DataAccessLayer.Concrete
{
    public class CategoryDal : IData
    {
        List<IEntity> categories;
        public CategoryDal()
        {
            categories = new List<IEntity>()
            {
                new Category{Id=1, CategoryName="Programlama"}
            };
        }
        public void Add(IEntity entity)
        {
            categories.Add(entity);
        }

        public void Delete(int id)
        {
            categories.RemoveAt(id-1);
        }

        public List<IEntity> GetList()
        {
            return categories;
        }

        public void Update(int id, IEntity entity)
        {
            foreach (Category category in categories)
            {
                if (category.Id == id)
                {
                    categories.RemoveAt(id - 1);
                    categories.Add(entity);
                    break;
                }
            }
        }
    }
}
