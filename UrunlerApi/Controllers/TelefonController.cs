using Bl;
using Data;
using Dl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrunlerApi.Controllers
{
    [Route("urunler")]
    [ApiController]
    public class TelefonController : ControllerBase
    {
        static TelefonManager telefonManager = new TelefonManager();
        public TelefonController()
        {
        }
        [HttpGet]
        public IActionResult GetTelefon()
        {
            var data = telefonManager.GetList();
            return Ok(data);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            var data = telefonManager.Get(id);
            return Ok(data);
        }
        [HttpDelete("DeleteTelefon")]
        public IActionResult DeleteTelefon(Telefon telefon)
        {
            telefonManager.Delete(telefon);

            return Ok("Silme İşleminiz Başarılı!");
        }

        [HttpPost("AddTelefon")]
        public IActionResult AddTelefon(Telefon telefon)
        {
            telefonManager.Add(telefon);
            return Ok("Ekleme İşleminiz Başarılı!");
        }
        [HttpPut("UpdateTelefon")]
        public IActionResult UpdateTelefon(Telefon telefon)
        {
            telefonManager.Update(telefon);
            return Ok("Güncelleme İşleminiz Başarılı");
        }

    }
}

