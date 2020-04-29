using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SalesProcessEvent")]
	public class SalesProcessEvent : BaseEntity
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
		private Guid _DepartmentManagerId;
		[CProperty(ColumnPath ="DepartmentManagerId")]
		public Guid DepartmentManagerId
		{
			get{return _DepartmentManagerId;}
			set
			{
				_DepartmentManagerId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EventDate;
		[CProperty(ColumnPath ="EventDate")]
		public DateTime EventDate
		{
			get{return _EventDate;}
			set
			{
				_EventDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventTypeId;
		[CProperty(ColumnPath ="EventTypeId")]
		public Guid EventTypeId
		{
			get{return _EventTypeId;}
			set
			{
				_EventTypeId = value;
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
		private Guid _LeadCloseReasonId;
		[CProperty(ColumnPath ="LeadCloseReasonId")]
		public Guid LeadCloseReasonId
		{
			get{return _LeadCloseReasonId;}
			set
			{
				_LeadCloseReasonId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadDisqualifyReasonId;
		[CProperty(ColumnPath ="LeadDisqualifyReasonId")]
		public Guid LeadDisqualifyReasonId
		{
			get{return _LeadDisqualifyReasonId;}
			set
			{
				_LeadDisqualifyReasonId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ManagerId;
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId
		{
			get{return _ManagerId;}
			set
			{
				_ManagerId = value;
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
		private Guid _OpportunityCloseReasonId;
		[CProperty(ColumnPath ="OpportunityCloseReasonId")]
		public Guid OpportunityCloseReasonId
		{
			get{return _OpportunityCloseReasonId;}
			set
			{
				_OpportunityCloseReasonId = value;
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
		private Guid _RegisterMethodId;
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId
		{
			get{return _RegisterMethodId;}
			set
			{
				_RegisterMethodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ManagerId")]
		public Contact Manager { get; set; }
		[CProperty(Navigation ="Contact:DepartmentManagerId")]
		public Contact DepartmentManager { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="LeadCloseReason:LeadCloseReasonId")]
		public LeadCloseReason LeadCloseReason { get; set; }
		[CProperty(Navigation ="LeadDisqualifyReason:LeadDisqualifyReasonId")]
		public LeadDisqualifyReason LeadDisqualifyReason { get; set; }
		[CProperty(Navigation ="LeadRegisterMethod:RegisterMethodId")]
		public LeadRegisterMethod RegisterMethod { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityCloseReason:OpportunityCloseReasonId")]
		public OpportunityCloseReason OpportunityCloseReason { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="SalesProcessEventType:EventTypeId")]
		public SalesProcessEventType EventType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
