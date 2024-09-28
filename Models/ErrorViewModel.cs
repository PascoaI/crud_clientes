namespace ClienteCRUD.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } = string.Empty; // Valor padrão

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}