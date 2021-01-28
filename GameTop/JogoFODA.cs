namespace GameTop
{
    public class JogoFODA
    {
        private readonly IJogador _jogador;

        public JogoFODA(IJogador jogador)
        {
            _jogador = jogador;
        }
        public void InciarJogo()
        {
            System.Console.WriteLine(_jogador.Passe());
            System.Console.WriteLine(_jogador.Corre());
            System.Console.WriteLine(_jogador.Chuta());
            System.Console.WriteLine("__##### Próximo Jogador #####__");
        }
    }
}