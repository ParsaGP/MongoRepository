using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbRepository
{
    public interface IMongoRepository<T, TKey> where T: class
    {
        T Find(TKey Id);
    }
}
