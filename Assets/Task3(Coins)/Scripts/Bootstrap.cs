using UnityEngine;

namespace Task3_Coins_.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;

        private void Awake()
        {
            _coinSpawner.StartWork();
        }
    }
}