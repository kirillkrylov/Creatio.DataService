using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GeneratedWebForm")]
	public class GeneratedWebForm : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Body")]
		public string Body { get; set; }
		[CProperty(ColumnPath ="CreateContact")]
		public bool CreateContact { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EntityDefaultValues")]
		public string EntityDefaultValues { get; set; }
		[CProperty(ColumnPath ="ExternalURL")]
		public string ExternalURL { get; set; }
		[CProperty(ColumnPath ="FormFields")]
		public string FormFields { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LendingCategoryId")]
		public Guid LendingCategoryId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReturnURL")]
		public string ReturnURL { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="LandingType:TypeId")]
		public LandingType Type { get; set; }
		[CProperty(Navigation ="LendingCategory:LendingCategoryId")]
		public LendingCategory LendingCategory { get; set; }
		[CProperty(Navigation ="LendingState:StateId")]
		public LendingState State { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmPreferences:BpmLandingId")]
		public virtual ICollection<BpmPreferences> BpmPreferencesByBpmLanding { get; set; }
		[CProperty(Association ="EventTarget:GeneratedWebFormId")]
		public virtual ICollection<EventTarget> EventTargetByGeneratedWebForm { get; set; }
		[CProperty(Association ="GeneratedWebFormFile:GeneratedWebFormId")]
		public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFileByGeneratedWebForm { get; set; }
		[CProperty(Association ="GeneratedWebFormInFolder:GeneratedWebFormId")]
		public virtual ICollection<GeneratedWebFormInFolder> GeneratedWebFormInFolderByGeneratedWebForm { get; set; }
		[CProperty(Association ="GeneratedWebFormInTag:EntityId")]
		public virtual ICollection<GeneratedWebFormInTag> GeneratedWebFormInTagByEntity { get; set; }
		[CProperty(Association ="LandingLeadDefaults:LandingId")]
		public virtual ICollection<LandingLeadDefaults> LandingLeadDefaultsByLanding { get; set; }
		[CProperty(Association ="LandingObjectDefaults:LandingId")]
		public virtual ICollection<LandingObjectDefaults> LandingObjectDefaultsByLanding { get; set; }
		[CProperty(Association ="Lead:WebFormId")]
		public virtual ICollection<Lead> LeadByWebForm { get; set; }
		[CProperty(Association ="VwLandingInCampaign:LandingId")]
		public virtual ICollection<VwLandingInCampaign> VwLandingInCampaignByLanding { get; set; }
		[CProperty(Association ="VwLead:WebFormId")]
		public virtual ICollection<VwLead> VwLeadByWebForm { get; set; }
		#endregion
	}
}
