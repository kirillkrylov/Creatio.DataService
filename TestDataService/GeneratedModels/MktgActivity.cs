using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MktgActivity")]
	public class MktgActivity : BaseEntity
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
		private bool _Approval;
		[CProperty(ColumnPath ="Approval")]
		public bool Approval
		{
			get{return _Approval;}
			set
			{
				_Approval = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignPlannerId;
		[CProperty(ColumnPath ="CampaignPlannerId")]
		public Guid CampaignPlannerId
		{
			get{return _CampaignPlannerId;}
			set
			{
				_CampaignPlannerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChannelId;
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId
		{
			get{return _ChannelId;}
			set
			{
				_ChannelId = value;
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
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
		private Guid _FundId;
		[CProperty(ColumnPath ="FundId")]
		public Guid FundId
		{
			get{return _FundId;}
			set
			{
				_FundId = value;
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
		private Guid _MktgActivityTypeId;
		[CProperty(ColumnPath ="MktgActivityTypeId")]
		public Guid MktgActivityTypeId
		{
			get{return _MktgActivityTypeId;}
			set
			{
				_MktgActivityTypeId = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
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
		private Guid _PartnershipId;
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId
		{
			get{return _PartnershipId;}
			set
			{
				_PartnershipId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlannedBudget;
		[CProperty(ColumnPath ="PlannedBudget")]
		public decimal PlannedBudget
		{
			get{return _PlannedBudget;}
			set
			{
				_PlannedBudget = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPlannedBudget;
		[CProperty(ColumnPath ="PrimaryPlannedBudget")]
		public decimal PrimaryPlannedBudget
		{
			get{return _PrimaryPlannedBudget;}
			set
			{
				_PrimaryPlannedBudget = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimarySpentBudget;
		[CProperty(ColumnPath ="PrimarySpentBudget")]
		public decimal PrimarySpentBudget
		{
			get{return _PrimarySpentBudget;}
			set
			{
				_PrimarySpentBudget = value;
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
		private decimal _SpentBudget;
		[CProperty(ColumnPath ="SpentBudget")]
		public decimal SpentBudget
		{
			get{return _SpentBudget;}
			set
			{
				_SpentBudget = value;
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
		private string _Url;
		[CProperty(ColumnPath ="Url")]
		public string Url
		{
			get{return _Url;}
			set
			{
				_Url = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="CampaignPlanner:CampaignPlannerId")]
		public CampaignPlanner CampaignPlanner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Fund:FundId")]
		public Fund Fund { get; set; }
		[CProperty(Navigation ="LeadMedium:ChannelId")]
		public LeadMedium Channel { get; set; }
		[CProperty(Navigation ="MktgActivityStatus:StatusId")]
		public MktgActivityStatus Status { get; set; }
		[CProperty(Navigation ="MktgActivityType:MktgActivityTypeId")]
		public MktgActivityType MktgActivityType { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MktgActivityFile:MktgActivityId")]
		public virtual ICollection<MktgActivityFile> MktgActivityFileByMktgActivity { get; set; }
		[CProperty(Association ="MktgActivityInFolder:MktgActivityId")]
		public virtual ICollection<MktgActivityInFolder> MktgActivityInFolderByMktgActivity { get; set; }
		[CProperty(Association ="MktgActivityInTag:EntityId")]
		public virtual ICollection<MktgActivityInTag> MktgActivityInTagByEntity { get; set; }
		[CProperty(Association ="MktgActivityMessageHistory:MktgActivityId")]
		public virtual ICollection<MktgActivityMessageHistory> MktgActivityMessageHistoryByMktgActivity { get; set; }
		#endregion
	}
}
