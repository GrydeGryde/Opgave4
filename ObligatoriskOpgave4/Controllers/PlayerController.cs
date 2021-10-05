using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave4.Manager;
using opgave1;

namespace ObligatoriskOpgave4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {

        private readonly PlayerManager _manager = new PlayerManager();

        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> Get(int id)
        {
            FootballPlayer player = _manager.GetById(id);
            return player;

        }

        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            _manager.Add(value);
            return value;
        }

        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _manager.Update(id, value);
        }

        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
