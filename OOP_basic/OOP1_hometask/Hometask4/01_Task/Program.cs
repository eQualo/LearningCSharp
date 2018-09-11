using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Task
{
    abstract class DopcumentParts  
    {
        protected string content;
        abstract public string Content { get; set; }
        public abstract void Show();
    }

    class Title : DopcumentParts
    {
        public override string Content
        {
            get
            {
                if (this.content != null)
                    return this.content;
                else
                    return "No title!";
            }
            set
            {
                this.content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Body : DopcumentParts
    {
        public override string Content
        {
            get
            {
                if (this.content != null)
                    return this.content;
                else
                    return "No Body!";
            }
            set
            {
                this.content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(this.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Footer : DopcumentParts
    {
        public override string Content
        {
            get
            {
                if (this.content != null)
                    return this.content;
                else
                    return "No Footer!";
            }
            set
            {
                this.content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(this.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Document
    {
        Title title;
        Body body;
        Footer footer;

        void Initialization()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            Initialization();
            this.title.Content = title;
        }

        public string Body { set { this.body.Content = value; } }
        public string Footer { set { this.footer.Content = value; } }

        public void ShowDocument()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Title");
            document.Body = "Body";
            document.Footer = "Footer";

            document.ShowDocument();

        }
    }
}
