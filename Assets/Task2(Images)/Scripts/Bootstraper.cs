using Task2_Images_.Scripts.Factory;
using UnityEngine;

namespace Task2_Images_.Scripts
{
    public class Bootstraper : MonoBehaviour
    {
         [SerializeField] private IconType _iconType;
         [SerializeField] private ImageFiller _imageFiller;
         [SerializeField] private IconsConfig _iconsConfig;
        
         [ContextMenu("Set Icons")]
         public void SetIcons()
         {
             IIcon[] icons = new IIcon[2];
             IconFactory iconFactory = new IconFactory();

             icons = iconFactory.Get(_iconType, _iconsConfig);
             _imageFiller.FillImages(icons[0].Sprite, icons[1].Sprite);
         }
    }
}