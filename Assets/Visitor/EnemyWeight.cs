using System;
using Visitor.Enemies;

namespace Visitor
{
    public class EnemyWeight : IDisposable
    {
        private IEnemyLivecycleNotifier _enemyLivecycleNotifier;
        private EnemyWeightVisitor _enemyWeightVisitor;
        
        public EnemyWeight(IEnemyLivecycleNotifier enemyLivecycleNotifier)
        {
            _enemyLivecycleNotifier = enemyLivecycleNotifier;
            _enemyLivecycleNotifier.OnSpawnNotified += OnEnemySpawned;

            _enemyWeightVisitor = new EnemyWeightVisitor();
        }

        public int EnemyWeightValue => _enemyWeightVisitor.Value;

        private void OnEnemySpawned(Enemy enemy)
        {
            _enemyWeightVisitor.Visit(enemy);
        }
        
        public void Dispose() => _enemyLivecycleNotifier.OnSpawnNotified -= OnEnemySpawned;
    }
}