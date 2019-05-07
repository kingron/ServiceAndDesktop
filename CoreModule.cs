using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Data;

namespace ServiceAndDesktop
{
    class CoreModule
    {
        const string LOG_TAG = "Application";
        public CoreModule()
        {

        }
        ~CoreModule()
        {

        }

        public void LogE(string message)
        {
            EventLog.WriteEntry(LOG_TAG, message, EventLogEntryType.Error, 666);
        }

        public void LogI(string message)
        {
            EventLog.WriteEntry(LOG_TAG, message, EventLogEntryType.Information, 666);
        }


        public void Start()
        {

        }

        public void Stop()
        {

        }

    }
}
