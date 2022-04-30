// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class FailedStandardModelStorageException : Xeption
    {
        public FailedStandardModelStorageException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
