using UnityEngine;

namespace Task3_Coins_.Scripts.Config
{
    [CreateAssetMenu(menuName = "Configs/CoinConfig", fileName = "CoinConfig")]
    public class CoinConfig : ScriptableObject
    {
        [SerializeField] private GameObject _coinPrefab;

        public GameObject CoinPrefab => _coinPrefab;
    }
}
