using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodFile.TypeFiles;
using FactoryMethodFile.Factory;
using System.Xml.Linq;

namespace FactoryMethodFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager docManager = new DocumentGeneric<DocXDocStorage>();
            IDocStorage storage = docManager.CreateStorage();
            storage.Load("asd.docx");
            storage.Print("asd.docx", new XDocument());

            docManager = new DocumentGeneric<EpubDocStorage>();
            storage = docManager.CreateStorage();
            storage.Save("qwert.epub", new XDocument());

            docManager = new DocumentGeneric<HtmlDocStorage>();
            storage = docManager.CreateStorage();
            storage.Close("qwert.html", new XDocument());
            
            Console.ReadLine();
        }
    }
}
