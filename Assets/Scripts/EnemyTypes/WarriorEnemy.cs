using UnityEngine;

namespace FactoryPattern
{
    public class WarriorEnemy : MonoBehaviour, IEnemy
    {
        public void Initialize()
        {
            Debug.Log("Initialize warrior enemy");
        }
    }
}