using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeScore")]
	public class EmployeeScore : BaseEntity
	{
		#region Values
		private Guid _AccrualRuleId;
		[CProperty(ColumnPath ="AccrualRuleId")]
		public Guid AccrualRuleId
		{
			get{return _AccrualRuleId;}
			set
			{
				_AccrualRuleId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _GiftId;
		[CProperty(ColumnPath ="GiftId")]
		public Guid GiftId
		{
			get{return _GiftId;}
			set
			{
				_GiftId = value;
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
		private Guid _MarketplaceApplicationId;
		[CProperty(ColumnPath ="MarketplaceApplicationId")]
		public Guid MarketplaceApplicationId
		{
			get{return _MarketplaceApplicationId;}
			set
			{
				_MarketplaceApplicationId = value;
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
		private decimal _ScoreBalance;
		[CProperty(ColumnPath ="ScoreBalance")]
		public decimal ScoreBalance
		{
			get{return _ScoreBalance;}
			set
			{
				_ScoreBalance = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ScoreDate;
		[CProperty(ColumnPath ="ScoreDate")]
		public DateTime ScoreDate
		{
			get{return _ScoreDate;}
			set
			{
				_ScoreDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _ScoreNumber;
		[CProperty(ColumnPath ="ScoreNumber")]
		public decimal ScoreNumber
		{
			get{return _ScoreNumber;}
			set
			{
				_ScoreNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScoreTypeId;
		[CProperty(ColumnPath ="ScoreTypeId")]
		public Guid ScoreTypeId
		{
			get{return _ScoreTypeId;}
			set
			{
				_ScoreTypeId = value;
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
		[CProperty(Navigation ="Contact:EmployeeId")]
		public Contact Employee { get; set; }
		[CProperty(Navigation ="Gift:GiftId")]
		public Gift Gift { get; set; }
		[CProperty(Navigation ="MarketplaceApplication:MarketplaceApplicationId")]
		public MarketplaceApplication MarketplaceApplication { get; set; }
		[CProperty(Navigation ="ScoreAccrualRule:AccrualRuleId")]
		public ScoreAccrualRule AccrualRule { get; set; }
		[CProperty(Navigation ="ScoreType:ScoreTypeId")]
		public ScoreType ScoreType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmployeeScoreFile:EmployeeScoreId")]
		public virtual ICollection<EmployeeScoreFile> EmployeeScoreFileByEmployeeScore { get; set; }
		[CProperty(Association ="EmployeeScoreInFolder:EmployeeScoreId")]
		public virtual ICollection<EmployeeScoreInFolder> EmployeeScoreInFolderByEmployeeScore { get; set; }
		[CProperty(Association ="EmployeeScoreInTag:EntityId")]
		public virtual ICollection<EmployeeScoreInTag> EmployeeScoreInTagByEntity { get; set; }
		#endregion
	}
}
