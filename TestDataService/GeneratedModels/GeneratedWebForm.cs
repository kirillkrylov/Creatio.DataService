using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GeneratedWebForm")]
	public class GeneratedWebForm : BaseEntity
	{
		#region Values
		private string _Body;
		[CProperty(ColumnPath ="Body")]
		public string Body
		{
			get{return _Body;}
			set
			{
				_Body = value;
				OnPropertyChanged();
			}
		}
		private bool _CreateContact;
		[CProperty(ColumnPath ="CreateContact")]
		public bool CreateContact
		{
			get{return _CreateContact;}
			set
			{
				_CreateContact = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private string _EntityDefaultValues;
		[CProperty(ColumnPath ="EntityDefaultValues")]
		public string EntityDefaultValues
		{
			get{return _EntityDefaultValues;}
			set
			{
				_EntityDefaultValues = value;
				OnPropertyChanged();
			}
		}
		private string _ExternalURL;
		[CProperty(ColumnPath ="ExternalURL")]
		public string ExternalURL
		{
			get{return _ExternalURL;}
			set
			{
				_ExternalURL = value;
				OnPropertyChanged();
			}
		}
		private string _FormFields;
		[CProperty(ColumnPath ="FormFields")]
		public string FormFields
		{
			get{return _FormFields;}
			set
			{
				_FormFields = value;
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
		private Guid _LendingCategoryId;
		[CProperty(ColumnPath ="LendingCategoryId")]
		public Guid LendingCategoryId
		{
			get{return _LendingCategoryId;}
			set
			{
				_LendingCategoryId = value;
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
		private string _ReturnURL;
		[CProperty(ColumnPath ="ReturnURL")]
		public string ReturnURL
		{
			get{return _ReturnURL;}
			set
			{
				_ReturnURL = value;
				OnPropertyChanged();
			}
		}
		private Guid _StateId;
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId
		{
			get{return _StateId;}
			set
			{
				_StateId = value;
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
