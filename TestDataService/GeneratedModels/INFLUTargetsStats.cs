using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "INFLUTargetsStats")]
	public class INFLUTargetsStats : BaseEntity
	{
		#region Values
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
		private string _INFLUCampaignId;
		[CProperty(ColumnPath ="INFLUCampaignId")]
		public string INFLUCampaignId
		{
			get{return _INFLUCampaignId;}
			set
			{
				_INFLUCampaignId = value;
				OnPropertyChanged();
			}
		}
		private string _INFLUCampaignName;
		[CProperty(ColumnPath ="INFLUCampaignName")]
		public string INFLUCampaignName
		{
			get{return _INFLUCampaignName;}
			set
			{
				_INFLUCampaignName = value;
				OnPropertyChanged();
			}
		}
		private string _INFLUCampaignStatus;
		[CProperty(ColumnPath ="INFLUCampaignStatus")]
		public string INFLUCampaignStatus
		{
			get{return _INFLUCampaignStatus;}
			set
			{
				_INFLUCampaignStatus = value;
				OnPropertyChanged();
			}
		}
		private int _INFLUClicks;
		[CProperty(ColumnPath ="INFLUClicks")]
		public int INFLUClicks
		{
			get{return _INFLUClicks;}
			set
			{
				_INFLUClicks = value;
				OnPropertyChanged();
			}
		}
		private Guid _INFLUContactId;
		[CProperty(ColumnPath ="INFLUContactId")]
		public Guid INFLUContactId
		{
			get{return _INFLUContactId;}
			set
			{
				_INFLUContactId = value;
				OnPropertyChanged();
			}
		}
		private int _INFLUViews;
		[CProperty(ColumnPath ="INFLUViews")]
		public int INFLUViews
		{
			get{return _INFLUViews;}
			set
			{
				_INFLUViews = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:INFLUContactId")]
		public Contact INFLUContact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
