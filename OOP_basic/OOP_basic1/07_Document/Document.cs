using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_Document.Parts;

namespace _07_Document
{
    class Document
    {
        /*Title title;
        Body body;
        Footer footer;

        private void InitializeDocument()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }

        public Document(Title title, Body body, Footer footer)
        {
            InitializeDocument();
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }*/

        Title title = null;
        Body body = null;
        Footer footer = null;

        private void InitializeDocument()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        //public string Title
        //{
        //    set
        //    {
        //        title.Content = value;
        //    }
        //}

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

    }
}
