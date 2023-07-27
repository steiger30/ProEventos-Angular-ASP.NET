using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

  public EventoController()
  {

  }

  [HttpGet]
  public IEnumerable<Evento> Get()
  {
    return new Evento[]
    {
        new Evento(){
            EventoId = 1,
            Local = "centro",
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            Tema = "fantasia",
            QtdPessoas = 150,
            Lote = "3 lotes",
            ImagemURL = "asd"
    }
  };
  }
  [HttpPut]
  public string Put()
  {
    return "olá mundo";
  }
}
