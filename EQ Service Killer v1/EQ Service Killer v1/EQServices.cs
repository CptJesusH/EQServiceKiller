using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace EQ_Service_Killer_v1
{
    class EQServices
    {
        private static readonly string[] _eqSvcs = { "Spooler", "HTC Account Service",
        "Origin Web Helper Service", "PingPlotter5", "Razer Game Scanner Service",
        "SSUService" };
        private static string[] _checkedBoxes = new string[6];

        public static void Checked(int checkboxChecked)
        {
            _checkedBoxes[checkboxChecked] = _eqSvcs[checkboxChecked];
        }

        public static string GetStatus(int svcPositionInArray)
        {
            ServiceController service = new ServiceController(_eqSvcs[svcPositionInArray]);
            return service.Status.ToString();
        }
        
        public static void StartService(int svcPositionInArray)
        {
            ServiceController service = new ServiceController(_eqSvcs[svcPositionInArray]);
            service.Start();
        }

        public static void StopService(int svcPositionInArray)
        {
            ServiceController service = new ServiceController(_eqSvcs[svcPositionInArray]);
            service.Stop();
        }

        public static void StartCheckedServices()
        {
            foreach (string service in _checkedBoxes)
            {
                if (service == null)
                {
                    continue;
                }
                else
                {
                    string serv = service;
                    ServiceController Service = new ServiceController(serv);
                    if (Service != null && Service.Status.ToString() == "Stopped")
                    {
                        Service.Start();
                        Service.WaitForStatus(ServiceControllerStatus.Running);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void StopCheckedServices()
        {
            foreach (string service in _checkedBoxes)
            {
                if (service == null)
                {
                    continue;
                }
                else
                {
                    string serv = service;
                    ServiceController Service = new ServiceController(serv);
                    if (Service != null && Service.Status.ToString() == "Running")
                    {
                        Service.Stop();
                        Service.WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
