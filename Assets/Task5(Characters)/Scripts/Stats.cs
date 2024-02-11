namespace Task5_Characters_.Scripts
{
    public class Stats : IStats
    {
        private int _strength;
        private int _agility;
        private int _intelligence;

        public Stats(int strength, int agility, int intelligence)
        {
            _strength = strength;
            _agility = agility;
            _intelligence = intelligence;
        }
        
        public int Strength => _strength;
        public int Agility => _agility;
        public int Intelligence => _intelligence;

        public static void UpdateStat(out int stat, int initialValue, int updateValue, Operation operation)
        {
            stat = operation(initialValue, updateValue);
        }

        public static int Add(int firstValue, int secondValue) => firstValue + secondValue;
        public static int Subtract(int firstValue, int secondValue) => firstValue - secondValue;
        public static int Multipy(int firstValue, int secondValue) => firstValue * secondValue;
        public static int Divide(int firstValue, int secondValue) => firstValue / secondValue;

        public delegate int Operation(int firstValue, int secondValue);
    }
}