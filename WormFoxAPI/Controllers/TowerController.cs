using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WormFoxAPI.Database.Services;
using WormFoxAPI.Models;

namespace WormFoxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TowerController
    {
        private readonly TowerService _towerService;

        public TowerController(TowerService towerService)
        {
            _towerService = towerService;
        }

        [HttpGet]
        public IEnumerable<Tower> GetAll()
        {
            return _towerService.GetAll();
        } 
    }
}
