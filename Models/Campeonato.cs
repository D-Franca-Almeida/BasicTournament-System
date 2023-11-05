namespace BasicTournament_System.Models
{
    public class Campeonato
    {
     
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataRealizacao { get; set; }
        public int Dia {  get; set; }
        public int Mes {  get; set; }
        public int Ano { get; set; }
        public string SobreEvento { get; set; }
        public string Ginasio { get; set; }
        public string InformacoesGerais { get; set; }
        public string EntradaPublico { get; set; }
        public string Tipo { get; set; } // Kimono ou No-GI
        public int Fase { get; set; } // Inscrições Abertas(1), Chaves de Lutas(2), Resultados(3)
        public int Status { get; set; } // Ativo(1) ou Inativo(0)   
        public ICollection<Atleta> Atletas { get; set; } = new List<Atleta>();
        public ICollection<Resultados> Resultados { get; set; } = new List<Resultados>();

        public Campeonato() { }

        public Campeonato(int id, string titulo, string imagem, string cidade, string estado, DateTime dataRealizacao, int dia, int mes, int ano, string sobreEvento, string ginasio, string informacoesGerais, string entradaPublico, string tipo, int fase, int status)
        {
            Id = id;
            Titulo = titulo;
            Imagem = imagem;
            Cidade = cidade;
            Estado = estado;
            DataRealizacao = dataRealizacao;
            Dia = dia;
            Mes = mes;
            Ano = ano;
            SobreEvento = sobreEvento;
            Ginasio = ginasio;
            InformacoesGerais = informacoesGerais;
            EntradaPublico = entradaPublico;
            Tipo = tipo;
            Fase = fase;
            Status = status;
        }
    }
}
