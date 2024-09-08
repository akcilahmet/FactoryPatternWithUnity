using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryPattern
{
    /// <summary>
    /// Manages the spawning of enemies in the game using the Factory Pattern.
    /// Continuously checks for user input to spawn enemies at the clicked position.
    /// </summary>
    public class EnemySpawnManager : MonoBehaviour
    {
        private Factory _currentFactory;

        //Test
        private void Update()
        {
            SpawnEnemy();
        }

        private void SpawnEnemy()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var factoryManager = FactoryManager.Instance;
                if (factoryManager != null)
                {
                    _currentFactory = factoryManager.GetRandomFactory();
                }

                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity)
                    && _currentFactory != null)
                {
                    var enemy = _currentFactory.CreateEnemy(hit.point);
                    enemy.Initialize();
                }
            }
        }
    }
}