using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Scottish_Glen_Asset_Tracking
{
    internal class HardwareInfoProvider
    {
        public string GetSystemName()
        {
            return Environment.MachineName;
        }

        public string GetManufacturer()
        {
            return GetWmiValue(
                "Win32_ComputerSystem",
                "Manufacturer");
        }

        public string GetModel()
        {
            return GetWmiValue(
                "Win32_ComputerSystem",
                "Model");
        }

        public string GetHardwareType()
        {
            try
            {
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT ChassisTypes FROM Win32_SystemEnclosure"))
                {
                    foreach (ManagementObject item in searcher.Get())
                    {
                        ushort[] chassisTypes =
                            item["ChassisTypes"] as ushort[];

                        if (chassisTypes == null)
                            continue;

                        foreach (ushort chassisType in chassisTypes)
                        {
                            switch (chassisType)
                            {
                                // Desktop computers
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 15:
                                case 16:
                                    return "Desktop";

                                // Portable computers
                                case 8:
                                case 9:
                                case 10:
                                case 11:
                                case 12:
                                case 14:
                                case 31:
                                case 32:
                                    return "Laptop";

                                // Tablet
                                case 30:
                                    return "Tablet";

                                // Server
                                case 23:
                                case 28:
                                    return "Server";
                            }
                        }
                    }
                }
            }
            catch (ManagementException)
            {
                // WMI may not provide chassis information.
            }
            catch (UnauthorizedAccessException)
            {
                // Continue to the fallback value.
            }

            return "Unknown";
        }
        public string GetIPAddress()
        {
            try
            {
                return NetworkInterface.GetAllNetworkInterfaces()
                    .Where(network =>
                        network.OperationalStatus ==
                        OperationalStatus.Up &&
                        network.NetworkInterfaceType !=
                        NetworkInterfaceType.Loopback &&
                        network.NetworkInterfaceType !=
                        NetworkInterfaceType.Tunnel)
                    .SelectMany(network =>
                        network.GetIPProperties().UnicastAddresses)
                    .Where(address =>
                        address.Address.AddressFamily ==
                        AddressFamily.InterNetwork &&
                        !address.Address.ToString().StartsWith("169.254."))
                    .Select(address => address.Address.ToString())
                    .FirstOrDefault() ?? "Unavailable";
            }
            catch (NetworkInformationException)
            {
                return "Unavailable";
            }
        }

        public string GetWmiValue(
            string className,
            string propertyName)
        {
            try
            {
                string query =
                    "SELECT " + propertyName +
                    " FROM " + className;

                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(query))
                using (ManagementObjectCollection results =
                    searcher.Get())
                {
                    foreach (ManagementObject item in results)
                    {
                        object value = item[propertyName];

                        if (value != null)
                        {
                            string result = value.ToString().Trim();

                            if (!string.IsNullOrWhiteSpace(result))
                            {
                                return result;
                            }
                        }
                    }
                }
            }
            catch (ManagementException ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "WMI query failer: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "WMI access denied: " + ex.Message);
            }

            return "Unknown";
        }
    }
}