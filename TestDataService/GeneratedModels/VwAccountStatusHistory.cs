using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAccountStatusHistory")]
	public class VwAccountStatusHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ChangeDate")]
		public DateTime ChangeDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="NewStatusId")]
		public Guid NewStatusId { get; set; }
		[CProperty(ColumnPath ="OldStatusId")]
		public Guid OldStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountStatus:OldStatusId")]
		public AccountStatus OldStatus { get; set; }
		[CProperty(Navigation ="AccountStatus:NewStatusId")]
		public AccountStatus NewStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
