using Task3_Coins_.Scripts.Config;
using UnityEngine;

namespace Task3_Coins_.Scripts.Factory
{
    public class CoinFactory : MonoBehaviour
    {
        [SerializeField] private CoinConfig _coinConfig;
        
        public void Get(Vector3 position)
        {
            Instantiate(_coinConfig.CoinPrefab, position, Quaternion.identity);
        }
    }
}
