// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace SXeption.Services.Foundations.StandardModels
{
    public partial interface IStandardModelService
    {
        string GetMessage(string key);
        string GetMessage(string key, params object[] parameters);
    }
}
