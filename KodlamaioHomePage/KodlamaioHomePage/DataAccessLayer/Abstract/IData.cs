using KodlamaioHomePage.Entity.Abstract;
using KodlamaioHomePage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Data_Access_Layer.Abstract
{
    public interface IData
    {
        List<IEntity> GetList();
        void Add(IEntity entity);
        void Update(int id,IEntity entity);
        void Delete(int id);
    }
}