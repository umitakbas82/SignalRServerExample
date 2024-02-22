using SignalRServerExample.Models;
using System.Collections.Generic;

namespace SignalRServerExample.Data
{
    public class ClientSource
    {
        public static List<Client> clients = new List<Client>();

        public static List<Client> Clients { get;  }=new List<Client>();
       
    }
}
