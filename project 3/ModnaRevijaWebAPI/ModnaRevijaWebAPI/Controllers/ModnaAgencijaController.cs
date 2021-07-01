using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModnaRevijaLibrary;
using ModnaRevijaLibrary.DTOs;

namespace ModnaRevijaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModnaAgencijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiModneAgencije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetModneAgencije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveModneAgencije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajInternacionalnu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddInternacionalna([FromBody] InternacionalnaView i)
        {
            try
            {
                DataProvider.DodajInternacionalnu(i);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniInternacionalnu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeInternacionalna([FromBody] InternacionalnaView i)
        {
            try
            {
                DataProvider.AzurirajInternacionalnu(i);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiModnuAgenciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteModnaAgencija(int id)
        {
            try
            {
                DataProvider.ObrisiModnuAgenciju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
