// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xeptions;

namespace SXeption.Models.SXeptions.Exceptions
{
    public class SXeptionServiceException : Xeption
    {
        public SXeptionServiceException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
