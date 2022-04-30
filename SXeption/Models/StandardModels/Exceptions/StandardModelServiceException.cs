﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class StandardModelServiceException : Xeption
    {
        public StandardModelServiceException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
