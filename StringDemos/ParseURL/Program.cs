using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ParseURL
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int protocolEnd = 0;
        int serverEnd = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ':')
            {
                protocolEnd = i;
                i = protocolEnd + 3;
            }
            if (input[i] == '/')
            {
                serverEnd = i;
                break;
            }
        }
        StringBuilder protocol, server, resource;

        FidingUTLSubstruct(input, protocolEnd, serverEnd, out protocol, out server, out resource);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }

    private static void FidingUTLSubstruct(string input, int protocolEnd, int serverEnd, out StringBuilder protocol, out StringBuilder server, out StringBuilder resource)
    {
        protocol = new StringBuilder();
        server = new StringBuilder();
        resource = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            while (i < protocolEnd)
            {
                protocol.Append(input[i]);
                i++;
            }
            while (i < serverEnd)
            {
                server.Append(input[i]);
                i++;
            }
            resource.Append(input[i]);
        }
        server.Remove(0, 3);
    }
}

