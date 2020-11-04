﻿using System.ServiceModel;
using System.Net;

namespace EvlWatcherConsole.WCF
{
    [ServiceContract]
    public interface IEvlWatcherService
    {
        [OperationContract]
        bool GetIsRunning();
        [OperationContract]
        IPAddress[] GetTemporarilyBannedIPs();
        [OperationContract]
        IPAddress[] GetPermanentlyBannedIPs();
        [OperationContract]
        void SetPermanentBan(IPAddress address);
        [OperationContract]
        void ClearPermanentBan(IPAddress address);
        [OperationContract]
        void AddWhiteListEntry(string filter);
        [OperationContract]
        void RemoveWhiteListEntry(string filter);
        [OperationContract]
        string[] GetWhiteListEntries();
    }
}
