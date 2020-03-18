using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace BusinessLogic
{
    public class Disks
    {
        /// <summary>
        /// Номер серии HDD.
        /// </summary>
        /// <returns></returns>
        public static String GetHDDSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        /// <summary>
        /// Призводитель диска
        /// </summary>
        /// <returns></returns>
        public static String GetDriveBlockSize()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["Manufacturer"]);

                }
                catch { }
            }

            return "Oshibka";
        }

        /// <summary>
        /// Размер диска
        /// </summary>
        /// <returns></returns>
        public static String GetDriveSize()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToDouble(strt["Size"]) /1024 /1024 /1024;
            }
            return result;
        }

        /// <summary>
        /// Имя диска
        /// </summary>
        /// <returns></returns>
        public static string GetDriveName()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["Name"]);
            }
            return result;
        
        }

        /// <summary>
        /// Драйвера CDRom
        /// </summary>
        /// <returns></returns>
        public static string GetCdRomDrive()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Drive").ToString();
                }
                catch { }
            }
            return "CD ROM Drive Letter: Unknown";
        }

        /// <summary>
        /// Свободное место на диске 
        /// </summary>
        /// <returns></returns>
        public static string GetDriveFreeSize()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToDouble(strt["FreeSpace"]) / 1024 / 1024 / 1024;
            }
            return result;
        }
    }
}
