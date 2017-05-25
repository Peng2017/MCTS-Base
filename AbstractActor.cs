using System;

namespace MCTS
{
    /*
     *
     */
    public abstract class AbstractActor
    {
        public String identifier
        {
            get;
        }
        
        public bool Equals(Object other)
        {
            if(other is AbstractActor)
            {
                AbstractActor aa = (AbstractActor) other;
                
                return aa.identifier.Equals(this.identifier);
            }
            else
                return false;
        }
    }
}
