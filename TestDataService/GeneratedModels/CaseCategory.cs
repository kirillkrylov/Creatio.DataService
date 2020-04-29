using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseCategory")]
	public class CaseCategory : BaseEntity
	{
		#region Values
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
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
