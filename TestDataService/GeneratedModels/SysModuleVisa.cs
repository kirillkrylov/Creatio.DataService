using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleVisa")]
	public class SysModuleVisa : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MasterColumnUId")]
		public Guid MasterColumnUId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UseCustomNotificationProvider")]
		public bool UseCustomNotificationProvider { get; set; }
		[CProperty(ColumnPath ="VisaSchemaUId")]
		public Guid VisaSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleBySysModuleVisa { get; set; }
		[CProperty(Association ="SysModule:SysModuleVisaId")]
		public virtual ICollection<SysModule> SysModuleBySysModuleVisa { get; set; }
		#endregion
	}
}
