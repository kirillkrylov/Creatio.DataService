using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffSkillPeriodValueVisa")]
	public class TsStaffSkillPeriodValueVisa : BaseEntity
	{
		#region Values
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfirmedById;
		[CProperty(ColumnPath ="ConfirmedById")]
		public Guid ConfirmedById
		{
			get{return _ConfirmedById;}
			set
			{
				_ConfirmedById = value;
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
		private Guid _DelegatedFromId;
		[CProperty(ColumnPath ="DelegatedFromId")]
		public Guid DelegatedFromId
		{
			get{return _DelegatedFromId;}
			set
			{
				_DelegatedFromId = value;
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
		private string _HeadComment;
		[CProperty(ColumnPath ="HeadComment")]
		public string HeadComment
		{
			get{return _HeadComment;}
			set
			{
				_HeadComment = value;
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
		private bool _IsAllowedToDelegate;
		[CProperty(ColumnPath ="IsAllowedToDelegate")]
		public bool IsAllowedToDelegate
		{
			get{return _IsAllowedToDelegate;}
			set
			{
				_IsAllowedToDelegate = value;
				OnPropertyChanged();
			}
		}
		private bool _IsCanceled;
		[CProperty(ColumnPath ="IsCanceled")]
		public bool IsCanceled
		{
			get{return _IsCanceled;}
			set
			{
				_IsCanceled = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRequiredDigitalSignature;
		[CProperty(ColumnPath ="IsRequiredDigitalSignature")]
		public bool IsRequiredDigitalSignature
		{
			get{return _IsRequiredDigitalSignature;}
			set
			{
				_IsRequiredDigitalSignature = value;
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
		private string _Objective;
		[CProperty(ColumnPath ="Objective")]
		public string Objective
		{
			get{return _Objective;}
			set
			{
				_Objective = value;
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
		private Guid _SetById;
		[CProperty(ColumnPath ="SetById")]
		public Guid SetById
		{
			get{return _SetById;}
			set
			{
				_SetById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SetDate;
		[CProperty(ColumnPath ="SetDate")]
		public DateTime SetDate
		{
			get{return _SetDate;}
			set
			{
				_SetDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _SkillValue;
		[CProperty(ColumnPath ="SkillValue")]
		public decimal SkillValue
		{
			get{return _SkillValue;}
			set
			{
				_SkillValue = value;
				OnPropertyChanged();
			}
		}
		private string _StaffComment;
		[CProperty(ColumnPath ="StaffComment")]
		public string StaffComment
		{
			get{return _StaffComment;}
			set
			{
				_StaffComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _StaffSkillPeriodValueId;
		[CProperty(ColumnPath ="StaffSkillPeriodValueId")]
		public Guid StaffSkillPeriodValueId
		{
			get{return _StaffSkillPeriodValueId;}
			set
			{
				_StaffSkillPeriodValueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _VisaOwnerId;
		[CProperty(ColumnPath ="VisaOwnerId")]
		public Guid VisaOwnerId
		{
			get{return _VisaOwnerId;}
			set
			{
				_VisaOwnerId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:SetById")]
		public Contact SetBy { get; set; }
		[CProperty(Navigation ="Contact:ConfirmedById")]
		public Contact ConfirmedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="SysAdminUnit:VisaOwnerId")]
		public SysAdminUnit VisaOwner { get; set; }
		[CProperty(Navigation ="SysAdminUnit:DelegatedFromId")]
		public SysAdminUnit DelegatedFrom { get; set; }
		[CProperty(Navigation ="TsStaffSkillPeriodValue:StaffSkillPeriodValueId")]
		public TsStaffSkillPeriodValue StaffSkillPeriodValue { get; set; }
		[CProperty(Navigation ="VisaStatus:StatusId")]
		public VisaStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
