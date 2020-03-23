using System;

namespace SalesWebMVC.Models.ViewModels
{
    //Não é um model nem uma entidade do negocio
    //É apenas um modelo auxiliar para popular as telas
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}