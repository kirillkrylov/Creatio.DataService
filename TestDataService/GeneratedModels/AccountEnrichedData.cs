using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountEnrichedData")]
	public class AccountEnrichedData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CategoryTag")]
		public string CategoryTag { get; set; }
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
		[CProperty(ColumnPath ="SearchDate")]
		public DateTime SearchDate { get; set; }
		[CProperty(ColumnPath ="Value")]
		public string Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
