using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysMsgLib")]
	public class SysMsgLib : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CtiProviderName")]
		public string CtiProviderName { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FullClassName")]
		public string FullClassName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LicOperations")]
		public string LicOperations { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SetupPageSchemaName")]
		public string SetupPageSchemaName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysMsgUserSettings:SysMsgLibId")]
		public virtual ICollection<SysMsgUserSettings> SysMsgUserSettingsBySysMsgLib { get; set; }
		[CProperty(Association ="SysMsgUserStateInLib:SysMsgLibId")]
		public virtual ICollection<SysMsgUserStateInLib> SysMsgUserStateInLibBySysMsgLib { get; set; }
		#endregion
	}
}
