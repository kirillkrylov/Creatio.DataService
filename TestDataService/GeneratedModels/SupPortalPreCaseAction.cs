using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupPortalPreCaseAction")]
	public class SupPortalPreCaseAction : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupDescription")]
		public string SupDescription { get; set; }
		[CProperty(ColumnPath ="SupSessionId")]
		public string SupSessionId { get; set; }
		[CProperty(ColumnPath ="SupSubject")]
		public string SupSubject { get; set; }
		[CProperty(ColumnPath ="SupTypeId")]
		public Guid SupTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupPortalPreCaseActionType:SupTypeId")]
		public SupPortalPreCaseActionType SupType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
