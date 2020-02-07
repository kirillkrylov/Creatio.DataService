using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OPPEmailInitialStatus")]
	public class OPPEmailInitialStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="EmailAddress")]
		public string EmailAddress { get; set; }
		[CProperty(ColumnPath ="EmailResponseId")]
		public Guid EmailResponseId { get; set; }
		[CProperty(ColumnPath ="MandrillId")]
		public Guid MandrillId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
