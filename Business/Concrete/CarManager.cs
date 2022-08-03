using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.DataAccess.Utilities.Results.Abstracts;
using Core.DataAccess.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.carAddedMessage);
            }
            else
            {

                return new ErrorResult(Messages.carNameInvalid);

            }
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Car car)
        {
           _carDal.Delete(car);
            return new SuccessResult(Messages.carDeletedMessage);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour ==17)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);

            }
            return new ErrorDataResult<List<Car>>(_carDal.GetAll(), Messages.carListed);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(), Messages.carDetailsListed);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId), Messages.carListedByBrandId);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId), Messages.carListedByColorId);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.carUpdatedMessage);
        }
    }
}
