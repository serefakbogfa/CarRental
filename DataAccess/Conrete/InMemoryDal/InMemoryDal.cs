using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conrete.InMemoryDal
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryDal(List<Car> cars)
        {
            _cars = cars;
            {
                new Car { Id = 1, ColorId = 1, BrandId = 1, ModelYear = 98, DailyPrice = 20000, Description = "Beatiful perfect car" };
                new Car { Id = 2, ColorId = 1, BrandId = 2, ModelYear = 2010, DailyPrice = 60000, Description = "Beatiful perfect car color" };
                new Car { Id = 3, ColorId = 2, BrandId = 2, ModelYear = 2009, DailyPrice = 80000, Description = "Beatiful perfect car color" };
        };
        }

        public void Add(Car car)
        {
            
           _cars.Add(car);
          
            }

        public void delete(Car car)
            {
                 Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
            
            }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
            {
            return _cars;
            }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetByld(int id)
            {
            return _cars.Where(c => c.Id == c.Id).First();

             }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
            {
                Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }
    }

