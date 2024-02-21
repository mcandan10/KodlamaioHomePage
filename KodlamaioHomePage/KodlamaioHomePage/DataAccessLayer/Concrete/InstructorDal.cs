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
    public class InstructorDal:IData
    {
        List<IEntity> instructors;
        public InstructorDal()
        {
            instructors = new List<IEntity>
            {
                new Instructor{Id=1,FirstName="Engin",LastName="DEMİROĞ"},
                new Instructor{Id=2,FirstName="Halit Enes",LastName="KALAYCI"}
            };
        }

        public void Add(IEntity entity)
        {
            instructors.Add(entity);
        }

        public void Delete(int id)
        {
            instructors.RemoveAt(id - 1);
        }

        public List<IEntity> GetList()
        {
            return instructors;
        }

        public void Update(int id, IEntity entity)
        {
            foreach (Instructor instructor in instructors)
            {
                if (instructor.Id == id)
                {
                    instructors.RemoveAt(id - 1);
                    instructors.Add(entity);
                    break;
                }
            }
        }
    }
}
