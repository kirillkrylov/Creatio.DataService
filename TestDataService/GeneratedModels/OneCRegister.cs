using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCRegister")]
	public class OneCRegister : BaseEntity
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
		private Guid _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPeriodic;
		[CProperty(ColumnPath ="IsPeriodic")]
		public bool IsPeriodic
		{
			get{return _IsPeriodic;}
			set
			{
				_IsPeriodic = value;
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
		private Guid _OneCRegisterClassId;
		[CProperty(ColumnPath ="OneCRegisterClassId")]
		public Guid OneCRegisterClassId
		{
			get{return _OneCRegisterClassId;}
			set
			{
				_OneCRegisterClassId = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:OneCRegisterClassId")]
		public OneCRegisterClass OneCRegisterClass { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OneCRegisterColumn:OneCRegisterId")]
		public virtual ICollection<OneCRegisterColumn> OneCRegisterColumnByOneCRegister { get; set; }
		[CProperty(Association ="SyncColumn:OneCRegisterId")]
		public virtual ICollection<SyncColumn> SyncColumnByOneCRegister { get; set; }
		#endregion
	}
}
