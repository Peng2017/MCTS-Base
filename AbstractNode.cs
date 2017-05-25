using System;

namespace MCTS
{
    /*
     * nodes for the MCTS search tree
     *
     * All nodes has an AbstractGameState, and a Parent.
     * They also track visits and wins as integer values
     */
    public abstract class AbstractNode
    {
        // parent of the node
        // the root node will have a 'null' parent
        public AbstractNode Parent
        {
            get;
            private set;
        }
    
        // GameState of the node
        // this will determine the possible moves and allow simulation to occur
        public AbstractGameState State
        {
            get;
            private set;
        }
    
        // minimum constructor requires a parent reference and a state reference
        public AbstractNode(AbstractNode _parent, AbstractGameState _state)
        {
            this.Parent = _parent;
            this.State = _state;
        }
    }
}
