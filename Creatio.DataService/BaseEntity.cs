using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Creatio.DataService.Attributes;

namespace Creatio.DataService
{
    public class BaseEntity
    {
        [QueryColumn("Id")]
        public Guid Id{ get; set; }

        public async Task<Entity> Expnad<Entity>(Guid Id) where Entity : BaseEntity, new()
        {
            Utils utils = Utils.Instance;
            List<Entity> baseEntity = await utils.Select<Entity>(Id.ToString());
            return baseEntity[0];
        }



    }
}
