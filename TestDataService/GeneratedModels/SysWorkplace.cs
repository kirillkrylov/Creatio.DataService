using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysWorkplace")]
	public class SysWorkplace : BaseEntity
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
		private bool _IsPersonal;
		[CProperty(ColumnPath ="IsPersonal")]
		public bool IsPersonal
		{
			get{return _IsPersonal;}
			set
			{
				_IsPersonal = value;
				OnPropertyChanged();
			}
		}
		private Guid _LoaderId;
		[CProperty(ColumnPath ="LoaderId")]
		public Guid LoaderId
		{
			get{return _LoaderId;}
			set
			{
				_LoaderId = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private Guid _SysApplicationClientTypeId;
		[CProperty(ColumnPath ="SysApplicationClientTypeId")]
		public Guid SysApplicationClientTypeId
		{
			get{return _SysApplicationClientTypeId;}
			set
			{
				_SysApplicationClientTypeId = value;
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
		[CProperty(Navigation ="SysApplicationClientType:SysApplicationClientTypeId")]
		public SysApplicationClientType SysApplicationClientType { get; set; }
		[CProperty(Navigation ="SysWorkplaceType:TypeId")]
		public SysWorkplaceType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysAdminUnitInWorkplace:SysWorkplaceId")]
		public virtual ICollection<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaceBySysWorkplace { get; set; }
		[CProperty(Association ="SysModuleInWorkplace:SysWorkplaceId")]
		public virtual ICollection<SysModuleInWorkplace> SysModuleInWorkplaceBySysWorkplace { get; set; }
		#endregion
	}
}
