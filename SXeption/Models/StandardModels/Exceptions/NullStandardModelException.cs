// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Xeptions;

namespace SXeption.Models.StandardModels.Exceptions
{
    public class NullStandardModelException : Xeption, IStandardException
    {
        public NullStandardModelException(string message)
            : base(message)
        { }
    }
}
