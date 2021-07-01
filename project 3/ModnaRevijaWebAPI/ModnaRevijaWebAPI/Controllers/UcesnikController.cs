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
    public class UcesnikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiUcesnike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUcesnici()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveUcesnike());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiModneKreatore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetModniKreator()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveModneKreatore());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiModneKreatoreRevija/{modnarevijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetModniKreatoriRevije(int modnarevijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveKreatoreSaRevijama(modnarevijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("PoveziKreatora/{modnikreatorID}/{modnarevijaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LinkKreator(int modnikreatorID, int modnarevijaID)
        {
            try
            {
                var kreator = DataProvider.VratiModnogKreatora(modnikreatorID);
                var revija = DataProvider.VratiModnuReviju(modnarevijaID);
                var povezi = new PredstavljaView { Prezentuje = revija, Kreator = kreator };
                DataProvider.DodajPredstavljanje(povezi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    /*    [HttpPost]
        [Route("DodajKreatora/{modnarevijaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddKreatorToRevija(int modnarevijaID, [FromBody] ModniKreatorView mk)
        {
            try
            {
                var id = DataProvider.DodajModnogKreatora(mk);
                var kreator = DataProvider.VratiModnogKreatora(id);
                var revija = DataProvider.VratiModnuReviju(modnarevijaID);
                var povezi = new PredstavljaView { Prezentuje = revija, Kreator = kreator };
                DataProvider.DodajPredstavljanje(povezi);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    */
        [HttpGet]
        [Route("PreuzmiManekene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetManeken()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveManekene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajModnogKreatora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddModniKreator([FromBody] ModniKreatorView mk)
        {
            try
            {
                DataProvider.DodajModnogKreatora(mk);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajManekena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddManeken([FromBody] ManekenView m)
        {
            try
            {
                DataProvider.DodajManekena(m);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniModnogKreatora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeModniKreator([FromBody] ModniKreatorView mk)
        {
            try
            {
                DataProvider.AzurirajModnogKreatora(mk);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniManekena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeManeken([FromBody] ManekenView m)
        {
            try
            {
                DataProvider.AzurirajManekena(m);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiUcesnika/{matBr}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteUcesnik(int matBr)
        {
            try
            {
                DataProvider.ObrisiUcesnika(matBr);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}