using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dtos;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private IAppRepository _appRepository;

        public CitiesController (IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }


        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities()
                .Select(c=> new CityForListDto { Description = c.Description, Name = c.Name ,Id=c.Id,PhotoUrl=c.Photos.FirstOrDefault(p=>p.IsMain==true).Url}).ToList();
            return Ok(cities);
        }


    }
}
