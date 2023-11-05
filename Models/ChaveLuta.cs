namespace BasicTournament_System.Models
{
    public class ChaveLuta
    {
        
        public int Id { get; set; }
        public string Faixa { get; set; }   
        public string  Peso { get; set; }
        public int CampeonatoId { get; set; }
        public int AtletaId { get; set; }
        public int Posicao { get; set; }
        public int NumberFight {  get; set; }
        public ICollection<Atleta> Atleta { get; set; } = new List<Atleta>();
        public ICollection<Campeonato> Campeonato { get; set; } = new List<Campeonato>();
        public ICollection<Resultados> Resultados { get; set; } = new List<Resultados>();

        public ChaveLuta() { }

        public ChaveLuta(int idChaveLuta, string faixa, string peso, int campeonatoId, int atletaId, int posicao)
        {
            Id = idChaveLuta;
            Faixa = faixa;
            Peso = peso;
            CampeonatoId = campeonatoId;
            AtletaId = atletaId;
            Posicao = posicao;
        }

    }
}
