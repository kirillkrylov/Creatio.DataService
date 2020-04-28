using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseCategory")]
	public class CaseCategory : BaseEntity
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
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
		[CProperty(Association ="Case:CategoryId")]
		public virtual ICollection<Case> CaseByCategory { get; set; }
		[CProperty(Association ="CaseCategoryRole:CaseCategoryId")]
		public virtual ICollection<CaseCategoryRole> CaseCategoryRoleByCaseCategory { get; set; }
		[CProperty(Association ="CaseLifecycle:CategoryId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByCategory { get; set; }
		[CProperty(Association ="CaseNotificationRule:CaseCategoryId")]
		public virtual ICollection<CaseNotificationRule> CaseNotificationRuleByCaseCategory { get; set; }
		[CProperty(Association ="CaseOriginInCategory:CaseCategoryId")]
		public virtual ICollection<CaseOriginInCategory> CaseOriginInCategoryByCaseCategory { get; set; }
		[CProperty(Association ="CaseType:CaseCategoryId")]
		public virtual ICollection<CaseType> CaseTypeByCaseCategory { get; set; }
		[CProperty(Association ="labActualizeRule:labCaseCategoryId")]
		public virtual ICollection<labActualizeRule> labActualizeRuleBylabCaseCategory { get; set; }
		[CProperty(Association ="MailboxForIncidentRegistration:CategoryId")]
		public virtual ICollection<MailboxForIncidentRegistration> MailboxForIncidentRegistrationByCategory { get; set; }
		[CProperty(Association ="MailboxForIncidentRegistration:CaseCategoryId")]
		public virtual ICollection<MailboxForIncidentRegistration> MailboxForIncidentRegistrationByCaseCategory { get; set; }
		[CProperty(Association ="ServiceItem:CaseCategoryId")]
		public virtual ICollection<ServiceItem> ServiceItemByCaseCategory { get; set; }
		[CProperty(Association ="SupCaseCategoryByRole:SupCaseCategoryId")]
		public virtual ICollection<SupCaseCategoryByRole> SupCaseCategoryByRoleBySupCaseCategory { get; set; }
		[CProperty(Association ="TsOwnerGroupForCase:CaseCategoryId")]
		public virtual ICollection<TsOwnerGroupForCase> TsOwnerGroupForCaseByCaseCategory { get; set; }
		[CProperty(Association ="VwCaseDashboard:CategoryId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByCategory { get; set; }
		#endregion
	}
}
