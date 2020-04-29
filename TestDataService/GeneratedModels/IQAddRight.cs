using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQAddRight")]
	public class IQAddRight : BaseEntity
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
		private bool _IQDelete;
		[CProperty(ColumnPath ="IQDelete")]
		public bool IQDelete
		{
			get{return _IQDelete;}
			set
			{
				_IQDelete = value;
				OnPropertyChanged();
			}
		}
		private bool _IQEdit;
		[CProperty(ColumnPath ="IQEdit")]
		public bool IQEdit
		{
			get{return _IQEdit;}
			set
			{
				_IQEdit = value;
				OnPropertyChanged();
			}
		}
		private bool _IQRead;
		[CProperty(ColumnPath ="IQRead")]
		public bool IQRead
		{
			get{return _IQRead;}
			set
			{
				_IQRead = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQRightTypeId;
		[CProperty(ColumnPath ="IQRightTypeId")]
		public Guid IQRightTypeId
		{
			get{return _IQRightTypeId;}
			set
			{
				_IQRightTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQSetRightsId;
		[CProperty(ColumnPath ="IQSetRightsId")]
		public Guid IQSetRightsId
		{
			get{return _IQSetRightsId;}
			set
			{
				_IQSetRightsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQUserRoleId;
		[CProperty(ColumnPath ="IQUserRoleId")]
		public Guid IQUserRoleId
		{
			get{return _IQUserRoleId;}
			set
			{
				_IQUserRoleId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IQRightType:IQRightTypeId")]
		public IQRightType IQRightType { get; set; }
		[CProperty(Navigation ="IQSetRights:IQSetRightsId")]
		public IQSetRights IQSetRights { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:IQUserRoleId")]
		public VwSysAdminUnit IQUserRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
