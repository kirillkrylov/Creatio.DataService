using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCustomScore")]
	public class SupCustomScore : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="SupAccountId")]
		public Guid SupAccountId { get; set; }
		[CProperty(ColumnPath ="SupEndDate")]
		public DateTime SupEndDate { get; set; }
		[CProperty(ColumnPath ="SupNote")]
		public string SupNote { get; set; }
		[CProperty(ColumnPath ="SupScore")]
		public int SupScore { get; set; }
		[CProperty(ColumnPath ="SupStartDate")]
		public DateTime SupStartDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:SupAccountId")]
		public Account SupAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
