using UnityEngine;

namespace Task5_Characters_.Scripts
{
    public class Player
    {
        private IStats _stats;

        public Player(IStats stats)
        {
            _stats = stats;
        }

        public void ShowStats()
        {
            Debug.Log($"Сила : {_stats.Strength} /n Ловкость : {_stats.Agility} /n Интелект: {_stats.Intelligence}");
        }
    }
}