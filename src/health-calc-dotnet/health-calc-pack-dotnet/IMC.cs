using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Altura, double Peso)
        {
            if(ValidarDados(Altura, Peso))
            {
                throw new Exception("Dados inválidos");
            }

            return Math.Round( Peso / (Altura * Altura), 2);
        }

        public string RetornarClassificacaoIMC(double IMC)
        {
            if (IMC < 18)
               return IndiceIMC.ABAIXO_DO_PESO.Value;
            else if (IMC >= 18.5 && IMC < 25)
                return IndiceIMC.PESO_NORMAL.Value;
            else if (IMC >= 25 && IMC < 30)
                return IndiceIMC.PRE_OBESIDADE.Value;
            else if (IMC >= 30 && IMC < 35)
                return IndiceIMC.OBESIDADE_I.Value;
            else if (IMC >= 35 && IMC < 40)
                return IndiceIMC.OBESIDADE_II.Value;
            else if (IMC >= 40)
                return IndiceIMC.OBESIDADE_III.Value;
            return String.Empty;
        }

        public bool ValidarDados(double Altura, double Peso)
        {
            if(Altura <= 0 || Peso <= 0)
            {
                return true;
            }
            return false;
        }
    }
}