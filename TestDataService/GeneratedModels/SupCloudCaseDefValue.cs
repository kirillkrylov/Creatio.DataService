using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCloudCaseDefValue")]
	public class SupCloudCaseDefValue : BaseEntity
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
		private Guid _SupCloudTriggerId;
		[CProperty(ColumnPath ="SupCloudTriggerId")]
		public Guid SupCloudTriggerId
		{
			get{return _SupCloudTriggerId;}
			set
			{
				_SupCloudTriggerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupOriginId;
		[CProperty(ColumnPath ="SupOriginId")]
		public Guid SupOriginId
		{
			get{return _SupOriginId;}
			set
			{
				_SupOriginId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupServiceItemId;
		[CProperty(ColumnPath ="SupServiceItemId")]
		public Guid SupServiceItemId
		{
			get{return _SupServiceItemId;}
			set
			{
				_SupServiceItemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupSubtypeId;
		[CProperty(ColumnPath ="SupSubtypeId")]
		public Guid SupSubtypeId
		{
			get{return _SupSubtypeId;}
			set
			{
				_SupSubtypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupSupportLevelId;
		[CProperty(ColumnPath ="SupSupportLevelId")]
		public Guid SupSupportLevelId
		{
			get{return _SupSupportLevelId;}
			set
			{
				_SupSupportLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupTypeId;
		[CProperty(ColumnPath ="SupTypeId")]
		public Guid SupTypeId
		{
			get{return _SupTypeId;}
			set
			{
				_SupTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseOrigin:SupOriginId")]
		public CaseOrigin SupOrigin { get; set; }
		[CProperty(Navigation ="CaseSubtype:SupSubtypeId")]
		public CaseSubtype SupSubtype { get; set; }
		[CProperty(Navigation ="CaseType:SupTypeId")]
		public CaseType SupType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SupSupportLevelId")]
		public RoleInServiceTeam SupSupportLevel { get; set; }
		[CProperty(Navigation ="ServiceItem:SupServiceItemId")]
		public ServiceItem SupServiceItem { get; set; }
		[CProperty(Navigation ="SupCloudTrigger:SupCloudTriggerId")]
		public SupCloudTrigger SupCloudTrigger { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
