using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCampaignLog")]
	public class VwCampaignLog : BaseEntity
	{
		#region Values
		private Guid _ActionId;
		[CProperty(ColumnPath ="ActionId")]
		public Guid ActionId
		{
			get{return _ActionId;}
			set
			{
				_ActionId = value;
				OnPropertyChanged();
			}
		}
		private int _Amount;
		[CProperty(ColumnPath ="Amount")]
		public int Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignId;
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId
		{
			get{return _CampaignId;}
			set
			{
				_CampaignId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignItemId;
		[CProperty(ColumnPath ="CampaignItemId")]
		public Guid CampaignItemId
		{
			get{return _CampaignItemId;}
			set
			{
				_CampaignItemId = value;
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
		private int _DurationMi;
		[CProperty(ColumnPath ="DurationMi")]
		public int DurationMi
		{
			get{return _DurationMi;}
			set
			{
				_DurationMi = value;
				OnPropertyChanged();
			}
		}
		private int _DurationSs;
		[CProperty(ColumnPath ="DurationSs")]
		public int DurationSs
		{
			get{return _DurationSs;}
			set
			{
				_DurationSs = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
				OnPropertyChanged();
			}
		}
		private string _ErrorText;
		[CProperty(ColumnPath ="ErrorText")]
		public string ErrorText
		{
			get{return _ErrorText;}
			set
			{
				_ErrorText = value;
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
		private DateTime _ScheduledDate;
		[CProperty(ColumnPath ="ScheduledDate")]
		public DateTime ScheduledDate
		{
			get{return _ScheduledDate;}
			set
			{
				_ScheduledDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SessionId;
		[CProperty(ColumnPath ="SessionId")]
		public Guid SessionId
		{
			get{return _SessionId;}
			set
			{
				_SessionId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignItem:CampaignItemId")]
		public CampaignItem CampaignItem { get; set; }
		[CProperty(Navigation ="CampaignLogItemType:ActionId")]
		public CampaignLogItemType Action { get; set; }
		[CProperty(Navigation ="CampaignLogStatus:StatusId")]
		public CampaignLogStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
