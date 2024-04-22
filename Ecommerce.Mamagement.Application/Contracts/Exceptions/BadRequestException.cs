﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;


namespace Ecommerce.Management.Application.Contracts.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        { 

        }
        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = validationResult.ToDictionary();
        }

        public IDictionary<string, string[]> ValidationErrors { get; set; }


    }
}
