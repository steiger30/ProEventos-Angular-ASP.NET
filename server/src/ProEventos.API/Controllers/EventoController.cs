using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
  private readonly DataContext _context;

  public EventoController(DataContext context)
  {
    this._context = context;

  }

  [HttpGet]
  public IEnumerable<Evento> Get()
  {
    return this._context.Eventos;
  }
  [HttpGet("{id}")]
  public Evento GetById(int id)
  {
    return this._context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
  }
  [HttpPut]
  public string Put()
  {
    return "olá mundo";
  }
}
