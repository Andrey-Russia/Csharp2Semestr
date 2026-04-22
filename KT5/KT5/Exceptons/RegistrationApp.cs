using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5.Exceptons
{
    internal class EmptyNameException : Exception
    {
        public EmptyNameException() : base("Имя не может быть пустым.") { }
    }
}
