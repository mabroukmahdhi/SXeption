﻿// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SXeption.Models.StandardModels.Exceptions;

namespace SXeption.Services.Foundations.StandardModels
{
    public interface IStandardModelService
    {
        IStandardException CreateStandardException<TException>(
             string message,
             Exception innerException = null)
            where TException : Exception, IStandardException;

    }
}
