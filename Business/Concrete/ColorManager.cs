using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.DataAccess.Utilities.Results.Abstracts;
using Core.DataAccess.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorService _colorservice;

        public ColorManager(IColorService colorservice)
        {
            _colorservice = colorservice;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _colorservice.Add(color);
            return new SuccessResult(Messages.ColorAdded);

        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Delete(Color color)
        {
            _colorservice.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }
        //[ValidationAspect(typeof(ColorValidator))]
        //public IDataResult<List<Color>> GetAll()
        //{
        //    return new SuccessDataResult<List<Color>>(_colorservice.GetAll(color), Messages.colorListed);
        //}

        public IDataResult<List<Color>> GetAll(Color color)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color color)
        {
            _colorservice.Update(color);
            return new SuccessResult(Messages.colorUpdatedMessage);
        }
    }
}
