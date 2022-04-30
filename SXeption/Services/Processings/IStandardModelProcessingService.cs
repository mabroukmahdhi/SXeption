// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using SXeption.Models.StandardModels.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXeption.Services.Processings
{
    public interface IStandardModelProcessingService
    {
        IStandardException CreateStandardException<TException>(
               string messageKey,
               Exception innerException = null)
              where TException : Exception, IStandardException;
    }
}
