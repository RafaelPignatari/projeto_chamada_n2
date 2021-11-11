using System;

namespace ProjetoN2.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; set; }
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
