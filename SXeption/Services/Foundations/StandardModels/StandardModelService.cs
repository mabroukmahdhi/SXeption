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

namespace SXeption.Services.Foundations.StandardModels
{
    public class StandardModelService : IStandardModelService
    {
        public IStandardException CreateStandardException<TException>(
            string message,
            Exception innerException = null)
            where TException : Exception, IStandardException
        {

            int parametersNbr = typeof(TException)
                                    .GetConstructors()[0]
                                    .GetParameters()
                                    .Length;

            if (parametersNbr == 1)
            {
                return (TException)Activator.CreateInstance(
                    typeof(TException),
                    new object[] { message });
            }

            if (parametersNbr == 2)
            {
                return (TException)Activator.CreateInstance(
                   typeof(TException),
                   new object[] { message, innerException });
            }

            return default;
        }
    }
}
