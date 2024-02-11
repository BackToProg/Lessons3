﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Visitor.Enemies;
using Random = UnityEngine.Random;

namespace Visitor
{
    public class Spawner: MonoBehaviour, IEnemyLivecycleNotifier
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;

        private Coroutine _spawn;

        private List<Enemy> _spawnedEnemies = new List<Enemy>();

        public event Action<Enemy> OnDeadNotified;
        public event Action<Enemy> OnSpawnNotified;

        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return;

            _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                OnSpawnNotified?.Invoke(enemy);
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                _spawnedEnemies.Add(enemy);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Died -= OnEnemyDied;
            OnDeadNotified?.Invoke(enemy);
            _spawnedEnemies.Remove(enemy);
        }
    }
}
