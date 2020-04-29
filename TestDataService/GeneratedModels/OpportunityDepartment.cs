using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityDepartment")]
	public class OpportunityDepartment : BaseEntity
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
		private Guid _IndustryProgressManagerUnitId;
		[CProperty(ColumnPath ="IndustryProgressManagerUnitId")]
		public Guid IndustryProgressManagerUnitId
		{
			get{return _IndustryProgressManagerUnitId;}
			set
			{
				_IndustryProgressManagerUnitId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsHidden;
		[CProperty(ColumnPath ="IsHidden")]
		public bool IsHidden
		{
			get{return _IsHidden;}
			set
			{
				_IsHidden = value;
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
		private Guid _MPPGroupLeaderUnitId;
		[CProperty(ColumnPath ="MPPGroupLeaderUnitId")]
		public Guid MPPGroupLeaderUnitId
		{
			get{return _MPPGroupLeaderUnitId;}
			set
			{
				_MPPGroupLeaderUnitId = value;
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
		private Guid _PracticeDirectorUnitId;
		[CProperty(ColumnPath ="PracticeDirectorUnitId")]
		public Guid PracticeDirectorUnitId
		{
			get{return _PracticeDirectorUnitId;}
			set
			{
				_PracticeDirectorUnitId = value;
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
		private Guid _SalesDirectorId;
		[CProperty(ColumnPath ="SalesDirectorId")]
		public Guid SalesDirectorId
		{
			get{return _SalesDirectorId;}
			set
			{
				_SalesDirectorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SalesManagerUnitId;
		[CProperty(ColumnPath ="SalesManagerUnitId")]
		public Guid SalesManagerUnitId
		{
			get{return _SalesManagerUnitId;}
			set
			{
				_SalesManagerUnitId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitId;
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId
		{
			get{return _SysAdminUnitId;}
			set
			{
				_SysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:SalesDirectorId")]
		public Contact SalesDirector { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:PracticeDirectorUnitId")]
		public SysAdminUnit PracticeDirectorUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SalesManagerUnitId")]
		public SysAdminUnit SalesManagerUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:IndustryProgressManagerUnitId")]
		public SysAdminUnit IndustryProgressManagerUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:MPPGroupLeaderUnitId")]
		public SysAdminUnit MPPGroupLeaderUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:OpportunityDepartmentId")]
		public virtual ICollection<Account> AccountByOpportunityDepartment { get; set; }
		[CProperty(Association ="AccountIndustry:OpportunityDepartmentId")]
		public virtual ICollection<AccountIndustry> AccountIndustryByOpportunityDepartment { get; set; }
		[CProperty(Association ="DepartmentTypeTerritory:OpportunityDepartmentId")]
		public virtual ICollection<DepartmentTypeTerritory> DepartmentTypeTerritoryByOpportunityDepartment { get; set; }
		[CProperty(Association ="GlbCustomer:GlbDepartmentId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbDepartment { get; set; }
		[CProperty(Association ="Lead:OpportunityDepartmentId")]
		public virtual ICollection<Lead> LeadByOpportunityDepartment { get; set; }
		[CProperty(Association ="LeadOwnerFillRule:OpportunityDepartmentId")]
		public virtual ICollection<LeadOwnerFillRule> LeadOwnerFillRuleByOpportunityDepartment { get; set; }
		[CProperty(Association ="LeadType:OpportunityDepartmentId")]
		public virtual ICollection<LeadType> LeadTypeByOpportunityDepartment { get; set; }
		[CProperty(Association ="OppDepartmentForecast:OpportunityDepartmentId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByOpportunityDepartment { get; set; }
		[CProperty(Association ="Opportunity:ResponsibleDepartmentId")]
		public virtual ICollection<Opportunity> OpportunityByResponsibleDepartment { get; set; }
		[CProperty(Association ="Project:ResponsibleDepartmentId")]
		public virtual ICollection<Project> ProjectByResponsibleDepartment { get; set; }
		[CProperty(Association ="PsProjectServers:OpportunityDepartmentId")]
		public virtual ICollection<PsProjectServers> PsProjectServersByOpportunityDepartment { get; set; }
		[CProperty(Association ="TsSalesCareer:OpportunityDepartmentId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByOpportunityDepartment { get; set; }
		[CProperty(Association ="VwLead:OpportunityDepartmentId")]
		public virtual ICollection<VwLead> VwLeadByOpportunityDepartment { get; set; }
		[CProperty(Association ="VwTsSalesCareer:OpportunityDepartmentId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByOpportunityDepartment { get; set; }
		#endregion
	}
}
