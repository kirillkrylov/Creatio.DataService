using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysExtServiceOperationRight")]
	public class SysExtServiceOperationRight : BaseEntity
	{
		#region Values
		private bool _CanAppend;
		[CProperty(ColumnPath ="CanAppend")]
		public bool CanAppend
		{
			get{return _CanAppend;}
			set
			{
				_CanAppend = value;
				OnPropertyChanged();
			}
		}
		private bool _CanDelete;
		[CProperty(ColumnPath ="CanDelete")]
		public bool CanDelete
		{
			get{return _CanDelete;}
			set
			{
				_CanDelete = value;
				OnPropertyChanged();
			}
		}
		private bool _CanEdit;
		[CProperty(ColumnPath ="CanEdit")]
		public bool CanEdit
		{
			get{return _CanEdit;}
			set
			{
				_CanEdit = value;
				OnPropertyChanged();
			}
		}
		private bool _CanRead;
		[CProperty(ColumnPath ="CanRead")]
		public bool CanRead
		{
			get{return _CanRead;}
			set
			{
				_CanRead = value;
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
		private Guid _SubjectSchemaUId;
		[CProperty(ColumnPath ="SubjectSchemaUId")]
		public Guid SubjectSchemaUId
		{
			get{return _SubjectSchemaUId;}
			set
			{
				_SubjectSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitId;
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId
		{
			get{return _SysAdminUnitId;}
			set
			{
				_SysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:SysAdminUnitId")]
		public VwSysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
