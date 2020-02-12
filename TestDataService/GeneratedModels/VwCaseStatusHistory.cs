using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCaseStatusHistory")]
	public class VwCaseStatusHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NewStatusId")]
		public Guid NewStatusId { get; set; }
		[CProperty(ColumnPath ="OldStatusId")]
		public Guid OldStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="CaseStatus:OldStatusId")]
		public CaseStatus OldStatus { get; set; }
		[CProperty(Navigation ="CaseStatus:NewStatusId")]
		public CaseStatus NewStatus { get; set; }
		[CProperty(Navigation ="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
