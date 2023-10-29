using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BasicTournament_System.Models;

namespace BasicTournament_System.Controllers
{
    public class CampeonatosController : Controller
    {
        public IActionResult Index()
        {
            List<Campeonato> list = new List<Campeonato>();
            list.Add(new Campeonato
            {
                Id = 1,
                Titulo = "Luta Livre",
                Imagem = "PathEmpty",
                Cidade = "Votorantim",
                Estado = "São Paulo",
                DataRealizacao = DateTime.Now,
                Dia = DateTime.Now.Day,
                Mes = DateTime.Now.Month,
                Ano = DateTime.Now.Year,
                SobreEvento = "Evento de lutas marciais",
                Ginasio = "Estádio Poliesportivo",
                InformacoesGerais = "Varias categorias",
                EntradaPublico = "Gratuita",
                Tipo = "Kimono",
                Fase = 1,
                Status = 1
            });
            list.Add(new Campeonato
            {
                Id = 2,
                Titulo = "Corrida",
                Imagem = "PathEmpty",
                Cidade = "Votorantim",
                Estado = "São Paulo",
                DataRealizacao = DateTime.Now,
                Dia = DateTime.Now.Day,
                Mes = DateTime.Now.Month,
                Ano = DateTime.Now.Year,
                SobreEvento = "Evento de corrida",
                Ginasio = "Estádio Poliesportivo",
                InformacoesGerais = "Maratona 20km",
                EntradaPublico = "Gratuita",
                Tipo = "Confortável",
                Fase = 1,
                Status = 1
            });
            return View(list);
        }
    }
}
