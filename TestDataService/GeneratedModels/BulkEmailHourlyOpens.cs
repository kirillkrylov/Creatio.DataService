using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailHourlyOpens")]
	public class BulkEmailHourlyOpens : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="DateMark")]
		public DateTime DateMark { get; set; }
		[CProperty(ColumnPath ="EventsCount")]
		public int EventsCount { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
