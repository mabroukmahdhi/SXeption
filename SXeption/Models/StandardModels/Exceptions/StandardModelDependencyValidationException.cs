// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class StandardModelDependencyValidationException : Xeption
    {
        public StandardModelDependencyValidationException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
