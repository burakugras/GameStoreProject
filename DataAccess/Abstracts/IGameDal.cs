using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IGameDal
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
