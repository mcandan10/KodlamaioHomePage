using KodlamaioHomePage.Business.Abstract;
using KodlamaioHomePage.Data_Access_Layer.Abstract;
using KodlamaioHomePage.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Concrete
{
    public class CategoryManager : IEntityService
    {
        IData _categoryDal;
        public CategoryManager(IData categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public bool Add(IEntity category)
        {
            _categoryDal.Add(category);
            return true;
        }

        public bool Delete(int id)
        {
            _categoryDal.Delete(id);
            return true;
        }

        public List<IEntity> GetList()
        {
            return _categoryDal.GetList();
        }

        public bool Update(int id, IEntity category)
        {
            _categoryDal.Update(id, category);
            return true;
        }
    }
}
