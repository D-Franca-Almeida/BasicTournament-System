namespace BasicTournament_System.Models
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; } // Masculino ou Feminino
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Equipe { get; set; }
        public string Faixa { get; set; } // Marrom ou Preta
        public string Peso { get; set; } // Leve ou Pesado
        public DateTime DataInscricao { get; set; }
        public ICollection<Campeonato> Campeonato { get; set; } = new List<Campeonato>();
        public ICollection<Resultados> Resultados { get; set; } = new List<Resultados>();
        
        public Atleta()
        {

        }

        public Atleta(int id, string nome, DateTime dataNascimento, string cPF, string sexo, string email, string senha, string equipe, string faixa, string peso, DateTime dataInscricao)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cPF;
            Sexo = sexo;
            Email = email;
            Senha = senha;
            Equipe = equipe;
            Faixa = faixa;
            Peso = peso;
            DataInscricao = dataInscricao;
        }
    }
}
