using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SpecificationInLead")]
	public class SpecificationInLead : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntValue")]
		public int IntValue { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ListItemValueId")]
		public Guid ListItemValueId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		[CProperty(ColumnPath ="StringValue")]
		public string StringValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		[CProperty(Navigation ="SpecificationListItem:ListItemValueId")]
		public SpecificationListItem ListItemValue { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
