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
        
        public abstract EGameResult GetResult(AbstractActor checkingActor);
        
        public abstract AbstractGameState RunSimulation();
        
        public IEnumerable<AbstractAction> GetMoves();
    }
}
