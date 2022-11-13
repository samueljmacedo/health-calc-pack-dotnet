using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet
{
    public class Macronutriente : IMacronutriente
    {
        const int PROTEINA = 2;
        const int GORDURA_BULKING = 2;
        const int GORDURA = 1;
        const int CARBOIDRATO_BULKING_T1 = 4;
        const int CARBOIDRATO_BULKING_T2 = 7;
        const int CARBOIDRATO_CUTTING = 2;
        const int CARBOIDRATO_MAINTENANCE = 5;
        const int PESO_MINIMO = 35;

        public MacronutrienteModel CalculoMacronutrientes(
            Genero genero,
            double Altura,
            double Peso,
            ObjetivoFisico Objetivo,
            NivelAtividadeFisica Nivel)
        {
            int Proteinas = 0;
            int Carboidratos = 0;
            int Gorduras = 0;

            if (ValidarDados(Peso))
            {
                throw new Exception("Peso inválido");
            }

            if(Objetivo == ObjetivoFisico.Cutting)
            {
                Proteinas = PROTEINA * (int)Peso;
                Carboidratos = CARBOIDRATO_CUTTING * (int)Peso;
                Gorduras = GORDURA * (int)Peso;
            }
            else if (Objetivo == ObjetivoFisico.Bulking)
            {
                Proteinas = PROTEINA * (int)Peso;
                Carboidratos = CARBOIDRATO_BULKING_T1 * (int)Peso;
                Gorduras = GORDURA_BULKING * (int)Peso;

                if(NivelAtividadeFisica.Bastante_Ativo == Nivel ||
                    NivelAtividadeFisica.Extremamente_Ativo == Nivel)
                {
                    Carboidratos = CARBOIDRATO_BULKING_T2 * (int)Peso;
                }
            }
            else if (Objetivo == ObjetivoFisico.Maintenance)
            {
                Proteinas = PROTEINA * (int)Peso;
                Carboidratos = CARBOIDRATO_MAINTENANCE * (int)Peso;
                Gorduras = GORDURA * (int)Peso;
            }

            MacronutrienteModel macronutriente = new MacronutrienteModel()
            {
                Carboidratos = Carboidratos,
                Gorduras = Gorduras,
                Proteinas = Proteinas
            };

            return macronutriente;
        }

        public bool ValidarDados(double Peso)
        {
            if(Peso <= PESO_MINIMO)
            {
                return true;
            }
            return false;
        }
    }
}
