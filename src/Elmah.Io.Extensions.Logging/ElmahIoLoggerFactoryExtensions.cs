﻿using System;
using Microsoft.Extensions.Logging;

namespace Elmah.Io.Extensions.Logging
{
    public static class ElmahIoLoggerFactoryExtensions
    {
        public static ILoggerFactory AddElmahIo(this ILoggerFactory factory, string apiKey, Guid logId)
        {
            factory.AddProvider(new ElmahIoLoggerProvider(apiKey, logId));
            return factory;
        }

        public static ILoggerFactory AddElmahIo(this ILoggerFactory factory, string apiKey, Guid logId, FilterLoggerSettings filter)
        {
            factory.AddProvider(new ElmahIoLoggerProvider(apiKey, logId, filter));
            return factory;
        }

        public static ILoggerFactory AddElmahIo(this ILoggerFactory factory, string apiKey, Guid logId, FilterLoggerSettings filter, ElmahIoProviderOptions options)
        {
            factory.AddProvider(new ElmahIoLoggerProvider(apiKey, logId, filter, options));
            return factory;
        }
    }
}