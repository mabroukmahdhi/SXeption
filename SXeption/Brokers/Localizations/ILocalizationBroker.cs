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

namespace SXeption.Brokers.Localizations
{
    public interface ILocalizationBroker
    {
        string GetLocalizedText(string key);
        string GetLocalizedText(string key, CultureInfo culture);
    }
}
