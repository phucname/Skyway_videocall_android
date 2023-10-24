using Com.Ntt.Skyway.Room.P2p;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyway_videocall_android.module
{
    public class P2PRoomManager
    {
        public P2PRoom room = null;
        public LocalP2PRoomMember localPerson = null;
        public bool isSkywayContextSetup = false;
    }
}
