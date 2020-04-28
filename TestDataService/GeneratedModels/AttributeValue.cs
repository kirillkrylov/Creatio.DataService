using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AttributeValue")]
	public class AttributeValue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AttributeId")]
		public Guid AttributeId { get; set; }
		[CProperty(ColumnPath ="BinaryValue")]
		public byte[] BinaryValue { get; set; }
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateTimeValue")]
		public DateTime DateTimeValue { get; set; }
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue { get; set; }
		[CProperty(ColumnPath ="GuidValue")]
		public Guid GuidValue { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegerValue")]
		public int IntegerValue { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Record")]
		public Guid Record { get; set; }
		[CProperty(ColumnPath ="TextValue")]
		public string TextValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Attribute:AttributeId")]
		public Attribute Attribute { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
