// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using SXeption.Models.StandardModels.Exceptions;
using SXeption.Models.SXeptions.Exceptions;
using SXeption.Services.Foundations.Localizations;
using SXeption.Services.Foundations.StandardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXeption.Services.Processings
{
    public class StandardModelProcessingService : IStandardModelProcessingService
    {
        private delegate IStandardException CreateExceptionFunction();
        private readonly ILocalizationService localizationService;
        private readonly IStandardModelService standardModelService;

        public StandardModelProcessingService(
            ILocalizationService localizationService,
            IStandardModelService standardModelService)
        {
            this.localizationService = localizationService;
            this.standardModelService = standardModelService;
        }

        public IStandardException CreateStandardException<TException>(
            string sxeptionServiceException, Exception innerException = null)
            where TException : Exception, IStandardException
            => TryCatch(() => this.standardModelService.CreateStandardException<TException>(
                message: this.localizationService.GetLocalizedText(sxeptionServiceException),
                innerException: innerException));


        private IStandardException TryCatch(CreateExceptionFunction createExceptionFunction)
        {
            try
            {
                return createExceptionFunction();
            }
            catch (Exception ex)
            {
                var failedSXeptionServiceException
                    = new FailedSXeptionServiceException(
                        message: this.localizationService
                                     .GetLocalizedText("SF_MSG_FAILED_SERVICE_EXCEPTION"),
                        innerException: ex);

                var sxeptionServiceException = new SXeptionServiceException(
                    message: this.localizationService
                                     .GetLocalizedText("SF_MSG_SERVICE_EXCEPTION"),
                   innerException: failedSXeptionServiceException);

                throw sxeptionServiceException;
            }
        }
    }
}
