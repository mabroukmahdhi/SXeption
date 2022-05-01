// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Globalization;

namespace SXeption.Brokers.Cultures
{
    public class CultureBroker : ICultureBroker
    {
        public CultureInfo GetCurrentCulture()
            => CultureInfo.CurrentCulture;
    }
}
