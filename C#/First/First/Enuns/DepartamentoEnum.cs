using System.Text.Json.Serialization;

namespace First.Enuns

    // Repertório de setores para utilização no cadastro de funcionários

{
    // Converte o número do departamento em texto
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
