using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethodFile.TypeFiles
{
    interface IDocStorage
    {
        void Save(string name, XDocument document);
        XDocument Load(string name);
        void SaveOnAnotherName(string name, XDocument document);
        void Print(string name, XDocument document);
        void Close(string name, XDocument document);
    }
}
