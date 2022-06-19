using System;

namespace FactoryCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IReader reader = factory.Secim("pdf");
            reader.read();
        }
    }

    interface IReader
    {
        void read();
        void extract();
    }
    class PdfReader : IReader
    {
        public void extract()
        {
            Console.WriteLine("pdf extract");
        }

        public void read()
        {
            Console.WriteLine("pdf read");
        }
    }
    class MsReader : IReader
    {
        public void extract()
        {
            Console.WriteLine("ms extract");
        }

        public void read()
        {
            Console.WriteLine("ms read");
        }
    }

    class Factory
    {
        public IReader Secim(string readerType)
        {
            switch (readerType)
            {
                case "pdf":
                    return new PdfReader();
                case "ms":
                    return new MsReader();
                default:
                    return null;
                    break;
            }
        }
    }
}
