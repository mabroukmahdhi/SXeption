// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
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
