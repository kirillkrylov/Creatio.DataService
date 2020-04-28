using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRecentCall")]
	public class VwRecentCall : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CallId")]
		public Guid CallId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Call:CallId")]
		public Call Call { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
