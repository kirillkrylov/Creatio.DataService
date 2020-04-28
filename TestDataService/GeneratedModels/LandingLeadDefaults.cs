using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LandingLeadDefaults")]
	public class LandingLeadDefaults : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue { get; set; }
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateTimeValue")]
		public DateTime DateTimeValue { get; set; }
		[CProperty(ColumnPath ="DisplayValue")]
		public string DisplayValue { get; set; }
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue { get; set; }
		[CProperty(ColumnPath ="GuidValue")]
		public Guid GuidValue { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegerValue")]
		public int IntegerValue { get; set; }
		[CProperty(ColumnPath ="LandingId")]
		public Guid LandingId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TextValue")]
		public string TextValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:LandingId")]
		public GeneratedWebForm Landing { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
