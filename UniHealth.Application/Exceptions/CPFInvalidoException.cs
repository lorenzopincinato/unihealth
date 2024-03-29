﻿using System;

namespace UniHealth.Application.Exceptions
{
    public class CPFInvalidoException : Exception
    {
        public CPFInvalidoException() : base("O CPF é inválido!") { }

        public CPFInvalidoException(string message) : base(message) { }
    }
}
