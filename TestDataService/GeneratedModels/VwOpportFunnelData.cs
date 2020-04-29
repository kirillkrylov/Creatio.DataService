using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOpportFunnelData")]
	public class VwOpportFunnelData : BaseEntity
	{
		#region Values
		private DateTime _fCreatedOn;
		[CProperty(ColumnPath ="fCreatedOn")]
		public DateTime fCreatedOn
		{
			get{return _fCreatedOn;}
			set
			{
				_fCreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _fDueDate;
		[CProperty(ColumnPath ="fDueDate")]
		public DateTime fDueDate
		{
			get{return _fDueDate;}
			set
			{
				_fDueDate = value;
				OnPropertyChanged();
			}
		}
		private bool _fEnd;
		[CProperty(ColumnPath ="fEnd")]
		public bool fEnd
		{
			get{return _fEnd;}
			set
			{
				_fEnd = value;
				OnPropertyChanged();
			}
		}
		private Guid _fStageId;
		[CProperty(ColumnPath ="fStageId")]
		public Guid fStageId
		{
			get{return _fStageId;}
			set
			{
				_fStageId = value;
				OnPropertyChanged();
			}
		}
		private int _fStageNumber;
		[CProperty(ColumnPath ="fStageNumber")]
		public int fStageNumber
		{
			get{return _fStageNumber;}
			set
			{
				_fStageNumber = value;
				OnPropertyChanged();
			}
		}
		private DateTime _fStartDate;
		[CProperty(ColumnPath ="fStartDate")]
		public DateTime fStartDate
		{
			get{return _fStartDate;}
			set
			{
				_fStartDate = value;
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
		private int _IsInStageConversion;
		[CProperty(ColumnPath ="IsInStageConversion")]
		public int IsInStageConversion
		{
			get{return _IsInStageConversion;}
			set
			{
				_IsInStageConversion = value;
				OnPropertyChanged();
			}
		}
		private DateTime _lCreatedOn;
		[CProperty(ColumnPath ="lCreatedOn")]
		public DateTime lCreatedOn
		{
			get{return _lCreatedOn;}
			set
			{
				_lCreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _lDueDate;
		[CProperty(ColumnPath ="lDueDate")]
		public DateTime lDueDate
		{
			get{return _lDueDate;}
			set
			{
				_lDueDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _lStageId;
		[CProperty(ColumnPath ="lStageId")]
		public Guid lStageId
		{
			get{return _lStageId;}
			set
			{
				_lStageId = value;
				OnPropertyChanged();
			}
		}
		private int _lStageNumber;
		[CProperty(ColumnPath ="lStageNumber")]
		public int lStageNumber
		{
			get{return _lStageNumber;}
			set
			{
				_lStageNumber = value;
				OnPropertyChanged();
			}
		}
		private DateTime _lStartDate;
		[CProperty(ColumnPath ="lStartDate")]
		public DateTime lStartDate
		{
			get{return _lStartDate;}
			set
			{
				_lStartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityStage:fStageId")]
		public OpportunityStage fStage { get; set; }
		[CProperty(Navigation ="OpportunityStage:lStageId")]
		public OpportunityStage lStage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
