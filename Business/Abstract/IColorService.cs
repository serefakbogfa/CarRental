using Core.DataAccess.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll(Color color);      
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
