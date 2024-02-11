using UnityEngine;

namespace Task2_Images_.Scripts
{
    [CreateAssetMenu(menuName = "Configs/IconsConfig", fileName = "IconsConfig")]
    public class IconsConfig : ScriptableObject
    {
        [SerializeField] private Sprite _coinSprite1;
        [SerializeField] private Sprite _coinSprite2;
        [SerializeField] private Sprite _energySprite1;
        [SerializeField] private Sprite _energySprite2;

        public Sprite CoinSprite1 => _coinSprite1;
        public Sprite CoinSprite2 => _coinSprite2;
        public Sprite EnergySprite1 => _energySprite1;
        public Sprite EnergySprite2 => _energySprite2;
        
        
    }
}