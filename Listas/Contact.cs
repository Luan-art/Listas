using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listass
{
    internal class Contact
    {
        string name;
        string telefone;
        Contact next;

        public Contact(string name, string telefone)
        {
            this.name = name;
            this.telefone = telefone;
        }

        public string getNome()
        {
            return this.name;
        }

        public void setNext(Contact next) {
            
            this.next = next;
        }

        public Contact getNext()
        {
            return next;
        }
    }
}
