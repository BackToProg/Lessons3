using System.Collections;
using System.Collections.Generic;
using Task3_Coins_.Scripts.Factory;
using UnityEngine;

namespace Task3_Coins_.Scripts
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private CoinFactory _coinFactory;

        private Coroutine _spawnCoroutine;
        private List<Transform> _existingSpawnPoints;

        private void Awake()
        {
            _existingSpawnPoints = _spawnPoints;
        }

        public void StartWork()
        {
            StopWork();

            _spawnCoroutine = StartCoroutine(Spawn());
        }

        private void StopWork()
        {
            if (_spawnCoroutine != null)
                StopCoroutine(_spawnCoroutine);

        }

        private IEnumerator Spawn()
        {
            WaitForSeconds spawnCooldown = new WaitForSeconds(_spawnCooldown);

            while (_spawnPoints.Count > 0)
            {
                int spawnPointIndex = Random.Range(0, _spawnPoints.Count);
                _coinFactory.Get(_existingSpawnPoints[spawnPointIndex].position);
                _existingSpawnPoints.RemoveAt(spawnPointIndex);

                yield return spawnCooldown;
            }
        }
    }
}
