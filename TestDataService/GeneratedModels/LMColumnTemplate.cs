using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LMColumnTemplate")]
	public class LMColumnTemplate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsLink")]
		public bool IsLink { get; set; }
		[CProperty(ColumnPath ="IsOnChange")]
		public bool IsOnChange { get; set; }
		[CProperty(ColumnPath ="LMStartEventId")]
		public Guid LMStartEventId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LMStartEvent:LMStartEventId")]
		public LMStartEvent LMStartEvent { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
