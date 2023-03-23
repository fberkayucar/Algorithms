using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static List<Tuple<int, int>> links;
    static List<int> gateways;

    static void Main(string[] args)
    {
        Tuple<int, int> nearerGatewayLink;
        links = new List<Tuple<int, int>>();
        gateways = new List<int>();
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nearerGateway = 0;

        int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
        int L = int.Parse(inputs[1]); // the number of links
        int E = int.Parse(inputs[2]); // the number of exit gateways

        for (int i = 0; i < L; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            links.Add(new Tuple<int, int>(int.Parse(inputs[0]), int.Parse(inputs[1])));
        }

        for (int i = 0; i < E; i++)
        {
            gateways.Add(int.Parse(Console.ReadLine())); // the index of a gateway node
        }

        // game loop
        while (true)
        {
            // The index of the node on which the Skynet agent is positioned this turn
            int SI = int.Parse(Console.ReadLine());

            // Get the nearer link with a gateway
            nearerGatewayLink = SearchForNearerGatewayLink(SI, out nearerGateway);

            // Remove the link from the list
            links.Remove(nearerGatewayLink);

            // If all direct links to the gateway have been cut, remove the gateway
            if (!links.Exists(e => e.Item1 == nearerGateway || e.Item2 == nearerGateway))
            {
                gateways.Remove(nearerGateway);
            }

            Console.WriteLine(string.Format("{0} {1}", nearerGatewayLink.Item1, nearerGatewayLink.Item2));
        }
    }

    // Search for the direct link to a gateway which is nearer the agent
    static Tuple<int, int> SearchForNearerGatewayLink(int agentNode, out int gateway)
    {
        List<int> markedNodes = new List<int>();
        Queue queue = new Queue();
        Tuple<int, int> outLink;
        int tmp = 0;

        gateway = 0;
        queue.Enqueue(agentNode);
        markedNodes.Add(agentNode);

        while (queue.Count > 0)
        {
            tmp = (int)queue.Dequeue();

            // Return the link if it contains a gateway
            if (links.Exists(e => (e.Item1 == tmp && gateways.Contains(e.Item2))
                                  || (e.Item2 == tmp && gateways.Contains(e.Item1))))
            {
                outLink = links.FirstOrDefault(e => (e.Item1 == tmp && gateways.Contains(e.Item2))
                                              || (e.Item2 == tmp && gateways.Contains(e.Item1)));

                gateway = outLink.Item1 != tmp ? outLink.Item1 : outLink.Item2;

                return outLink;
            }
            else
            {
                // If not, continue to search for a gateway link among the nearby links
                foreach (var link in links.Where(e => e.Item1 == tmp || e.Item2 == tmp))
                {
                    if (!markedNodes.Contains(tmp))
                    {
                        queue.Enqueue(link.Item1 != tmp ? link.Item1 : link.Item2);
                        markedNodes.Add(tmp);
                    }
                }
            }
        }

        // By default, return a link next to the agent
        return links.FirstOrDefault(e => e.Item1 == agentNode || e.Item2 == agentNode);
    }
}