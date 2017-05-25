using System;

public static class MCTS
{
    /*
     * 
     */
    public static AbstractAction GetDecision(AbstractGameState state)
    {
        // create initial node to be the root node of the search tree
        
        // as long as the search has not terminated
        // while !done ?
        // for set-iterations ?
        {
            // SELECT
            // -> do recursively? requires passing policy into the node or selectChild() call itself
            // as long as the current node is not a terminal node, and has not been fully expanded
            // choose a child based on the SELECTION POLICY
            
            
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
     *
     */
    private static AbstractNode Select(AbstractNode node)
    {
        return null;
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
