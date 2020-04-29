using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOpportInStageForAnalysis")]
	public class VwOpportInStageForAnalysis : BaseEntity
	{
		#region Values
		private string _Comments;
		[CProperty(ColumnPath ="Comments")]
		public string Comments
		{
			get{return _Comments;}
			set
			{
				_Comments = value;
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
		private int _DaysInStage;
		[CProperty(ColumnPath ="DaysInStage")]
		public int DaysInStage
		{
			get{return _DaysInStage;}
			set
			{
				_DaysInStage = value;
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
		private int _Duration;
		[CProperty(ColumnPath ="Duration")]
		public int Duration
		{
			get{return _Duration;}
			set
			{
				_Duration = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityStage:StageId")]
		public OpportunityStage Stage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
