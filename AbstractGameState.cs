using System;
using System.Collections.Generic;

namespace MCTS
{
    /*
     *
     */
    public abstract class AbstractGameState
    {
        public AbstractActor actorLastPlayed
        {
            get;
            private set;
        }
        
        public List<AbstractAction> allPossibleMoves
        {
            get;
            private set;
        }
        
        public Stack<AbstractAction> untriedMoves
        {
            get;
            private set;
        }
        
        public AbstractGameState()
        {
            allPossibleMoves = new ArrayList<AbstractAction>(GetMoves());
        }
        
        public abstract EGameResult GetResult(AbstractActor checkingActor);
        
        public abstract AbstractGameState RunSimulation();
        
        public abstract IEnumerable<AbstractAction> GetMoves();
    }
}
