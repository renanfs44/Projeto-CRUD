using System.Text.Json.Serialization;

namespace First.Enuns

// Repertório de turnos para utilização no cadastro de funcionários

{
    // Converte o número do departamento em texto
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manhã,
        Tarde,
        Noite
    }
}
