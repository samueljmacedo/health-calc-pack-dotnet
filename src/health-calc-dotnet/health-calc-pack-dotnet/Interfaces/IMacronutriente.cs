using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    internal interface IMacronutriente
    {
        MacronutrienteModel CalculoMacronutrientes(
            Genero genero,
            double Altura,
            double Peso,
            ObjetivoFisico Objetivo,
            NivelAtividadeFisica Nivel);

        bool ValidarDados(double Peso);
    }
}
