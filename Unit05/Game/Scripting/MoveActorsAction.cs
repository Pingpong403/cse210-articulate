using System.Collections.Generic;
using Unit05.Game.Casting;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    public class MoveActorsAction : Action
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public MoveActorsAction()
        {
        }

        /// <summary>
        /// <para>
        /// Overrides the Execute() method from Action.
        /// </para>
        /// <para>Moves all Actors.</para>
        /// </summary>
        public void Execute(Cast cast, Script script)
        {
            foreach (Actor actor in cast.GetAllActors())
            {
                actor.MoveNext();
            }
        }
    }
}