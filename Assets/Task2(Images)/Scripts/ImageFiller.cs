using UnityEngine;
using UnityEngine.UI;

namespace Task2_Images_.Scripts
{
    public class ImageFiller : MonoBehaviour
    {
        [SerializeField] private Image _iconImage1;
        [SerializeField] private Image _iconImage2;

        public void Awake()
        {
            FillImages(null, null);
        }

        public void FillImages(Sprite image1, Sprite image2)
        {
            _iconImage1.sprite = image1;
            _iconImage2.sprite = image2;
        }
    }
}