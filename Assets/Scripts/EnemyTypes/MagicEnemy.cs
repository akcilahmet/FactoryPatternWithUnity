using UnityEngine;

namespace FactoryPattern
{
    public class MagicEnemy : MonoBehaviour, IEnemy
    {
        public void Initialize()
        {
            Debug.Log("Initialize magic enemy");
        }
    }
}