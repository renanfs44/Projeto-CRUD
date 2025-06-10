namespace First.Models

    // Respostas do sistema para as ações
{
    public class ServiceResponse<T>
    {
        // o ? é porque o dado pode ser nulo e o T é um tipo de genérico de parâmetro
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
