using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[]{new()
                {
                    EventoId = 1,
                    Tema = "Blockchain.Rio",
                    Local = "Rio de Janeiro",
                    Lote = "Primero Lote",
                    QtdPessoas = 1500,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                    ImageUrl = "Cover.png"
                },
                new()
                {
                    EventoId = 2,
                    Tema = "Rio 2C",
                    Local = "Rio de Janeiro",
                    Lote = "Terceiro Lote",
                    QtdPessoas = 2600,
                    DataEvento = DateTime.Now.AddDays(17).ToString("dd/mm/yyyy"),
                    ImageUrl = "CoverMKT.png"
                }};

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put do id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete do id = {id}";
        }
    }
}
