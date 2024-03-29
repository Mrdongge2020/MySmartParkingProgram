﻿using Microsoft.Extensions.Configuration;
using My.SmartParking.Server.IConfiguration;

namespace My.SmartParking.Server.Configuration
{
    public class Configuration : IConfiguration.IConfiguration
    {
        private static IConfigurationRoot configurationRoot;
        static Configuration() 
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configurationRoot = builder.Build();
        }
        public  string Read(string key)
        {
            return configurationRoot[key];
        }
    }
}
