using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency.Models
{
    public class Currency
    {
        public float dollar;
        public float rate;
        public object vnd;

        public Currency(float dollar, float rate)
        {
            this.dollar = dollar;
            this.rate = rate;
        }
        
        public void transfer()
        {
            vnd = rate * dollar;
        }
    }
}
