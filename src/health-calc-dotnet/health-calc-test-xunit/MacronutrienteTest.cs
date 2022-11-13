using health_calc_pack_dotnet.Models;
using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enum;

namespace health_calc_test_xunit
{
    public class MacronutrienteTest
    {
        [Fact]
        public void testarMacronutrientesComDadosValidos()
        {
            var MacronutrienteObj = new Macronutriente();
            var Sexo = Genero.Masculino;
            var Height = 1.68;
            var Weight = 85;
            var NivelAtividade = NivelAtividadeFisica.Sedentario;
            var Objetivo = ObjetivoFisico.Cutting;
            var Expected = new MacronutrienteModel()
            {
                Carboidratos = 0,
                Proteinas = 0,
                Gorduras = 0
            };
            //Act
            var Result = MacronutrienteObj.CalculoMacronutrientes(
                Sexo,
                Height,
                Weight,
                Objetivo,
                NivelAtividade);

            //Assert
            Assert.Equal(Expected.Carboidratos, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);
        }
    }
}
