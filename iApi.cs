using System;
using System.Collections.Generic;
using System.Text;

namespace Ivvy
{
    public partial interface IApi
    {
        void InitializeApi(string apiKey, string apiSecret, string apiVersion, string baseUrl);
    }
}
