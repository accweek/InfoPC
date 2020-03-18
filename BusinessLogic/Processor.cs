﻿using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace BusinessLogic
{
    public class Processor
    {
        /// <summary>
        /// Информация о процессоре
        /// </summary>
        /// <returns></returns>
        public static String GetProcessorInformation()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                info = name + ", " + (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }

        /// <summary>
        /// Описание процессора
        /// </summary>
        /// <returns></returns>
        public static string GetProcessorDescription()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM win32_processor");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Description").ToString();
                }
                catch { }
            }
            return "Processor Description: Unknown";
        }

        /// <summary>
        /// Кол-во ядер процессора
        /// </summary>
        /// <returns></returns>
        public static String GetProcessorNumberOfCores()
        {
            ManagementClass mangnmt = new ManagementClass("win32_processor");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["NumberOfCores"]);
            }
            return result;
        }

        /// <summary>
        /// Производитель процессора
        /// </summary>
        /// <returns></returns>
        public static string GetProcessorThreadCount()
        {

            ManagementClass mangnmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["Manufacturer"]);
            }
            return result.ToString();
        }



        /// <summary>
        /// Частота процессора
        /// </summary>
        /// <returns></returns>
        public static String GetProcessorCurrentClockSpeed()
        {
            ManagementClass mangnmt = new ManagementClass("win32_processor");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["CurrentClockSpeed"]);
            }
            return result;
        }
    }
}
