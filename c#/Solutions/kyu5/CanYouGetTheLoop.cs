using System.Collections.Generic;

namespace Codewars.kyu5
{
    internal class CanYouGetTheLoop
    {
        public static int GetLoopSize(LoopDetector.Node startNode)
        {
            ISet<LoopDetector.Node> visitedNodes = new HashSet<LoopDetector.Node> {startNode};
            var count = 0;
            var foundLoop = false;
            LoopDetector.Node repeatingNode = null;
            var nextNode = startNode;
            while (true)
            {
                nextNode = nextNode.next;
                if (!foundLoop && !visitedNodes.Add(nextNode))
                {
                    foundLoop = true;
                    repeatingNode = nextNode;
                }
                else if (nextNode == repeatingNode)
                {
                    return count;
                }

                if (foundLoop) count++;
            }
        }
    }

    // A dummy type to avoid having to deal with build errors.
    internal class LoopDetector
    {
        internal class Node
        {
            public Node(Node next)
            {
                this.next = next;
            }

            public Node next { get; }
        }
    }
}