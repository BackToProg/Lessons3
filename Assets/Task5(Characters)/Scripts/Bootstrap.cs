using Task5_Characters_.Scripts.Races;
using Task5_Characters_.Scripts.Specializations;
using Task5_Characters_.Scripts.UniqAbilities;
using UnityEngine;

namespace Task5_Characters_.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        private Player _player;
        
        private void Awake()
        {
            _player = new Player(
                new UniqAbilityStateProvider(
                new SpecializationStateProvider(
                    new RaceStateProvider(
                        new Stats(10,10,10)
                        , RaceType.Elf)
                    , SpecializationType.Thief)
                , UniqAbility.Blessing));
            
            _player.ShowStats();
        }
        
        
    }
}