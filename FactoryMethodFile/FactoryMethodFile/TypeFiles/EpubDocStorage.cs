using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethodFile.TypeFiles
{
    class EpubDocStorage : IDocStorage
    {
        public void Save(string name, XDocument document)
        {
            Console.WriteLine("Save Epub");
        }
        public XDocument Load(string name)
        {
            Console.WriteLine("Load Epub");
            return null;
        }
        public void SaveOnAnotherName(string name, XDocument document)
        {
            Console.WriteLine("Save on another name Epub");
        }
        public void Print(string name, XDocument document)
        {
            Console.WriteLine("Print Epub");
        }
        public void Close(string name, XDocument document)
        {
            Console.WriteLine("Close Epub");
        }
    }
}
