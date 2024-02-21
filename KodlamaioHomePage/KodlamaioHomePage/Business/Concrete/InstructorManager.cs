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
    public class InstructorManager : IEntityService
    {
        IData _instructorDal;
        public InstructorManager(IData instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public bool Add(IEntity instructor)
        {
            _instructorDal.Add(instructor);
            return true;
        }

        public bool Delete(int id)
        {
            _instructorDal.Delete(id);
            return true;
        }

        public List<IEntity> GetList()
        {
            return _instructorDal.GetList();
        }

        public bool Update(int id, IEntity instructor)
        {
            _instructorDal.Update(id, instructor);
            return true;
        }
    }
}
