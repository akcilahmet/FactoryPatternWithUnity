using UnityEngine;

namespace FactoryPattern
{
    [CreateAssetMenu(fileName = "WarriorFactory", menuName = "Factories/WarriorFactory")]
    public class WarriorFactory : Factory
    {
        [SerializeField]
        private WarriorEnemy _warriorEnemyPrefab;

        public override IEnemy CreateEnemy(Vector3 createPosition)
        {
            if (_warriorEnemyPrefab == null)
            {
                Debug.LogError("Warrior enemy prefab is not assigned!");
                return null;
            }

            GameObject warriorInstance =
                Instantiate(_warriorEnemyPrefab.gameObject, createPosition, Quaternion.identity);
            var enemy = warriorInstance.GetComponent<IEnemy>();
            return enemy;
        }
    }
}