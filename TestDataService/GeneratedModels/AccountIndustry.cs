using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountIndustry")]
	public class AccountIndustry : BaseEntity
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
		private Guid _OpportunityDepartmentId;
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId
		{
			get{return _OpportunityDepartmentId;}
			set
			{
				_OpportunityDepartmentId = value;
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
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:IndustryId")]
		public virtual ICollection<Account> AccountByIndustry { get; set; }
		[CProperty(Association ="Event:IndustryId")]
		public virtual ICollection<Event> EventByIndustry { get; set; }
		[CProperty(Association ="KnowledgeBase:PDEIndustryId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDEIndustry { get; set; }
		[CProperty(Association ="Lead:IndustryId")]
		public virtual ICollection<Lead> LeadByIndustry { get; set; }
		[CProperty(Association ="LeadQualification:IndustryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByIndustry { get; set; }
		[CProperty(Association ="Opportunity:IndustryId")]
		public virtual ICollection<Opportunity> OpportunityByIndustry { get; set; }
		[CProperty(Association ="PartnerDomain:IndustryId")]
		public virtual ICollection<PartnerDomain> PartnerDomainByIndustry { get; set; }
		[CProperty(Association ="PDEIndustryInKnowledgeBase:PDEIndustryId")]
		public virtual ICollection<PDEIndustryInKnowledgeBase> PDEIndustryInKnowledgeBaseByPDEIndustry { get; set; }
		[CProperty(Association ="SubIndustry:IndustryId")]
		public virtual ICollection<SubIndustry> SubIndustryByIndustry { get; set; }
		[CProperty(Association ="VwLead:IndustryId")]
		public virtual ICollection<VwLead> VwLeadByIndustry { get; set; }
		#endregion
	}
}
