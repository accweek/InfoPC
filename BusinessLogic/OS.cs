using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace BusinessLogic
{
    public class OS
    {
        /// <summary>
        /// Имя ОС
        /// </summary>
        /// <returns></returns>
        public static String GetOSName()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["Caption"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Дата установки
        /// </summary>
        /// <returns></returns>
        public static String GetOSInstallDate()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["InstallDate"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Зрегестрированый пользователь
        /// </summary>
        /// <returns></returns>
        public static String GetOSRegisteredUser()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["RegisteredUser"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Папка Windows
        /// </summary>
        /// <returns></returns>
        public static String GetOSWindowsDirectory()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["WindowsDirectory"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Системная папка
        /// </summary>
        /// <returns></returns>
        public static String GetOSSystemDirectory()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["SystemDirectory"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Версия ОС
        /// </summary>
        /// <returns></returns>
        public static String GetOSVersion()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["Version"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Кол-во пользователей
        /// </summary>
        /// <returns></returns>
        public static String GetOSNumberOfUsers()
        {
            ManagementClass mangnmt = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["NumberOfUsers"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }
        

    }
}
