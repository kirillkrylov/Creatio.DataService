using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeCareer")]
	public class EmployeeCareer : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
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
		private Guid _DismissalInitiatorId;
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId
		{
			get{return _DismissalInitiatorId;}
			set
			{
				_DismissalInitiatorId = value;
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
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
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
		private bool _EndInCompany;
		[CProperty(ColumnPath ="EndInCompany")]
		public bool EndInCompany
		{
			get{return _EndInCompany;}
			set
			{
				_EndInCompany = value;
				OnPropertyChanged();
			}
		}
		private string _FullJobTitle;
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle
		{
			get{return _FullJobTitle;}
			set
			{
				_FullJobTitle = value;
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
		private bool _IsCurrent;
		[CProperty(ColumnPath ="IsCurrent")]
		public bool IsCurrent
		{
			get{return _IsCurrent;}
			set
			{
				_IsCurrent = value;
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
		private Guid _OrgStructureUnitId;
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId
		{
			get{return _OrgStructureUnitId;}
			set
			{
				_OrgStructureUnitId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ProbationDueDate;
		[CProperty(ColumnPath ="ProbationDueDate")]
		public DateTime ProbationDueDate
		{
			get{return _ProbationDueDate;}
			set
			{
				_ProbationDueDate = value;
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
		private Guid _ReasonForDismissalId;
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId
		{
			get{return _ReasonForDismissalId;}
			set
			{
				_ReasonForDismissalId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StaffUnitId;
		[CProperty(ColumnPath ="StaffUnitId")]
		public Guid StaffUnitId
		{
			get{return _StaffUnitId;}
			set
			{
				_StaffUnitId = value;
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
		private bool _StartInCompany;
		[CProperty(ColumnPath ="StartInCompany")]
		public bool StartInCompany
		{
			get{return _StartInCompany;}
			set
			{
				_StartInCompany = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DismissalInitiator:DismissalInitiatorId")]
		public DismissalInitiator DismissalInitiator { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:EmployeeJobId")]
		public EmployeeJob EmployeeJob { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:OrgStructureUnitId")]
		public OrgStructureUnit OrgStructureUnit { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:StaffUnitId")]
		public OrgStructureUnit StaffUnit { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:ReasonForDismissalId")]
		public ReasonForLeaving ReasonForDismissal { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
