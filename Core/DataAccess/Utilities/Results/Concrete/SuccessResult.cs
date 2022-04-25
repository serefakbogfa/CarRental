using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(String message) : base(true, message)
        { 
        
        }
        public SuccessResult() : base(true) 
        {
        }
    }
}
