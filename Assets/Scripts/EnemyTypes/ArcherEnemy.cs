using UnityEngine;

namespace FactoryPattern
{
    public class ArcherEnemy : MonoBehaviour, IEnemy
    {
        public void Initialize()
        {
            Debug.Log("Initialize archer enemy");
        }
    }
}