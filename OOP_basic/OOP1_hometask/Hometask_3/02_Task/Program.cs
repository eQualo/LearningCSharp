using System;

namespace _02_Task
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохраненеие документа доступно в версии Про");
        }
    }

    class ProdocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProdocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int serialNumber = 0;
            const int pro = 1;
            const int exp = 2;
            Console.WriteLine("Input serial number");
            try { serialNumber = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception) { Console.WriteLine("Exception. Input number"); Console.ReadKey();  return; }

            switch (serialNumber)
            {
                case pro:
                    ProdocumentWorker prodocumentWorker = new ProdocumentWorker();
                    prodocumentWorker.OpenDocument();
                    prodocumentWorker.EditDocument();
                    prodocumentWorker.SaveDocument();
                    break;
                case exp:
                    ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    expertDocumentWorker.OpenDocument();
                    expertDocumentWorker.EditDocument();
                    expertDocumentWorker.SaveDocument();
                    break;
                default:
                    DocumentWorker documentWorker = new DocumentWorker();
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                    break;
            }

            Console.ReadKey();
            
        }
    }
}
