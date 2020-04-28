using System;
using System.Collections.Generic;
using System.Text;

namespace Creatio.DataService
{
    public class DeleteQuery : BaseFilterableQuery, IReturn<BaseResponse>, IReturn
    {
        public override Enums.QueryType QueryType { get; }
        public Enums.QuerySource QuerySource { get; set; }

        public DeleteQuery() { }
    }
}
