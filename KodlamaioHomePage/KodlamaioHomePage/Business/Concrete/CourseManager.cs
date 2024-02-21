using KodlamaioHomePage.Business.Abstract;
using KodlamaioHomePage.Data_Access_Layer.Abstract;
using KodlamaioHomePage.Data_Access_Layer.Concrete;
using KodlamaioHomePage.Entity.Abstract;
using KodlamaioHomePage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Concrete
{
    public class CourseManager : IEntityService
    {
        IData _courseDal;
        public CourseManager(IData courseDal)
        {
            _courseDal = courseDal;
        }
        public bool Add(IEntity course)
        {
            _courseDal.Add(course);
            return true;
        }

        public bool Delete(int id)
        {
            _courseDal.Delete(id);
            return true;
        }

        public List<IEntity> GetList()
        {
            return _courseDal.GetList();
        }

        public bool Update(int id, IEntity course)
        {
            _courseDal.Update(id, course);
            return true;
        }
    }
}
