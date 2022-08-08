using EF_Core_Code_First.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_Core_Code_First.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private readonly DB_Context _context;
        public UserController(DB_Context context)
        {
            this._context = context;

            var org = new Org();
            org.OrgName = "Test Org";
            org.IsActive = true;
            org.Address = "Test Address";

            

            _context.Orgs.Add(org);

            _context.SaveChanges();

            _context.Entry(org).State = EntityState.Detached;


            //var usertype= 


        }



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


    }
}
