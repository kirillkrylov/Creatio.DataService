using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignItem")]
	public class CampaignItem : BaseEntity
	{
		#region Values
		private string _CampaignElementType;
		[CProperty(ColumnPath ="CampaignElementType")]
		public string CampaignElementType
		{
			get{return _CampaignElementType;}
			set
			{
				_CampaignElementType = value;
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
		private bool _IsDeleted;
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted
		{
			get{return _IsDeleted;}
			set
			{
				_IsDeleted = value;
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
		private Guid _RecordId;
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId
		{
			get{return _RecordId;}
			set
			{
				_RecordId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaUId;
		[CProperty(ColumnPath ="SysSchemaUId")]
		public Guid SysSchemaUId
		{
			get{return _SysSchemaUId;}
			set
			{
				_SysSchemaUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignLog:CampaignItemId")]
		public virtual ICollection<CampaignLog> CampaignLogByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipant:CampaignItemId")]
		public virtual ICollection<CampaignParticipant> CampaignParticipantByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipantOp:CampaignItemId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipantOp:InitialCampaignItemId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByInitialCampaignItem { get; set; }
		[CProperty(Association ="CampaignQueue:CampaignItemId")]
		public virtual ICollection<CampaignQueue> CampaignQueueByCampaignItem { get; set; }
		[CProperty(Association ="CampaignSignal:CampaignItemId")]
		public virtual ICollection<CampaignSignal> CampaignSignalByCampaignItem { get; set; }
		[CProperty(Association ="VwBulkEmailInCampaign:CampaignItemId")]
		public virtual ICollection<VwBulkEmailInCampaign> VwBulkEmailInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwCampaignLog:CampaignItemId")]
		public virtual ICollection<VwCampaignLog> VwCampaignLogByCampaignItem { get; set; }
		[CProperty(Association ="VwEventInCampaign:CampaignItemId")]
		public virtual ICollection<VwEventInCampaign> VwEventInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwFolderInCampaign:CampaignItemId")]
		public virtual ICollection<VwFolderInCampaign> VwFolderInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwLandingInCampaign:CampaignItemId")]
		public virtual ICollection<VwLandingInCampaign> VwLandingInCampaignByCampaignItem { get; set; }
		#endregion
	}
}
