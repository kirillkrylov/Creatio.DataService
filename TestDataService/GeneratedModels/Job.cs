using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Job")]
	public class Job : BaseEntity
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
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
		[CProperty(Association ="Applicant:CurrentJobId")]
		public virtual ICollection<Applicant> ApplicantByCurrentJob { get; set; }
		[CProperty(Association ="Contact:JobId")]
		public virtual ICollection<Contact> ContactByJob { get; set; }
		[CProperty(Association ="ContactCareer:JobId")]
		public virtual ICollection<ContactCareer> ContactCareerByJob { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerList:GlbJobId")]
		public virtual ICollection<GlbCustomerKeyPlayerList> GlbCustomerKeyPlayerListByGlbJob { get; set; }
		[CProperty(Association ="Lead:JobId")]
		public virtual ICollection<Lead> LeadByJob { get; set; }
		[CProperty(Association ="LeadQualification:JobId")]
		public virtual ICollection<LeadQualification> LeadQualificationByJob { get; set; }
		[CProperty(Association ="OpportunityContact:JobId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByJob { get; set; }
		[CProperty(Association ="PainChain:JobId")]
		public virtual ICollection<PainChain> PainChainByJob { get; set; }
		[CProperty(Association ="PainChainItem:JobId")]
		public virtual ICollection<PainChainItem> PainChainItemByJob { get; set; }
		[CProperty(Association ="PainReason:JobId")]
		public virtual ICollection<PainReason> PainReasonByJob { get; set; }
		[CProperty(Association ="ProjectRole:JobTitleId")]
		public virtual ICollection<ProjectRole> ProjectRoleByJobTitle { get; set; }
		[CProperty(Association ="VwEventInContact:JobId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByJob { get; set; }
		[CProperty(Association ="VwLead:JobId")]
		public virtual ICollection<VwLead> VwLeadByJob { get; set; }
		#endregion
	}
}
