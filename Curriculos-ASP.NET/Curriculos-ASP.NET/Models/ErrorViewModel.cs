using System;

namespace Curriculos_ASP.NET.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Erro { get; set; }

        public ErrorViewModel(string erro)
        {
            this.Erro = erro;
        }

        public ErrorViewModel()
        {
        }

    }
}
