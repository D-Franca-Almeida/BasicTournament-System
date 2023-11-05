using Microsoft.EntityFrameworkCore;

namespace BasicTournament_System.Models
{
    
    public class Resultados
    {
   
            public int Id { get; set; }
            public int CampeonatoNumber{ get; set; }
            public string? Faixa { get; set; }
            public string? Peso { get; set; }
            public ICollection<Atleta> Atleta { get; set; } = new List<Atleta>();
            public ICollection<ChaveLuta> ChaveLutas { get; set; } = new List<ChaveLuta>();
            public ICollection<Campeonato> Campeonatos { get; set; } = new List<Campeonato>();
            

            public Resultados() { }

            public Resultados(int id, int campeonatoId, string? faixa, string? peso)
            {
                Id = id;
                CampeonatoNumber = campeonatoId;
                Faixa = faixa;
                Peso = peso;              
            }
            public void LutaAtleta(Atleta atleta)
            {
                Atleta.Add(atleta);
            }
            public void RemoveAtleta(Atleta atleta)
            {
                Atleta.Remove(atleta);
            }

            public void LutaChaveLuta(ChaveLuta chave)
            {
                ChaveLutas.Add(chave);
            }
            public void RemoveChaveLuta(ChaveLuta chave)
            {
                ChaveLutas.Remove(chave);
            }

        
    }
}
