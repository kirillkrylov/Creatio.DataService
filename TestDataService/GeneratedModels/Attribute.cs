using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Attribute")]
	public class Attribute : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerSchemaId")]
		public Guid OwnerSchemaId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaId")]
		public Guid ReferenceSchemaId { get; set; }
		[CProperty(ColumnPath ="ValueType")]
		public Guid ValueType { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:OwnerSchemaId")]
		public SysSchema OwnerSchema { get; set; }
		[CProperty(Navigation ="SysSchema:ReferenceSchemaId")]
		public SysSchema ReferenceSchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeReferenceSchema:AttributeId")]
		public virtual ICollection<AttributeReferenceSchema> AttributeReferenceSchemaByAttribute { get; set; }
		[CProperty(Association ="AttributeValue:AttributeId")]
		public virtual ICollection<AttributeValue> AttributeValueByAttribute { get; set; }
		#endregion
	}
}
