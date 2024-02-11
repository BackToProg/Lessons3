namespace Task5_Characters_.Scripts.UniqAbilities
{
    public class UniqAbilityStateProvider : IStats
    {
        private const int UniqAbilityStatUpdateValue = 2;
        
        private UniqAbility _uniqAbility;
        private IStats _stats;

        private int _strength;
        private int _agility;
        private int _intelligence;

        public UniqAbilityStateProvider(IStats stats, UniqAbility uniqAbility) 
        {
            _stats = stats;
            _uniqAbility = uniqAbility;
            
            UpdateStats(_uniqAbility);
        }
        
        public int Strength => _strength;
        public int Agility => _agility;
        public int Intelligence => _intelligence;

        private void UpdateStats(UniqAbility uniqAbility)
        {
            switch (uniqAbility)
            {
                case UniqAbility.Curse:
                    Stats.UpdateStat(out _agility, _stats.Agility, UniqAbilityStatUpdateValue, Stats.Divide );
                    _strength = _stats.Strength;
                    _intelligence = _stats.Intelligence;
                    break;
                case UniqAbility.Blessing:
                    Stats.UpdateStat(out _strength, _stats.Strength, UniqAbilityStatUpdateValue, Stats.Multipy );
                    Stats.UpdateStat(out _agility, _stats.Agility, UniqAbilityStatUpdateValue, Stats.Multipy );
                    _intelligence = _stats.Intelligence;
                    break;
                case UniqAbility.Vampirism:
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, UniqAbilityStatUpdateValue, Stats.Add );
                    _strength = _stats.Strength;
                    _agility = _stats.Agility;
                    break;
            }
        }

    }
}