using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Cmr.MemoryManagement;
using WaveClient.SDK;

namespace WaveClient.SDK

{
    public abstract class SDKHandler
    {
        public ulong address;

        public SDKHandler(ulong address)
        {
            this.address = address;
        }
    }
}