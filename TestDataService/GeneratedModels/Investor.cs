using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Investor")]
	public class Investor : BaseEntity
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
		private decimal _AUM;
		[CProperty(ColumnPath ="AUM")]
		public decimal AUM
		{
			get{return _AUM;}
			set
			{
				_AUM = value;
				OnPropertyChanged();
			}
		}
		private string _CheckSize;
		[CProperty(ColumnPath ="CheckSize")]
		public string CheckSize
		{
			get{return _CheckSize;}
			set
			{
				_CheckSize = value;
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
		private string _CulturalFit;
		[CProperty(ColumnPath ="CulturalFit")]
		public string CulturalFit
		{
			get{return _CulturalFit;}
			set
			{
				_CulturalFit = value;
				OnPropertyChanged();
			}
		}
		private string _EnterpriseExperience;
		[CProperty(ColumnPath ="EnterpriseExperience")]
		public string EnterpriseExperience
		{
			get{return _EnterpriseExperience;}
			set
			{
				_EnterpriseExperience = value;
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
		private Guid _OverallPriorityId;
		[CProperty(ColumnPath ="OverallPriorityId")]
		public Guid OverallPriorityId
		{
			get{return _OverallPriorityId;}
			set
			{
				_OverallPriorityId = value;
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
		private string _StrengthOfNetwork;
		[CProperty(ColumnPath ="StrengthOfNetwork")]
		public string StrengthOfNetwork
		{
			get{return _StrengthOfNetwork;}
			set
			{
				_StrengthOfNetwork = value;
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
		[CProperty(Navigation ="InvestorPriority:OverallPriorityId")]
		public InvestorPriority OverallPriority { get; set; }
		[CProperty(Navigation ="InvestorStatus:StatusId")]
		public InvestorStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:InvestorId")]
		public virtual ICollection<Activity> ActivityByInvestor { get; set; }
		[CProperty(Association ="InvestorComment:InvestorId")]
		public virtual ICollection<InvestorComment> InvestorCommentByInvestor { get; set; }
		[CProperty(Association ="InvestorFile:InvestorId")]
		public virtual ICollection<InvestorFile> InvestorFileByInvestor { get; set; }
		[CProperty(Association ="InvestorInFolder:InvestorId")]
		public virtual ICollection<InvestorInFolder> InvestorInFolderByInvestor { get; set; }
		[CProperty(Association ="InvestorInTag:EntityId")]
		public virtual ICollection<InvestorInTag> InvestorInTagByEntity { get; set; }
		#endregion
	}
}
