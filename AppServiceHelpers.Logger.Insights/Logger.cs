﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppServiceHelpers.Logger.Insights
{
    public class Logger : Abstractions.ILogger
    {
        public bool IsInitialized()
        {
            if (Xamarin.Insights.IsInitialized == true)
                return true;
            return false;
        }

        public void Report(Exception ex)
        {
            Xamarin.Insights.Report(ex);
        }

        public void Report(Exception ex, Dictionary<string, string> data)
        {
            Xamarin.Insights.Report(ex, data);
        }
    }
}
