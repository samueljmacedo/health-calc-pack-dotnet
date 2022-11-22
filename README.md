# health-calc-pack-dotnet
Projeto apresentado para disciplina de Projeto Integrado de Engenharia de Software
# Health Calc Pack

<!---Esses são exemplos. Veja https://shields.io para outras pessoas ou para personalizar este conjunto de escudos. Você pode querer incluir dependências, status do projeto e informações de licença aqui--->

![GitHub repo size](https://img.shields.io/github/repo-size/iuricode/README-template?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/iuricode/README-template?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/iuricode/README-template?style=for-the-badge)


> Este pacote oferece duas calculadoras para cálculo de IMC (Índice de Massa Corporal) e consumo diário de macronutrientes.

## 💻 Pré-requisitos

.NET CORE SDK 6.0
https://dotnet.microsoft.com/en-us/download

XUnit
https://xunit.net/

## 🚀 Instalando Health Calc Pack
Para adicionar o pacote ao seu projeto:

`dotnet add package health-calc-pack-dotnet-sjmc`

## 📄 Contéudo do pacote

### Cálculadora de Índice de Massa Corporal (IMC)
Utilizado para calcular o valor do IMC

```
var imcCalc = new IMC();
double imcResultado = imcCalc.CalcularIMC(Altura, Peso);
```

### Classificação de Índice de Massa Corporal (IMC)
Utilizado para correlacionar o valor do IMC com a respectiva classificação

```
double imc = 20;
string imcResultado = imcCalc.RetornarClassificacaoIMC(IMC);
```

Classificações:
1. Abaixo do peso
2. Peso normal
3. Pré-obesidade
4. Obesidade Grau I
5. Obesidade Grau II
6. Obesidade Grau III

### Calculadora de Macronutrientes
Utilizada para cálculo de consumo diário de macronutrientes, a depender do Gênero, Nível de atividade física, Objetivo (Bulking, Cutting, Maintenance), Altura e Peso

```
using health_calc_pack_dotnet.Enum;

var MacronutrienteObj = new Macronutriente();
var Sexo = Genero.Masculino;
var NivelAtividade = NivelAtividadeFisica.Moderadamente_Ativo;
var Objetivo = ObjetivoFisico.Bulking;
double Altura = 1.83;
double Peso = 60;

var Resultado = MacronutrienteObj.CalculoMacronutrientes(
    Sexo,
    Altura,
    Peso,
    Objetivo,
    NivelAtividade);
    
int Carboidratos = Resultado.Carboidratos;
int Proteinas = Resultado.Proteinas;
int Gorduras = Resultado.Gorduras;
```


[⬆ Voltar ao topo](#nome-do-projeto)<br>
