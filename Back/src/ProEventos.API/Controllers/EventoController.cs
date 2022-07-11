using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;


namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    private readonly DataContext _context;

    public EventoController(DataContext context)
    {
      _context = context;
    }

    [HttpGet] //Retorna todos os eventos
    public IEnumerable<Evento> Get()
    {
      return _context.Eventos;

    }
    [HttpGet("{id}")]//Retorna só o ID que eu quero 
    public Evento Get(int id)
    {
      return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
