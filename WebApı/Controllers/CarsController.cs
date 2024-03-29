﻿using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]

        public IActionResult Get() 
        {
        var result = _carService.GetAll();
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("brandId")]
        public IActionResult GetCarsByBrandId(int id) 
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
          }
        [HttpGet("colorId")]
        public IActionResult GetCarsByColorId(int id) 
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("details")]
        public IActionResult GetCarDetails() 
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car) 
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }

    }
}

