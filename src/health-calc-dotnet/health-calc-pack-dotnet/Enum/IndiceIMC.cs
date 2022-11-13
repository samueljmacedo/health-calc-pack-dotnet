using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Enum
{
    internal class IndiceIMC
    {
        private IndiceIMC(string value) { Value = value; }

        public string Value { get; private set; }

        public static IndiceIMC ABAIXO_DO_PESO { get { return new IndiceIMC("Abaixo do peso"); } }
        public static IndiceIMC PESO_NORMAL { get { return new IndiceIMC("Peso normal"); } }
        public static IndiceIMC PRE_OBESIDADE { get { return new IndiceIMC("Pré-obesidade"); } }
        public static IndiceIMC OBESIDADE_I { get { return new IndiceIMC("Obesidade Grau I"); } }
        public static IndiceIMC OBESIDADE_II { get { return new IndiceIMC("Obesidade Grau II"); } }
        public static IndiceIMC OBESIDADE_III { get { return new IndiceIMC("Obesidade Grau III"); } }

    }
}
