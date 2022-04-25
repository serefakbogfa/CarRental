using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Utilities.Results.Abstracts
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
