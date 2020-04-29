using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeJob")]
	public class EmployeeJob : BaseEntity
	{
		#region Values
		private bool _Core;
		[CProperty(ColumnPath ="Core")]
		public bool Core
		{
			get{return _Core;}
			set
			{
				_Core = value;
				OnPropertyChanged();
			}
		}
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
		private bool _Director;
		[CProperty(ColumnPath ="Director")]
		public bool Director
		{
			get{return _Director;}
			set
			{
				_Director = value;
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
		private bool _Phone;
		[CProperty(ColumnPath ="Phone")]
		public bool Phone
		{
			get{return _Phone;}
			set
			{
				_Phone = value;
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
		private int _SLA;
		[CProperty(ColumnPath ="SLA")]
		public int SLA
		{
			get{return _SLA;}
			set
			{
				_SLA = value;
				OnPropertyChanged();
			}
		}
		private bool _VirtualMachine;
		[CProperty(ColumnPath ="VirtualMachine")]
		public bool VirtualMachine
		{
			get{return _VirtualMachine;}
			set
			{
				_VirtualMachine = value;
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
		[CProperty(Association ="Applicant:JobId")]
		public virtual ICollection<Applicant> ApplicantByJob { get; set; }
		[CProperty(Association ="CompetencesByRoles:RoleId")]
		public virtual ICollection<CompetencesByRoles> CompetencesByRolesByRole { get; set; }
		[CProperty(Association ="Employee:JobId")]
		public virtual ICollection<Employee> EmployeeByJob { get; set; }
		[CProperty(Association ="EmployeeCareer:EmployeeJobId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByEmployeeJob { get; set; }
		[CProperty(Association ="HRTalks:RoleINcompanyId")]
		public virtual ICollection<HRTalks> HRTalksByRoleINcompany { get; set; }
		[CProperty(Association ="InteractionWithManager:RoleInCompanyId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByRoleInCompany { get; set; }
		[CProperty(Association ="InternalRequest:EmployeeJobId")]
		public virtual ICollection<InternalRequest> InternalRequestByEmployeeJob { get; set; }
		[CProperty(Association ="LeadQueueOperatorsJobs:EmployeeJobId")]
		public virtual ICollection<LeadQueueOperatorsJobs> LeadQueueOperatorsJobsByEmployeeJob { get; set; }
		[CProperty(Association ="OrgStructureUnit:JobId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByJob { get; set; }
		[CProperty(Association ="RecruitmentInStage:EmployeeJobId")]
		public virtual ICollection<RecruitmentInStage> RecruitmentInStageByEmployeeJob { get; set; }
		[CProperty(Association ="SMHealthCheck:RoleId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByRole { get; set; }
		#endregion
	}
}
