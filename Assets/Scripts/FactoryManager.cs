using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FactoryPattern
{
    /// <summary>
    /// Manages the registration and access of different factories in the game.
    /// 
    public class FactoryManager : MonoBehaviour
    {
        private Dictionary<Type, Factory> _factories = new Dictionary<Type, Factory>();

        [SerializeField]
        private List<Factory> factoryList;

        public static FactoryManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                RegisterAllFactories();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void RegisterAllFactories()
        {
            foreach (var factory in factoryList)
            {
                RegisterFactory(factory);
            }
        }

        private void RegisterFactory(Factory factory)
        {
            Type factoryType = factory.GetType();
            if (!_factories.ContainsKey(factoryType))
            {
                _factories.Add(factoryType, factory);
            }
            else
            {
                Debug.LogWarning($"Factory of type {factoryType} is already registered.");
            }
        }

        /// <summary>
        /// Retrieves a factory by its type.
        /// </summary>
        public Factory GetFactoryByType(Type factoryType)
        {
            if (_factories.TryGetValue(factoryType, out var factory))
            {
                return factory;
            }

            Debug.LogError($"Factory of type {factoryType} not found!");
            return null;
        }

        /// <summary>
        /// Returns a random factory type from the registered factories.
        /// </summary>
        public Factory GetRandomFactory()
        {
            int randomIndex = UnityEngine.Random.Range(0, _factories.Count);
            return GetFactoryByType(_factories.Keys.ElementAt(randomIndex));
        }
    }
}