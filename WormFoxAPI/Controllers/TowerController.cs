using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WormFoxAPI.Database.Services;
using WormFoxAPI.Models;

namespace WormFoxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TowerController : ControllerBase
    {
        private readonly TowerService _towerService;

        public TowerController(TowerService towerService)
        {
            _towerService = towerService;
        }

        [HttpGet]
        public ActionResult<List<Tower>> GetAll()
        {
            return _towerService.GetAll();
        }

        [HttpGet("{id:length(24)}")]
        public ActionResult<Tower> GetOne(string id)
        {
            Tower tower = _towerService.GetOne(id);

            if (tower == null)
            {
                return NotFound();
            }

            return tower;
        }

        [HttpPost]
        public IActionResult Insert(Tower tower)
        {
            _towerService.Insert(tower);

            return CreatedAtRoute("tower", new { id = tower.Id.ToString(), tower });
        }
    }
}
