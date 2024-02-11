using System;
using Visitor.Enemies;

namespace Visitor
{
    public interface IEnemyLivecycleNotifier
    {
        event Action<Enemy> OnDeadNotified;
        event Action<Enemy> OnSpawnNotified;
    }
}
