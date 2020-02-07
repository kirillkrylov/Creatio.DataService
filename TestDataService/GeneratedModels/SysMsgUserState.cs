using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysMsgUserState")]
	public class SysMsgUserState : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="IconId")]
		public Guid IconId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="IsDisplayOnly")]
		public bool IsDisplayOnly { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		[CProperty(Navigation ="SysMsgUserStateIcon:IconId")]
		public SysMsgUserStateIcon Icon { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysMsgUserStateInLib:SysMsgUserStateId")]
		public virtual ICollection<SysMsgUserStateInLib> SysMsgUserStateInLibBySysMsgUserState { get; set; }
		[CProperty(Association ="SysMsgUserStateReason:SysMsgUserStateId")]
		public virtual ICollection<SysMsgUserStateReason> SysMsgUserStateReasonBySysMsgUserState { get; set; }
		#endregion
	}
}
