using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysWorkplace")]
	public class SysWorkplace : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsPersonal")]
		public bool IsPersonal { get; set; }
		[CProperty(ColumnPath ="LoaderId")]
		public Guid LoaderId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysApplicationClientTypeId")]
		public Guid SysApplicationClientTypeId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysApplicationClientType:SysApplicationClientTypeId")]
		public SysApplicationClientType SysApplicationClientType { get; set; }
		[CProperty(Navigation ="SysWorkplaceType:TypeId")]
		public SysWorkplaceType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysAdminUnitInWorkplace:SysWorkplaceId")]
		public virtual ICollection<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaceBySysWorkplace { get; set; }
		[CProperty(Association ="SysModuleInWorkplace:SysWorkplaceId")]
		public virtual ICollection<SysModuleInWorkplace> SysModuleInWorkplaceBySysWorkplace { get; set; }
		#endregion
	}
}
