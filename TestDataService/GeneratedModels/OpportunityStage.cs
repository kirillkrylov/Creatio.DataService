using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityStage")]
	public class OpportunityStage : BaseEntity
	{
		#region Values
		private bool _CloseReasonVisible;
		[CProperty(ColumnPath ="CloseReasonVisible")]
		public bool CloseReasonVisible
		{
			get{return _CloseReasonVisible;}
			set
			{
				_CloseReasonVisible = value;
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
		private bool _End;
		[CProperty(ColumnPath ="End")]
		public bool End
		{
			get{return _End;}
			set
			{
				_End = value;
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
		private int _MaxProbability;
		[CProperty(ColumnPath ="MaxProbability")]
		public int MaxProbability
		{
			get{return _MaxProbability;}
			set
			{
				_MaxProbability = value;
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
		private int _NextStepTerm;
		[CProperty(ColumnPath ="NextStepTerm")]
		public int NextStepTerm
		{
			get{return _NextStepTerm;}
			set
			{
				_NextStepTerm = value;
				OnPropertyChanged();
			}
		}
		private bool _NotUse;
		[CProperty(ColumnPath ="NotUse")]
		public bool NotUse
		{
			get{return _NotUse;}
			set
			{
				_NotUse = value;
				OnPropertyChanged();
			}
		}
		private int _Number;
		[CProperty(ColumnPath ="Number")]
		public int Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private bool _ShowInFunnel;
		[CProperty(ColumnPath ="ShowInFunnel")]
		public bool ShowInFunnel
		{
			get{return _ShowInFunnel;}
			set
			{
				_ShowInFunnel = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowInProgressBar;
		[CProperty(ColumnPath ="ShowInProgressBar")]
		public bool ShowInProgressBar
		{
			get{return _ShowInProgressBar;}
			set
			{
				_ShowInProgressBar = value;
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
		private bool _UseInOpportunityFunnel;
		[CProperty(ColumnPath ="UseInOpportunityFunnel")]
		public bool UseInOpportunityFunnel
		{
			get{return _UseInOpportunityFunnel;}
			set
			{
				_UseInOpportunityFunnel = value;
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
		[CProperty(Association ="Lead:OpportunityStageId")]
		public virtual ICollection<Lead> LeadByOpportunityStage { get; set; }
		[CProperty(Association ="Opportunity:StageId")]
		public virtual ICollection<Opportunity> OpportunityByStage { get; set; }
		[CProperty(Association ="OpportunityCloseReason:OpportunityStageId")]
		public virtual ICollection<OpportunityCloseReason> OpportunityCloseReasonByOpportunityStage { get; set; }
		[CProperty(Association ="OpportunityInStage:StageId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByStage { get; set; }
		[CProperty(Association ="OpportunitySignal:NexStageId")]
		public virtual ICollection<OpportunitySignal> OpportunitySignalByNexStage { get; set; }
		[CProperty(Association ="OppStageDecoupling:CurrentStageId")]
		public virtual ICollection<OppStageDecoupling> OppStageDecouplingByCurrentStage { get; set; }
		[CProperty(Association ="OppStageDecoupling:AvailableStageId")]
		public virtual ICollection<OppStageDecoupling> OppStageDecouplingByAvailableStage { get; set; }
		[CProperty(Association ="OppSubProcessHistory:StageId")]
		public virtual ICollection<OppSubProcessHistory> OppSubProcessHistoryByStage { get; set; }
		[CProperty(Association ="VwLead:OpportunityStageId")]
		public virtual ICollection<VwLead> VwLeadByOpportunityStage { get; set; }
		[CProperty(Association ="VwOpportFunnelData:fStageId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataByfStage { get; set; }
		[CProperty(Association ="VwOpportFunnelData:lStageId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataBylStage { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:StageId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByStage { get; set; }
		[CProperty(Association ="VwOpportunityInStage:StageId")]
		public virtual ICollection<VwOpportunityInStage> VwOpportunityInStageByStage { get; set; }
		[CProperty(Association ="VwPortalOpportunity:StageId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByStage { get; set; }
		#endregion
	}
}
