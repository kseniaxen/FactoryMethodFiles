using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethodFile.TypeFiles
{
    class DocXDocStorage:IDocStorage
    {
        public void Save(string name, XDocument document)
        {
            Console.WriteLine("Save DocX");
        }
        public XDocument Load(string name)
        {
            Console.WriteLine("Load Docx");
            return null;
        }
        public void SaveOnAnotherName(string name, XDocument document)
        {
            Console.WriteLine("Save on another name DocX");
        }
        public void Print(string name, XDocument document)
        {
            Console.WriteLine("Print DocX");
        }
        public void Close(string name, XDocument document)
        {
            Console.WriteLine("Close DocX");
        }

    }
}
