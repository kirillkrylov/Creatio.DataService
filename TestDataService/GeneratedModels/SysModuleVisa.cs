using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleVisa")]
	public class SysModuleVisa : BaseEntity
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
		private Guid _MasterColumnUId;
		[CProperty(ColumnPath ="MasterColumnUId")]
		public Guid MasterColumnUId
		{
			get{return _MasterColumnUId;}
			set
			{
				_MasterColumnUId = value;
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
		private bool _UseCustomNotificationProvider;
		[CProperty(ColumnPath ="UseCustomNotificationProvider")]
		public bool UseCustomNotificationProvider
		{
			get{return _UseCustomNotificationProvider;}
			set
			{
				_UseCustomNotificationProvider = value;
				OnPropertyChanged();
			}
		}
		private Guid _VisaSchemaUId;
		[CProperty(ColumnPath ="VisaSchemaUId")]
		public Guid VisaSchemaUId
		{
			get{return _VisaSchemaUId;}
			set
			{
				_VisaSchemaUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleBySysModuleVisa { get; set; }
		[CProperty(Association ="SysModule:SysModuleVisaId")]
		public virtual ICollection<SysModule> SysModuleBySysModuleVisa { get; set; }
		#endregion
	}
}
