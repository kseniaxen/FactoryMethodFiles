using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodFile.TypeFiles;

namespace FactoryMethodFile.Factory
{
    abstract class DocumentManager
    {
        public abstract IDocStorage CreateStorage();

    }
}
