using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProfileData")]
	public class SysProfileData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Key")]
		public string Key { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ObjectData")]
		public byte[] ObjectData { get; set; }
		[CProperty(ColumnPath ="ObjectDifference")]
		public byte[] ObjectDifference { get; set; }
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId { get; set; }
		[CProperty(ColumnPath ="SysUserId")]
		public Guid SysUserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysUserId")]
		public SysAdminUnit SysUser { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
