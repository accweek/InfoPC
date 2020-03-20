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
                try
                {
                    result += Convert.ToString(strt["VolumeSerialNumber"]);

                }
                catch { return "Failed to determine"; }
            }

            return result;
        }

        /// <summary>
        /// Призводитель диска
        /// </summary>
        /// <returns></returns>
        public static String GetDriveManufacturer()
        {
            ManagementObjectSearcher mangnmt = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_LogicalDisk");
            
            foreach (ManagementObject strt in mangnmt.Get())
            {
                try
                {
                    return strt.GetPropertyValue("Manufacturer").ToString();
                }
                catch {  }
            }

            return "Failed to determine";
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
                try
                {
                    result += Convert.ToDouble(strt["Size"]) /1024 /1024 /1024;
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Имена дисков
        /// </summary>
        /// <returns></returns>
        public static string GetDriveName()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["Name"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;       
        }

        public static string GetVolumeName()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                try
                {
                    result += Convert.ToString(strt["VolumeName"]);
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }

        /// <summary>
        /// Имя CDRom
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
                catch {  }
            }
            return "Failed to determine";
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
                try
                {
                    result += Convert.ToDouble(strt["FreeSpace"]) / 1024 / 1024 / 1024;
                }
                catch { return "Failed to determine"; }
            }
            return result;
        }
    }
}
