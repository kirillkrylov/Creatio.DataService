using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RecruitmentInStage")]
	public class RecruitmentInStage : BaseEntity
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeJobId;
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId
		{
			get{return _EmployeeJobId;}
			set
			{
				_EmployeeJobId = value;
				OnPropertyChanged();
			}
		}
		private bool _Historical;
		[CProperty(ColumnPath ="Historical")]
		public bool Historical
		{
			get{return _Historical;}
			set
			{
				_Historical = value;
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
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
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
		private Guid _RootEntityId;
		[CProperty(ColumnPath ="RootEntityId")]
		public Guid RootEntityId
		{
			get{return _RootEntityId;}
			set
			{
				_RootEntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageId;
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId
		{
			get{return _StageId;}
			set
			{
				_StageId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaId;
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId
		{
			get{return _SysSchemaId;}
			set
			{
				_SysSchemaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeOfChangeInApplicantId;
		[CProperty(ColumnPath ="TypeOfChangeInApplicantId")]
		public Guid TypeOfChangeInApplicantId
		{
			get{return _TypeOfChangeInApplicantId;}
			set
			{
				_TypeOfChangeInApplicantId = value;
				OnPropertyChanged();
			}
		}
		private string _Value;
		[CProperty(ColumnPath ="Value")]
		public string Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Applicant:RootEntityId")]
		public Applicant RootEntity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="EmployeeJob:EmployeeJobId")]
		public EmployeeJob EmployeeJob { get; set; }
		[CProperty(Navigation ="RecruitmentStage:StageId")]
		public RecruitmentStage Stage { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		[CProperty(Navigation ="TypeOfChangeApplicant:TypeOfChangeInApplicantId")]
		public TypeOfChangeApplicant TypeOfChangeInApplicant { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
