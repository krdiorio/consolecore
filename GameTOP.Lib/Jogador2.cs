using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return $"Maradona está chutando";
        }

        public string Corre()
        {
            return $"Maradona está corriendo";
        }

        public string Passe()
        {
            return $"Maradona está passando";
        }
    }
}