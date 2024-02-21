using KodlamaioHomePage.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Abstract
{
    public interface IEntityService
    {
        List<IEntity> GetList();
        bool Add(IEntity entity);
        bool Update(int id, IEntity entity);
        bool Delete(int id);
    }
}
