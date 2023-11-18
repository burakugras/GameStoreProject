using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGameService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
