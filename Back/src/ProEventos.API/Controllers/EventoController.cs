using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    public IEnumerable<Evento> eventos = new Evento[]
      {
        new Evento()
        {
          EventoId = 1,
          Tema = "Curso Angular",
          Local = "São Paulo",
          Lote = "1 lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
          ImagemURL = "foto.png"
        },
        new Evento()
        {
          EventoId = 2,
          Tema = "Curso",
          Local = "São Paulo",
          Lote = "2 lote",
          QtdPessoas = 255,
          DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
          ImagemURL = "foto1.png"
        }

      };

    public EventoController()
    {
    }

    [HttpGet] //Retorna todos os eventos
    public IEnumerable<Evento> Get()
    {
      return eventos;

    }
    [HttpGet("{id}")]//Retorna só o ID que eu quero 
    public IEnumerable<Evento> Get(int id)
    {
      return eventos.Where(evento => evento.EventoId == id);
    }


    [HttpPost]
    public string Post()
    {
      return "value";
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"value om o valor do = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"value com o valor do = {id}";
    }

  }
}
