using System;
using System.Collections.Generic;
using System.Text;

namespace Creatio.DataService
{
    public class UpdateQuery : BaseFilterableQuery, IReturn<BaseResponse>, IReturn
    {

        public UpdateQuery() 
        {
            ColumnValues = new ColumnValues();
        }
        //
        // Summary:
        //     Query type.
        public override Enums.QueryType QueryType { get; }
        
        //
        // Summary:
        //     Parameter indicating the need to force a query in the database.
        public bool IsForceUpdate { get; set; }
        
        //
        // Summary:
        //     Parameter indicating the need to insert a record if it not exists in db.
        public bool IsUpsert { get; set; }
    }
}
