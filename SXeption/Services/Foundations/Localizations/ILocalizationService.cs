// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXeption.Services.Foundations.Localizations
{
    public interface ILocalizationService
    {
        string GetLocalizedText(string key);
        string GetLocalizedText(string key, params object[] parameters);
        string GetLocalizedText(string key, CultureInfo culture);
        string GetLocalizedText(string key, CultureInfo culture, params object[] parameters);
    }
}
