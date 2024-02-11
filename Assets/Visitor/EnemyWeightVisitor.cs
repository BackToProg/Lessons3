using Visitor.Enemies;

namespace Visitor
{
    public class EnemyWeightVisitor : IEnemyVisitor
    {
        public int Value { get; private set; }

        public void Visit(Enemy enemy) => Visit((dynamic)enemy);

        public void Visit(Ork ork) => Value++;

        public void Visit(Human human) => Value++;

        public void Visit(Elf elf) => Value++;

        public void Visit(Robot robot) => Value++;
    }
}