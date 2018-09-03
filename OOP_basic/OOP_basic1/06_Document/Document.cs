using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Document.Parts;

namespace _06_Document
{
    class Document
    {
        Title title;
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
        }
    }
}
