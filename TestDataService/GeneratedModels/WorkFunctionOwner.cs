using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkFunctionOwner")]
	public class WorkFunctionOwner : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseSubTypeId")]
		public Guid CaseSubTypeId { get; set; }
		[CProperty(ColumnPath ="CaseTypeId")]
		public Guid CaseTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StakeholderId")]
		public Guid StakeholderId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseSubtype:CaseSubTypeId")]
		public CaseSubtype CaseSubType { get; set; }
		[CProperty(Navigation ="CaseType:CaseTypeId")]
		public CaseType CaseType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:StakeholderId")]
		public Contact Stakeholder { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
