using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QualifyStatus")]
	public class QualifyStatus : BaseEntity
	{
		#region Values
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
		private int _StageInnerOrder;
		[CProperty(ColumnPath ="StageInnerOrder")]
		public int StageInnerOrder
		{
			get{return _StageInnerOrder;}
			set
			{
				_StageInnerOrder = value;
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
		private int _StageOrder;
		[CProperty(ColumnPath ="StageOrder")]
		public int StageOrder
		{
			get{return _StageOrder;}
			set
			{
				_StageOrder = value;
				OnPropertyChanged();
			}
		}
		private bool _Successful;
		[CProperty(ColumnPath ="Successful")]
		public bool Successful
		{
			get{return _Successful;}
			set
			{
				_Successful = value;
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
		[CProperty(Association ="Lead:QualifyStatusId")]
		public virtual ICollection<Lead> LeadByQualifyStatus { get; set; }
		[CProperty(Association ="LeadDisqualifyReason:LeadStageId")]
		public virtual ICollection<LeadDisqualifyReason> LeadDisqualifyReasonByLeadStage { get; set; }
		[CProperty(Association ="LeadInQualifyStatus:QualifyStatusId")]
		public virtual ICollection<LeadInQualifyStatus> LeadInQualifyStatusByQualifyStatus { get; set; }
		[CProperty(Association ="LeadInStage:StatusId")]
		public virtual ICollection<LeadInStage> LeadInStageByStatus { get; set; }
		[CProperty(Association ="QualifyStatusDecoupling:CurrentStatusId")]
		public virtual ICollection<QualifyStatusDecoupling> QualifyStatusDecouplingByCurrentStatus { get; set; }
		[CProperty(Association ="QualifyStatusDecoupling:AvailableStatusId")]
		public virtual ICollection<QualifyStatusDecoupling> QualifyStatusDecouplingByAvailableStatus { get; set; }
		[CProperty(Association ="VwDisqualifyReasonMPP:LeadStageId")]
		public virtual ICollection<VwDisqualifyReasonMPP> VwDisqualifyReasonMPPByLeadStage { get; set; }
		[CProperty(Association ="VwDisqualifyReasonMRK:LeadStageId")]
		public virtual ICollection<VwDisqualifyReasonMRK> VwDisqualifyReasonMRKByLeadStage { get; set; }
		[CProperty(Association ="VwDisqualifyReasonPAM:LeadStageId")]
		public virtual ICollection<VwDisqualifyReasonPAM> VwDisqualifyReasonPAMByLeadStage { get; set; }
		[CProperty(Association ="VwLead:QualifyStatusId")]
		public virtual ICollection<VwLead> VwLeadByQualifyStatus { get; set; }
		#endregion
	}
}
