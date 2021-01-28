namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando.";           
        }

        public string Passe()
        {
           return $"{_Nome} está passando.";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo.";           
        }
    }   
}