// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class AlreadyExistsStandardModelException : Xeption, IStandardException
    {
        public AlreadyExistsStandardModelException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
