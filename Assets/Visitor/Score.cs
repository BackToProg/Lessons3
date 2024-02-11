using System;
using UnityEngine;
using Visitor.Enemies;

namespace Visitor
{
    public class Score: IDisposable
    {
        public int Value => _enemyVisitor.Score;

        private IEnemyLivecycleNotifier _enemyLivecycleNotifier;

        private EnemyScoreVisitor _enemyVisitor;

        public Score(IEnemyLivecycleNotifier enemyLivecycleNotifier)
        {
            _enemyLivecycleNotifier = enemyLivecycleNotifier;
            _enemyLivecycleNotifier.OnDeadNotified += OnEnemyKilled;

            _enemyVisitor = new EnemyScoreVisitor();
        }
        public void Dispose() => _enemyLivecycleNotifier.OnDeadNotified -= OnEnemyKilled;

        private void OnEnemyKilled(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            Debug.Log($"Счет: {Value}");
        }
        
    }
}
