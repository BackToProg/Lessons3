namespace Task5_Characters_.Scripts.Specializations
{
    public class SpecializationStateProvider : IStats
    {
        private const int SpecializationStatUpdateValue = 3;
        
        private SpecializationType _specializationType;
        private IStats _stats;

        private int _strength;
        private int _agility;
        private int _intelligence;

        public SpecializationStateProvider(IStats stats, SpecializationType specializationType) 
        {
            _stats = stats;
            _specializationType = specializationType;
            
            UpdateStats(_specializationType);
        }
        
        public int Strength => _strength;
        public int Agility => _agility;
        public int Intelligence => _intelligence;

        private void UpdateStats(SpecializationType specialization)
        {
            switch (specialization)
            {
                case SpecializationType.Wizard:
                    Stats.UpdateStat(out _strength, _stats.Strength, SpecializationStatUpdateValue, Stats.Subtract );
                    Stats.UpdateStat(out _agility, _stats.Agility, SpecializationStatUpdateValue, Stats.Divide );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, SpecializationStatUpdateValue, Stats.Multipy );
                    break;
                case SpecializationType.Thief:
                    Stats.UpdateStat(out _strength, _stats.Strength, SpecializationStatUpdateValue, Stats.Add );
                    Stats.UpdateStat(out _agility, _stats.Agility, SpecializationStatUpdateValue, Stats.Subtract );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, SpecializationStatUpdateValue, Stats.Add );
                    break;
                case SpecializationType.Warrior:
                    Stats.UpdateStat(out _strength, _stats.Strength, SpecializationStatUpdateValue, Stats.Multipy );
                    Stats.UpdateStat(out _agility, _stats.Agility, SpecializationStatUpdateValue, Stats.Divide );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, SpecializationStatUpdateValue, Stats.Divide );
                    break;
            }
        }
    }
}