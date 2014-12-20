﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace TechnicSolderHelper.confighandler
{
    public class ConfigHandler
    {
        private static readonly string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SolderHelper", "config.cfg");

        public ConfigHandler()
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SolderHelper")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SolderHelper"));
            }
            if (!File.Exists(configFile))
            {
                File.Create(configFile, 4000, FileOptions.SequentialScan);
            }
        }

        public string getConfig(String configName)
        {
            Dictionary<String, String> configValues = getAllConfigs();
            try
            {
                return configValues[configName];
            }
            catch (Exception)
            {
                setConfig(configName, String.Empty);
                return String.Empty;
            }
        }

        public void setConfig(String configName, Boolean configValue)
        {
            setConfig(configName, configValue.ToString());
        }

        public void setConfig(String configName, String configValue)
        {
            Dictionary<String, String> configValues = getAllConfigs();
            if (configValues.ContainsKey(configName))
            {
                configValues[configName] = configValue;
            }
            else
            {
                configValues.Add(configName, configValue);
            }
            File.WriteAllText(configFile, "");
            using (StreamWriter writer = new StreamWriter(configFile))
            {
                foreach (var item in configValues)
                {
                    //Debug.WriteLine(item.Key + "=" + item.Value);
                    writer.WriteLine(item.Key + "=" + item.Value);
                }
            }
        }

        private Dictionary<String, String> getAllConfigs()
        {
            Dictionary<String, String> configValues = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(configFile))
            {
                while (true)
                {
                    string tmp = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(tmp))
                    {
                        String[] values = tmp.Split('=');
                        for (int i = 0; i < values.Length; i++)
                        {
                            values[i] = values[i].Replace("=", "");
                        }
                        configValues.Add(values[0], values[1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return configValues;
        }
    }
}

