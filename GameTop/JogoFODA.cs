namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;


        public JogoFODA( iJogador jogadorA, iJogador jogadorB )
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {

            System.Console.Write(
                _jogadorA.Correr() + '\n' +
                _jogadorA.Passar() + '\n' +
                _jogadorA.Chutar() + '\n' +
                
                _jogadorB.Correr() + '\n' +
                _jogadorB.Passar() + '\n' +
                _jogadorB.Chutar() + '\n' 
            );

        }
    }
}