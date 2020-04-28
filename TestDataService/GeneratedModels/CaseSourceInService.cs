using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseSourceInService")]
	public class CaseSourceInService : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseSourceId")]
		public Guid CaseSourceId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseOrigin:CaseSourceId")]
		public CaseOrigin CaseSource { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
