using System;

namespace SalesWebMVC.Models.ViewModels
{
    //N�o � um model nem uma entidade do negocio
    //� apenas um modelo auxiliar para popular as telas
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}