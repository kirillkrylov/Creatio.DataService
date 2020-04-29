using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignParticipantOp")]
	public class CampaignParticipantOp : BaseEntity
	{
		#region Values
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
		private Guid _CampaignParticipantId;
		[CProperty(ColumnPath ="CampaignParticipantId")]
		public Guid CampaignParticipantId
		{
			get{return _CampaignParticipantId;}
			set
			{
				_CampaignParticipantId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private Guid _InitialCampaignItemId;
		[CProperty(ColumnPath ="InitialCampaignItemId")]
		public Guid InitialCampaignItemId
		{
			get{return _InitialCampaignItemId;}
			set
			{
				_InitialCampaignItemId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsReadyToSync;
		[CProperty(ColumnPath ="IsReadyToSync")]
		public bool IsReadyToSync
		{
			get{return _IsReadyToSync;}
			set
			{
				_IsReadyToSync = value;
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
		private bool _StepCompleted;
		[CProperty(ColumnPath ="StepCompleted")]
		public bool StepCompleted
		{
			get{return _StepCompleted;}
			set
			{
				_StepCompleted = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StepCompletedOn;
		[CProperty(ColumnPath ="StepCompletedOn")]
		public DateTime StepCompletedOn
		{
			get{return _StepCompletedOn;}
			set
			{
				_StepCompletedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StepModifiedOn;
		[CProperty(ColumnPath ="StepModifiedOn")]
		public DateTime StepModifiedOn
		{
			get{return _StepModifiedOn;}
			set
			{
				_StepModifiedOn = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignItem:CampaignItemId")]
		public CampaignItem CampaignItem { get; set; }
		[CProperty(Navigation ="CampaignItem:InitialCampaignItemId")]
		public CampaignItem InitialCampaignItem { get; set; }
		[CProperty(Navigation ="CampaignParticipant:CampaignParticipantId")]
		public CampaignParticipant CampaignParticipant { get; set; }
		[CProperty(Navigation ="CmpgnParticipantStatus:StatusId")]
		public CmpgnParticipantStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
