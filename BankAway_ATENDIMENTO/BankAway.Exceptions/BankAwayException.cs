using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAway_ATENDIMENTO.BankAway.Exceptions
{

    [Serializable]
    public class BankAwayException : Exception
    {
        public BankAwayException() { }
        public BankAwayException(string message) : base("Aconteceu uma Exceção -> "+ message) { }
        public BankAwayException(string message, Exception inner) : base(message, inner) { }
        protected BankAwayException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
