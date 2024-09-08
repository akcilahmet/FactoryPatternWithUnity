using UnityEngine;

namespace FactoryPattern
{
    [CreateAssetMenu(fileName = "ArcherFactory", menuName = "Factories/ArcherFactory")]
    public class ArcherFactory : Factory
    {
        [SerializeField]
        private ArcherEnemy _archerEnemyPrefab;

        public override IEnemy CreateEnemy(Vector3 createPosition)
        {
            if (_archerEnemyPrefab == null)
            {
                Debug.LogError("Archer enemy prefab is not assigned!");
                return null;
            }

            GameObject archerInstance = Instantiate(_archerEnemyPrefab.gameObject, createPosition, Quaternion.identity);
            var enemy = archerInstance.GetComponent<IEnemy>();
            return enemy;
        }
    }
}