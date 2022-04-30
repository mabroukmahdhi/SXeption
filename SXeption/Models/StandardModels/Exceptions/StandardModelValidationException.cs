// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class StandardModelValidationException : Xeption
    {
        public StandardModelValidationException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
