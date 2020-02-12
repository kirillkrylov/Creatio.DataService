using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServicePact")]
	public class ServicePact : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ServiceProviderContactId")]
		public Guid ServiceProviderContactId { get; set; }
		[CProperty(ColumnPath ="ServiceProviderId")]
		public Guid ServiceProviderId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
