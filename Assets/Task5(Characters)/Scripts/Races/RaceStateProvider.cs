namespace Task5_Characters_.Scripts.Races
{
    public class RaceStateProvider : IStats
    {
        private const int RaceStatUpdateValue = 2;
        
        private RaceType _raceType;
        private IStats _stats;

        private int _strength;
        private int _agility;
        private int _intelligence;

        public RaceStateProvider(IStats stats, RaceType race) 
        {
            _stats = stats;
            _raceType = race;
            
            UpdateStats(_raceType);
        }

        private void UpdateStats(RaceType race)
        {
            switch (race)
            {
                case RaceType.Elf:
                    Stats.UpdateStat(out _strength, _stats.Strength, RaceStatUpdateValue, Stats.Subtract );
                    Stats.UpdateStat(out _agility, _stats.Agility, RaceStatUpdateValue, Stats.Multipy );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, RaceStatUpdateValue, Stats.Add );
                    break;
                case RaceType.Human:
                    Stats.UpdateStat(out _strength, _stats.Strength, RaceStatUpdateValue, Stats.Add );
                    Stats.UpdateStat(out _agility, _stats.Agility, RaceStatUpdateValue, Stats.Subtract );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, RaceStatUpdateValue, Stats.Subtract );
                    break;
                case RaceType.Ork:
                    Stats.UpdateStat(out _strength, _stats.Strength, RaceStatUpdateValue, Stats.Multipy );
                    Stats.UpdateStat(out _agility, _stats.Agility, RaceStatUpdateValue, Stats.Divide );
                    Stats.UpdateStat(out _intelligence, _stats.Intelligence, RaceStatUpdateValue, Stats.Divide );
                    break;
            }
        }

        public int Strength => _strength;
        public int Agility => _agility;
        public int Intelligence => _intelligence;
    }
}