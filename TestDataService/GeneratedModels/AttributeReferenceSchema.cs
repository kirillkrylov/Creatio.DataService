using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AttributeReferenceSchema")]
	public class AttributeReferenceSchema : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AttributeId")]
		public Guid AttributeId { get; set; }
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
		[CProperty(ColumnPath ="ReferenceSchemaId")]
		public Guid ReferenceSchemaId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Attribute:AttributeId")]
		public Attribute Attribute { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:ReferenceSchemaId")]
		public SysSchema ReferenceSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
