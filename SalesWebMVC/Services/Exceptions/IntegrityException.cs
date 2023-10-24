using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)   //Exceção personalizada de serviços para erros de integridade referencial
        {
            //Repassa a chamada da exceção para a superclasse
        }
    }
}