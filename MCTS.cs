using System;

namespace MCTS
{
    public static class MCTS
    {
        /*
         * 
         */
        public static AbstractAction GetDecision(AbstractGameState state)
        {
            // create initial node to be the root node of the search tree
            AbstractNode root = new AbstractNode(null, state);

            // as long as the search has not terminated
            // while !done ?
            // for set-iterations ?
            {
                AbstractNode node = root;

                // SELECT
                // -> do recursively? requires passing policy into the node or selectChild() call itself
                // as long as the current node is not a terminal node, and has not been fully expanded
                // choose a child based on the SELECTION POLICY
                node = Select(node);

                // EXPAND
                // -> perform locally
                // select an unexpanded AbstractAction from the from the current node
                // create a new child based on the given AbstractAction

                // ROLLOUT/SIMULATE
                // simulate gameplay on the expanded node until it reaches a terminal state
                // OR (allow some time/iteration based restriction to prevent infinite loops in some game implementations)

                // BACKPROPAGATE
                // feed visits and win/loss information back up the tree until the root node is reached

            }

            return null; 
        }

        /*
         * -> do recursively? requires passing policy into the node or selectChild() call itself
         * as long as the current node is not a terminal node, and has not been fully expanded
         * choose a child based on the SELECTION POLICY
         */
        private static AbstractNode Select(AbstractNode node)
        {
            if(node.isTerminalAndFullyExpanded)
                return node;
            else
                return null;

                // TODO: define/apply selection policy on Collection of childNodes
                // return Select(node);
        }

        /*
         * 
         */
        private static AbstractNode Expand(AbstractNode node)
        {
            return null;
        }

        /*
         *
         */
        private static void Rollout(AbstractNode node)
        {
        }

        /*
         *
         */
        private static void Backpropagate(AbstractNode node)
        {

        }
    }
}
