using UnityEngine;

namespace FactoryPattern
{
    // <summary>
    /// An abstract base class for creating enemies in the game.
    /// </summary>
    public abstract class Factory : ScriptableObject
    {
        /// <summary>
        /// Creates an enemy instance at the specified position.
        /// </summary>
        public abstract IEnemy CreateEnemy(Vector3 createPosition);
    }
}