using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServicePact")]
	public class ServicePact : BaseEntity
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
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private Guid _ServiceProviderContactId;
		[CProperty(ColumnPath ="ServiceProviderContactId")]
		public Guid ServiceProviderContactId
		{
			get{return _ServiceProviderContactId;}
			set
			{
				_ServiceProviderContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceProviderId;
		[CProperty(ColumnPath ="ServiceProviderId")]
		public Guid ServiceProviderId
		{
			get{return _ServiceProviderId;}
			set
			{
				_ServiceProviderId = value;
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
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
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
		[CProperty(Navigation ="Account:ServiceProviderId")]
		public Account ServiceProvider { get; set; }
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ServiceProviderContactId")]
		public Contact ServiceProviderContact { get; set; }
		[CProperty(Navigation ="ServicePactStatus:StatusId")]
		public ServicePactStatus Status { get; set; }
		[CProperty(Navigation ="ServicePactType:TypeId")]
		public ServicePactType Type { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:ServicePactId")]
		public virtual ICollection<Case> CaseByServicePact { get; set; }
		[CProperty(Association ="CaseLifecycle:ServicePactId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByServicePact { get; set; }
		[CProperty(Association ="ServiceInServicePact:ServicePactId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByServicePact { get; set; }
		[CProperty(Association ="ServiceObject:ServicePactId")]
		public virtual ICollection<ServiceObject> ServiceObjectByServicePact { get; set; }
		[CProperty(Association ="ServicePactFile:ServicePactId")]
		public virtual ICollection<ServicePactFile> ServicePactFileByServicePact { get; set; }
		[CProperty(Association ="ServicePactInFolder:ServicePactId")]
		public virtual ICollection<ServicePactInFolder> ServicePactInFolderByServicePact { get; set; }
		[CProperty(Association ="ServicePactInTag:EntityId")]
		public virtual ICollection<ServicePactInTag> ServicePactInTagByEntity { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ServicePactId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByServicePact { get; set; }
		[CProperty(Association ="VwServiceRecepients:ServicePactId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByServicePact { get; set; }
		#endregion
	}
}
