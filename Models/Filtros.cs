using System.Collections.Generic;
using System.Globalization;
using BasicTournament_System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace BasicTournament_System.Models
{
    public class Filtros
    {
        public Filtros() { }

        public List<string> Cidade()
        {
            List<string> campos = new List<string>(); // Lista para armazenar nomes de campeonatos
   
            List<Campeonato> campeonatos = new List<Campeonato>();

            //Para filtrar campeonatos com Status ativo e Select para projetar 
            campos = campeonatos
                .Where(c => c.Status == 1) // Filtre com base no status "Ativo"
                .Select(c => c.Cidade) // Projete os nomes das Cidades
                .ToList();

            return campos;
        }
        public List<string> Estado()
        {
            List<string> campos = new List<string>(); // Lista para armazenar nomes de Estados

            // Suponha que você tenha uma lista de campeonatos chamada 'campeonatos'
            List<Campeonato> campeonatos = new List<Campeonato>();

            //Where filtrar campeonatos com Status ativo e Select para projetar os nomes
            campos = campeonatos
                .Where(c => c.Status == 1) // Filtre com base no status "Ativo=1"
                .Select(c => c.Estado) // Projete os nomes dos Estados
                .ToList();

            return campos;
        }
        public List<string> NomeEvento()
        {
            List<string> campos = new List<string>(); // Lista para armazenar nomes de Estados

            // Suponha que você tenha uma lista de campeonatos chamada 'campeonatos'
            List<Campeonato> campeonatos = new List<Campeonato>();

            //Where filtrar campeonatos com Status ativo e Select para projetar os nomes
            campos = campeonatos
                .Where(c => c.Status == 1) // Filtre com base no status "Ativo=1"
                .Select(c => c.Titulo) // Projete os nomes dos Títulos
                .ToList();

            return campos;
        }
    }
}
