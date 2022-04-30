// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class AlreadyExistsStandardModelException : Xeption
    {
        public AlreadyExistsStandardModelException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
