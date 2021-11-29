using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaireCli
{
    internal class Client:Listclient
    {
        private string choose;
        private string textnom;
        private string textprnm;
        private string textadrss;
        private long textnum;
        private string textem;

        public string Choose { get => choose; set => choose = value; }
        public string Textnom { get => textnom; set => textnom = value; }
        public string Textprnm { get => textprnm; set => textprnm = value; }
        public string Textadrss { get => textadrss; set => textadrss = value; }
        public long Textnum { get => textnum; set => textnum = value; }
        public string Textem { get => textem; set => textem = value; }
        public Client(){ }
        public Client(string choose, string textnom, string textprnm, string textadrss,long textnum, string textem)
        {
            this.choose = choose;
            this.textnom = textnom;
            this.textprnm = textprnm;
            this.textadrss = textadrss;
            this.textnum = textnum;
            this.textem = textem;
        }
        public bool ajoutcle(Client cl)
        {
            listcl.Add(cl);
            return true;
        }

    }
}
