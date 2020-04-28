using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCallLeadProcess")]
	public class VwCallLeadProcess : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CallTitle")]
		public string CallTitle { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="OppName")]
		public string OppName { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
