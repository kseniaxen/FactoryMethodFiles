using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodFile.TypeFiles;

namespace FactoryMethodFile.Factory
{
    class DocumentGeneric<T>
      : DocumentManager
      where T : IDocStorage, new()
    {
        public override IDocStorage CreateStorage()
        {
            IDocStorage storage = new T();
            //do something else...
            return storage;
        }
    }
}
