using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class EventoController : ControllerBase
    {
        
       

        public IEnumerable<Evento> _evento = new Evento []
        {
            new Evento (){
                EventoId =1,
                Tema = "Angular 14 - Nova Versão",
                Local = "Auditório Cast",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            },
            new Evento (){
                EventoId = 2,
                Tema = "NodeJs",
                Local = "Auditório Cast",
                Lote = "1º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            }
        };
         public EventoController()
        {
            
        }

        [HttpGet] 
        public IEnumerable<Evento> Get(){ 
        return _evento; 
        } 

        [HttpPost] 
        public string Post(){ 
        return "Exemplo Post"; 
        } 

        [HttpDelete] 
        public string Delete(){ 
        return "Exemplo Delete"; 
        } 

        [HttpPut("{id}")] 
        public string Put(){ 
        return "Exemplo Put"; 
        } 


    }

}
