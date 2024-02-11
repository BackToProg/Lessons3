using UnityEngine;

namespace Task2_Images_.Scripts
{
    public class Energy : IIcon
    {
        public Sprite Sprite { get; }

        public Energy(Sprite sprite)
        {
            Sprite = sprite;
        }
    }
}