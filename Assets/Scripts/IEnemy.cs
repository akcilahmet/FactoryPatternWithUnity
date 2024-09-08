namespace FactoryPattern
{
    /// <summary>
    /// Defines the basic contract for all enemy types in the game. 
    /// </summary>
    public interface IEnemy
    {
        /// <summary>
        /// Initializes the enemy with its default settings.
        /// Should be called when the enemy is created or respawned.
        /// </summary>
        void Initialize();
    }
}