using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
public class Operation
    { 

        public string Leftside { get; set; }

        public string Rightside { get; set; }

        public OperationType OperationType { get; set; }    

        #region  Constructor
        public Operation()
        {
            //setting default values empty instead of null
            this.Rightside = string.Empty;
            this.Leftside = string.Empty;


        }
        #endregion
    }
}
