using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceItem")]
	public class ServiceItem : BaseEntity
	{
		#region Values
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseCategoryId;
		[CProperty(ColumnPath ="CaseCategoryId")]
		public Guid CaseCategoryId
		{
			get{return _CaseCategoryId;}
			set
			{
				_CaseCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseSourceId;
		[CProperty(ColumnPath ="CaseSourceId")]
		public Guid CaseSourceId
		{
			get{return _CaseSourceId;}
			set
			{
				_CaseSourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
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
		private string _ReactionTime;
		[CProperty(ColumnPath ="ReactionTime")]
		public string ReactionTime
		{
			get{return _ReactionTime;}
			set
			{
				_ReactionTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReactionTimeUnitId;
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId
		{
			get{return _ReactionTimeUnitId;}
			set
			{
				_ReactionTimeUnitId = value;
				OnPropertyChanged();
			}
		}
		private int _ReactionTimeValue;
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue
		{
			get{return _ReactionTimeValue;}
			set
			{
				_ReactionTimeValue = value;
				OnPropertyChanged();
			}
		}
		private string _SolutionTime;
		[CProperty(ColumnPath ="SolutionTime")]
		public string SolutionTime
		{
			get{return _SolutionTime;}
			set
			{
				_SolutionTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _SolutionTimeUnitId;
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId
		{
			get{return _SolutionTimeUnitId;}
			set
			{
				_SolutionTimeUnitId = value;
				OnPropertyChanged();
			}
		}
		private int _SolutionTimeValue;
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue
		{
			get{return _SolutionTimeValue;}
			set
			{
				_SolutionTimeValue = value;
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
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation ="CaseCategory:CaseCategoryId")]
		public CaseCategory CaseCategory { get; set; }
		[CProperty(Navigation ="CaseOrigin:CaseSourceId")]
		public CaseOrigin CaseSource { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ServiceCategory:CategoryId")]
		public ServiceCategory Category { get; set; }
		[CProperty(Navigation ="ServiceStatus:StatusId")]
		public ServiceStatus Status { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:ServiceItemId")]
		public virtual ICollection<Case> CaseByServiceItem { get; set; }
		[CProperty(Association ="CaseLifecycle:ServiceItemId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByServiceItem { get; set; }
		[CProperty(Association ="CaseSourceInService:ServiceItemId")]
		public virtual ICollection<CaseSourceInService> CaseSourceInServiceByServiceItem { get; set; }
		[CProperty(Association ="ChangeServiceItem:ServiceItemId")]
		public virtual ICollection<ChangeServiceItem> ChangeServiceItemByServiceItem { get; set; }
		[CProperty(Association ="Problem:ServiceItemId")]
		public virtual ICollection<Problem> ProblemByServiceItem { get; set; }
		[CProperty(Association ="ReleaseServiceItem:ServiceItemId")]
		public virtual ICollection<ReleaseServiceItem> ReleaseServiceItemByServiceItem { get; set; }
		[CProperty(Association ="ServiceCategoryInService:ServiceItemId")]
		public virtual ICollection<ServiceCategoryInService> ServiceCategoryInServiceByServiceItem { get; set; }
		[CProperty(Association ="ServiceEngineer:ServiceItemId")]
		public virtual ICollection<ServiceEngineer> ServiceEngineerByServiceItem { get; set; }
		[CProperty(Association ="ServiceInConfItem:ServiceItemId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByServiceItem { get; set; }
		[CProperty(Association ="ServiceInServicePact:ServiceItemId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemFile:ServiceItemId")]
		public virtual ICollection<ServiceItemFile> ServiceItemFileByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemInFolder:ServiceItemId")]
		public virtual ICollection<ServiceItemInFolder> ServiceItemInFolderByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemInTag:EntityId")]
		public virtual ICollection<ServiceItemInTag> ServiceItemInTagByEntity { get; set; }
		[CProperty(Association ="ServiceRelationship:ServiceItemAId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByServiceItemA { get; set; }
		[CProperty(Association ="ServiceRelationship:ServiceItemBId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByServiceItemB { get; set; }
		[CProperty(Association ="SupCloudCaseDefValue:SupServiceItemId")]
		public virtual ICollection<SupCloudCaseDefValue> SupCloudCaseDefValueBySupServiceItem { get; set; }
		[CProperty(Association ="VwCaseDashboard:ServiceItemId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByServiceItem { get; set; }
		[CProperty(Association ="VwServiceInConfItem:ServiceItemId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByServiceItem { get; set; }
		[CProperty(Association ="VwServiceRecepients:ServiceId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByService { get; set; }
		[CProperty(Association ="VwServiceRelationship:ServiceItemAId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByServiceItemA { get; set; }
		[CProperty(Association ="VwServiceRelationship:ServiceItemBId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByServiceItemB { get; set; }
		[CProperty(Association ="WorkTeamCityBuild:ServiceItemId")]
		public virtual ICollection<WorkTeamCityBuild> WorkTeamCityBuildByServiceItem { get; set; }
		#endregion
	}
}
