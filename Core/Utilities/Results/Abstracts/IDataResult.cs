using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Utilities.Results.Abstracts
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
