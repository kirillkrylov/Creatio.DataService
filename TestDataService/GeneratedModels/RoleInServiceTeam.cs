using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RoleInServiceTeam")]
	public class RoleInServiceTeam : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="Case:SolvedOnSupportLevelId")]
		public virtual ICollection<Case> CaseBySolvedOnSupportLevel { get; set; }
		[CProperty(Association ="Case:SupportLevelId")]
		public virtual ICollection<Case> CaseBySupportLevel { get; set; }
		[CProperty(Association ="CaseLifecycle:SupportLevelId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleBySupportLevel { get; set; }
		[CProperty(Association ="ServiceEngineer:SupportLevelId")]
		public virtual ICollection<ServiceEngineer> ServiceEngineerBySupportLevel { get; set; }
		[CProperty(Association ="SupCloudCaseDefValue:SupSupportLevelId")]
		public virtual ICollection<SupCloudCaseDefValue> SupCloudCaseDefValueBySupSupportLevel { get; set; }
		#endregion
	}
}
