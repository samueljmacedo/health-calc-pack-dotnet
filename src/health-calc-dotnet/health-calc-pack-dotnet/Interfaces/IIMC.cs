using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    internal interface IIMC
    {
        double CalcularIMC(double Altura, double Peso);

        String RetornarClassificacaoIMC(double IMC);

        bool ValidarDados(double Altura, double Peso);
    }
}
