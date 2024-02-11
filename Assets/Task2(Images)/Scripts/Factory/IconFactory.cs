using System;

namespace Task2_Images_.Scripts.Factory
{
    public class IconFactory
    {
        public IIcon[] Get(IconType iconType, IconsConfig iconsConfig)
        {
            IIcon[] icons = new IIcon[2];

            switch (iconType)
            {
                case  IconType.Coin:
                    icons[0] = new Coin(iconsConfig.CoinSprite1);
                    icons[1] = new Coin(iconsConfig.CoinSprite2);
                    break;
                    
                case  IconType.Energy:
                    icons[0] = new Energy(iconsConfig.EnergySprite1);
                    icons[1] = new Energy(iconsConfig.EnergySprite2);
                    break;
                
                default :
                    throw new ArgumentException(nameof(iconType));
            }

            return icons;
        }

    }
}
