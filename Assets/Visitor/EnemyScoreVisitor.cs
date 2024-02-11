using Visitor.Enemies;

namespace Visitor
{
    public class EnemyScoreVisitor : IEnemyVisitor
    {
        public int Score { get; private set; }

        public void Visit(Ork ork) => Score += 20;

        public void Visit(Human human) => Score += 5;

        public void Visit(Elf elf) => Score += 10;

        public void Visit(Robot robot) => Score += 15;

        public void Visit(Enemy enemy) => Visit((dynamic) enemy);
    }
}