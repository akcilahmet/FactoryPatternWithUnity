using UnityEngine;

namespace FactoryPattern
{
    [CreateAssetMenu(fileName = "MagicFactory", menuName = "Factories/MagicFactory")]
    public class MagicFactory : Factory
    {
        [SerializeField]
        private MagicEnemy _magicEnemyPrefab;

        public override IEnemy CreateEnemy(Vector3 createPosition)
        {
            if (_magicEnemyPrefab == null)
            {
                Debug.LogError("Magic enemy prefab is not assigned!");
                return null;
            }

            GameObject magicInstance = Instantiate(_magicEnemyPrefab.gameObject, createPosition, Quaternion.identity);
            var enemy = magicInstance.GetComponent<IEnemy>();
            return enemy;
        }
    }
}