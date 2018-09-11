using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task
{

    abstract class AbstractHandler
    {
        protected string filename;

        protected AbstractHandler(string filename)
        {
            this.filename = filename;
        }

        public void Open()
        {
            Console.WriteLine(this.filename + " opened");
        }

        public void Create()
        {
            Console.WriteLine(this.filename + " created");
        }

        public void Change()
        {
            Console.WriteLine(this.filename + " changed");
        }
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string filename)
            : base(filename)
        {

        }
        public override void Save()
        {
            Console.WriteLine(this.filename + " saved as XML");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename)
            : base(filename)
        {

        }
        public override void Save()
        {
            Console.WriteLine(this.filename + " saved as TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {

        public DOCHandler(string filename)
            : base(filename)
        {
            
        }
        public override void Save()
        {
            Console.WriteLine(this.filename + " saved as DOC");
        }
    }

    class File
    {
        AbstractHandler handler;
        public File(string filename)
        {
            switch ((filename.Substring(filename.Length - 4)).ToLower())
            {
                case ".txt":
                    handler = new TXTHandler(filename);
                    break;
                case ".doc":
                    handler = new DOCHandler(filename);
                    break;
                case ".xml":
                    handler = new XMLHandler(filename);
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Craete()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            File file = new File("mydoc.doc");
            file.Open();
            file.Save();
        }
    }
}
