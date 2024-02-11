using UnityEngine;
using Visitor.Enemies;

namespace Visitor
{
    public class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private int _maxEnemyToSpawn;

        private EnemyWeight _enemyWeight;

        private void OnEnable()
        {
            _spawner.OnSpawnNotified += EnemySpawned;
        }

        private void Awake()
        {
            _enemyWeight = new EnemyWeight(_spawner);
            _spawner.StartWork();
        }

        private void OnDisable()
        {
            _spawner.OnSpawnNotified -= EnemySpawned;
        }
        
        private void EnemySpawned(Enemy enemy)
        {
            if (_enemyWeight.EnemyWeightValue >= _maxEnemyToSpawn)
            {
                _spawner.StopWork();
            }
        }
    }
}