using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yathzee
{
    class dobbelstenen
    {
        int _waarde;
      
        /*
        public dobbelstenen(int randomValue)
        {
            this._waarde = randomValue;
        }
        */

      public int waarde
        {
        get
            {
                return _waarde;
            }

            set
            {
                _waarde = value;
            }
        }

        

        public int getWaarde()
        {
            return _waarde;
        }






    }

    
}
