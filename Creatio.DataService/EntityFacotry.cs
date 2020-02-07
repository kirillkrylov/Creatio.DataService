using System;

namespace Creatio.DataService
{
    static class EntityFacotry
    {
        public static Entity Create<Entity>() where Entity : BaseEntity, new()
        {
            return new Entity();
        }
    }
}
