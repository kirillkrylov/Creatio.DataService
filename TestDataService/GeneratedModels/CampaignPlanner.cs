using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignPlanner")]
	public class CampaignPlanner : BaseEntity
	{
		#region Values
		private Guid _BrandId;
		[CProperty(ColumnPath ="BrandId")]
		public Guid BrandId
		{
			get{return _BrandId;}
			set
			{
				_BrandId = value;
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
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Brand:BrandId")]
		public Brand Brand { get; set; }
		[CProperty(Navigation ="CampaignPlannerStatus:StatusId")]
		public CampaignPlannerStatus Status { get; set; }
		[CProperty(Navigation ="CampaignPlannerType:TypeId")]
		public CampaignPlannerType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignPlannerFile:CampaignPlannerId")]
		public virtual ICollection<CampaignPlannerFile> CampaignPlannerFileByCampaignPlanner { get; set; }
		[CProperty(Association ="CampaignPlannerInFolder:CampaignPlannerId")]
		public virtual ICollection<CampaignPlannerInFolder> CampaignPlannerInFolderByCampaignPlanner { get; set; }
		[CProperty(Association ="CampaignPlannerInTag:EntityId")]
		public virtual ICollection<CampaignPlannerInTag> CampaignPlannerInTagByEntity { get; set; }
		[CProperty(Association ="MktgActivity:CampaignPlannerId")]
		public virtual ICollection<MktgActivity> MktgActivityByCampaignPlanner { get; set; }
		#endregion
	}
}
