using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.DataAccess.Utilities.Results.Abstracts;
using Core.DataAccess.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.rentalAddedMessage);
        }

       
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.rentalDeletedMessage);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.rentalListed);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<Rental> GetByCarId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == id), Messages.rentalGetById);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id == id),Messages.rentalGetById);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.rentalDeletedMessage);
        }
    }
}
