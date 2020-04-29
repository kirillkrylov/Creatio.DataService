using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignTarget")]
	public class CampaignTarget : BaseEntity
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
		private Guid _CampaignTargetStatusId;
		[CProperty(ColumnPath ="CampaignTargetStatusId")]
		public Guid CampaignTargetStatusId
		{
			get{return _CampaignTargetStatusId;}
			set
			{
				_CampaignTargetStatusId = value;
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
		private Guid _CurrentStepId;
		[CProperty(ColumnPath ="CurrentStepId")]
		public Guid CurrentStepId
		{
			get{return _CurrentStepId;}
			set
			{
				_CurrentStepId = value;
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
		private bool _IsFromGroup;
		[CProperty(ColumnPath ="IsFromGroup")]
		public bool IsFromGroup
		{
			get{return _IsFromGroup;}
			set
			{
				_IsFromGroup = value;
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
		private Guid _NextStepId;
		[CProperty(ColumnPath ="NextStepId")]
		public Guid NextStepId
		{
			get{return _NextStepId;}
			set
			{
				_NextStepId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PassedStepId;
		[CProperty(ColumnPath ="PassedStepId")]
		public Guid PassedStepId
		{
			get{return _PassedStepId;}
			set
			{
				_PassedStepId = value;
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
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignStep:CurrentStepId")]
		public CampaignStep CurrentStep { get; set; }
		[CProperty(Navigation ="CampaignStep:NextStepId")]
		public CampaignStep NextStep { get; set; }
		[CProperty(Navigation ="CampaignStep:PassedStepId")]
		public CampaignStep PassedStep { get; set; }
		[CProperty(Navigation ="CampaignTargetStatus:CampaignTargetStatusId")]
		public CampaignTargetStatus CampaignTargetStatus { get; set; }
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
