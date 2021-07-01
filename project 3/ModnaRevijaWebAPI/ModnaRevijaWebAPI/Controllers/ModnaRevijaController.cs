using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModnaRevijaLibrary;
using ModnaRevijaLibrary.DTOs;
using ModnaRevijaLibrary.Enitites;

namespace ModnaRevijaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModnaRevijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiModneRevije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetModneRevije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveModneRevije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajModnuReviju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AdModnaRevija([FromBody] ModnaRevijaView mr)
        {
            try
            {
                DataProvider.DodajModnuReviju(mr);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniModnuReviju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeModnaRebvija([FromBody] ModnaRevijaView mr)
        {
            try
            {
                DataProvider.AzurirajModnuReviju(mr);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiModnuReviju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteModnaRevija(int id)
        {
            try
            {
                DataProvider.ObrisiModnuReviju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGoste/{modnarevijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGosti(int modnarevijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSpecGosteSaRevijom(modnarevijaID));
            }
            catch (Exception ex)
            {   
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajGostaSaRevijom/{modnarevijaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddGostWithRevijom([FromRoute(Name = "modnarevijaID")] int modnarevijaID, [FromBody] SpecGostView o)
        {
            try
            {
                var revija = DataProvider.VratiModnuReviju(modnarevijaID);
                o.Gostuje = revija;
                DataProvider.DodajSpecGosta(o);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniGosta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeGosta([FromBody] SpecGostView o)
        {
            try
            {
                DataProvider.AzurirajSpecGosta(o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiGosta/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteGost(int id)
        {
            try
            {
                DataProvider.ObrisiSpecGosta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
