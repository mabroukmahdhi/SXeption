// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using SXeption.Brokers.Localizations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXeption.Services.Foundations.Localizations
{
    public class LocalizationService : ILocalizationService
    {
        private readonly ILocalizationBroker localizationBroker;
        public LocalizationService(ILocalizationBroker localizationBroker)
            => this.localizationBroker = localizationBroker;

        public string GetLocalizedText(string key)
            => this.localizationBroker.GetLocalizedText(key);

        public string GetLocalizedText(string key, params object[] parameters)
            => string.Format(GetLocalizedText(key), parameters);

        public string GetLocalizedText(string key, CultureInfo culture)
            => this.localizationBroker.GetLocalizedText(key, culture);

        public string GetLocalizedText(
            string key,
            CultureInfo culture,
            params object[] parameters)
            => string.Format(GetLocalizedText(key, culture), parameters);
    }
}
