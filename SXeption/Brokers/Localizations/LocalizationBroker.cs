// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Globalization;
using System.Resources;

namespace SXeption.Brokers.Localizations
{
    public class LocalizationBroker : ILocalizationBroker
    {
        private readonly ResourceManager resourceManager;

        public LocalizationBroker(Type resourceSource)
        {
            resourceManager = new ResourceManager(resourceSource);
        }

        public string GetLocalizedText(string key)
            => resourceManager.GetString(key);

        public string GetLocalizedText(string key, CultureInfo culture)
            => resourceManager.GetString(key, culture);
    }
}
