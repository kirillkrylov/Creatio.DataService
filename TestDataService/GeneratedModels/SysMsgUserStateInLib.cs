using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysMsgUserStateInLib")]
	public class SysMsgUserStateInLib : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysMsgLibId")]
		public Guid SysMsgLibId { get; set; }
		[CProperty(ColumnPath ="SysMsgUserStateId")]
		public Guid SysMsgUserStateId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysMsgLib:SysMsgLibId")]
		public SysMsgLib SysMsgLib { get; set; }
		[CProperty(Navigation ="SysMsgUserState:SysMsgUserStateId")]
		public SysMsgUserState SysMsgUserState { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
