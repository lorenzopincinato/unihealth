﻿using System;

namespace UniHealth.Application.Exceptions
{
    public class RGInvalidoException : Exception
    {
        public RGInvalidoException() : base("O RG é inválido!") { }

        public RGInvalidoException(string message) : base(message) { }
    }
}
