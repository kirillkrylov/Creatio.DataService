using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseStatus")]
	public class CaseStatus : BaseEntity
	{
		#region Values
		private string _ButtonCaption;
		[CProperty(ColumnPath ="ButtonCaption")]
		public string ButtonCaption
		{
			get{return _ButtonCaption;}
			set
			{
				_ButtonCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClosureCodeId;
		[CProperty(ColumnPath ="ClosureCodeId")]
		public Guid ClosureCodeId
		{
			get{return _ClosureCodeId;}
			set
			{
				_ClosureCodeId = value;
				OnPropertyChanged();
			}
		}
		private string _Color;
		[CProperty(ColumnPath ="Color")]
		public string Color
		{
			get{return _Color;}
			set
			{
				_Color = value;
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsCloseOnSave;
		[CProperty(ColumnPath ="IsCloseOnSave")]
		public bool IsCloseOnSave
		{
			get{return _IsCloseOnSave;}
			set
			{
				_IsCloseOnSave = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDisplayed;
		[CProperty(ColumnPath ="IsDisplayed")]
		public bool IsDisplayed
		{
			get{return _IsDisplayed;}
			set
			{
				_IsDisplayed = value;
				OnPropertyChanged();
			}
		}
		private bool _IsFinal;
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal
		{
			get{return _IsFinal;}
			set
			{
				_IsFinal = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPaused;
		[CProperty(ColumnPath ="IsPaused")]
		public bool IsPaused
		{
			get{return _IsPaused;}
			set
			{
				_IsPaused = value;
				OnPropertyChanged();
			}
		}
		private bool _IsResolved;
		[CProperty(ColumnPath ="IsResolved")]
		public bool IsResolved
		{
			get{return _IsResolved;}
			set
			{
				_IsResolved = value;
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
		private int _StageNumber;
		[CProperty(ColumnPath ="StageNumber")]
		public int StageNumber
		{
			get{return _StageNumber;}
			set
			{
				_StageNumber = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ClosureCode:ClosureCodeId")]
		public ClosureCode ClosureCode { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:StatusId")]
		public virtual ICollection<Case> CaseByStatus { get; set; }
		[CProperty(Association ="CaseLifecycle:StatusId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByStatus { get; set; }
		[CProperty(Association ="CaseNextStatus:StatusId")]
		public virtual ICollection<CaseNextStatus> CaseNextStatusByStatus { get; set; }
		[CProperty(Association ="CaseNextStatus:NextStatusId")]
		public virtual ICollection<CaseNextStatus> CaseNextStatusByNextStatus { get; set; }
		[CProperty(Association ="CaseNotificationRule:CaseStatusId")]
		public virtual ICollection<CaseNotificationRule> CaseNotificationRuleByCaseStatus { get; set; }
		[CProperty(Association ="SatisfactionLevel:StatusId")]
		public virtual ICollection<SatisfactionLevel> SatisfactionLevelByStatus { get; set; }
		[CProperty(Association ="TsEmailNotification:CaseStatusId")]
		public virtual ICollection<TsEmailNotification> TsEmailNotificationByCaseStatus { get; set; }
		[CProperty(Association ="VwCaseDashboard:StatusId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByStatus { get; set; }
		[CProperty(Association ="VwCaseStatusHistory:OldStatusId")]
		public virtual ICollection<VwCaseStatusHistory> VwCaseStatusHistoryByOldStatus { get; set; }
		[CProperty(Association ="VwCaseStatusHistory:NewStatusId")]
		public virtual ICollection<VwCaseStatusHistory> VwCaseStatusHistoryByNewStatus { get; set; }
		#endregion
	}
}
