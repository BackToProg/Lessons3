using UnityEngine;

namespace Task2_Images_.Scripts
{
    public class Coin : IIcon
    {
        public Sprite Sprite { get; }

        public Coin(Sprite sprite)
        {
            Sprite = sprite;
        }
    }
}