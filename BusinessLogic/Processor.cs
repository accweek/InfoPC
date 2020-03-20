using System;
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
        public static string GetProcessorInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM win32_processor");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "Failed to determine";
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
            return "Failed to determine";
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
                try
                {
                    result += Convert.ToString(strt["NumberOfCores"]);
                }
                catch { return "Failed to determine"; }
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
                try
                {
                    result += Convert.ToString(strt["Manufacturer"]);
                }
                catch { return "Failed to determine"; }
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
                try
                {
                    result += Convert.ToString(strt["CurrentClockSpeed"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }


    }
}
