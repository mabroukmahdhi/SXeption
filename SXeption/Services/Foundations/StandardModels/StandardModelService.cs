// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using SXeption.Brokers.Localizations;
using SXeption.Brokers.Loggings;
using SXeption.Models.StandardModels.Exceptions;
using System;
using Xeptions;

namespace SXeption.Services.Foundations.StandardModels
{
    public partial class StandardModelService<TModel> : IStandardModelService
    {
        private readonly ILocalizationBroker localizationBroker;
        private readonly ILoggingBroker loggingBroker;

        public StandardModelService(ILocalizationBroker localizationBroker)
            => this.localizationBroker = localizationBroker;

        public StandardModelService(
            ILocalizationBroker localizationBroker,
            ILoggingBroker loggingBroker)
        {
            this.localizationBroker = localizationBroker;
            this.loggingBroker = loggingBroker;
        }

        protected virtual StandardModelValidationException CreateAndLogValidationException(
            Xeption exception)
        {
            string message = GetMessage("MSG_MODEL_VALIDATION", nameof(TModel));

            var postValidationException =
                new StandardModelValidationException(message, exception);

            this.loggingBroker?.LogError(postValidationException);

            return postValidationException;
        }

        protected virtual StandardModelDependencyException CreateAndLogCriticalDependencyException(
            Xeption exception)
        {
            string message = GetMessage("MSG_MODEL_DEPENDENCY", nameof(TModel));

            var postDependencyException = new StandardModelDependencyException(message, exception);
            this.loggingBroker?.LogCritical(postDependencyException);

            return postDependencyException;
        }

        protected virtual StandardModelDependencyValidationException CreateAndLogDependencyValidationException(
            Xeption exception)
        {
            string message = GetMessage("MSG_MODEL_DEPENDENCY_VALIDATION", nameof(TModel));

            var postDependencyValidationException =
                new StandardModelDependencyValidationException(message, exception);

            this.loggingBroker?.LogError(postDependencyValidationException);

            return postDependencyValidationException;
        }

        protected virtual StandardModelDependencyException CreateAndLogDependencyException(
            Xeption exception)
        {
            string message = GetMessage("MSG_MODEL_DEPENDENCY", nameof(TModel));

            var postDependencyException = new StandardModelDependencyException(message, exception);
            this.loggingBroker?.LogError(postDependencyException);

            return postDependencyException;
        }

        protected virtual StandardModelServiceException CreateAndLogServiceException(
            Exception exception)
        {
            string message = GetMessage("MSG_MODEL_SERVICE", nameof(TModel));

            var postServiceException = new StandardModelServiceException(message, exception);
            this.loggingBroker?.LogError(postServiceException);

            return postServiceException;
        }

        public virtual string GetMessage(string key)
            => this.localizationBroker.GetLocalizedText(key);

        public virtual string GetMessage(string key, params object[] parameters)
           => string.Format(GetMessage(key), parameters);
    }
}

