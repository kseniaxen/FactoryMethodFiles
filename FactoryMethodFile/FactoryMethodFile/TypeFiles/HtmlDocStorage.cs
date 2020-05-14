﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethodFile.TypeFiles
{
    class HtmlDocStorage : IDocStorage
    {
        public void Save(string name, XDocument document)
        {
            Console.WriteLine("Save Html");
        }
        public XDocument Load(string name)
        {
            Console.WriteLine("Load Html");
            return null;
        }
        public void SaveOnAnotherName(string name, XDocument document)
        {
            Console.WriteLine("Save on another name Html");
        }
        public void Print(string name, XDocument document)
        {
            Console.WriteLine("Print Html");
        }
        public void Close(string name, XDocument document)
        {
            Console.WriteLine("Close Html");
        }
    }
}
