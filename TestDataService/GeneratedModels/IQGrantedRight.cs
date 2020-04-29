using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQGrantedRight")]
	public class IQGrantedRight : BaseEntity
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
		private DateTime _IQDateTimeFrom;
		[CProperty(ColumnPath ="IQDateTimeFrom")]
		public DateTime IQDateTimeFrom
		{
			get{return _IQDateTimeFrom;}
			set
			{
				_IQDateTimeFrom = value;
				OnPropertyChanged();
			}
		}
		private DateTime _IQDateTimeTo;
		[CProperty(ColumnPath ="IQDateTimeTo")]
		public DateTime IQDateTimeTo
		{
			get{return _IQDateTimeTo;}
			set
			{
				_IQDateTimeTo = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQGranteeSysAdminUnitId;
		[CProperty(ColumnPath ="IQGranteeSysAdminUnitId")]
		public Guid IQGranteeSysAdminUnitId
		{
			get{return _IQGranteeSysAdminUnitId;}
			set
			{
				_IQGranteeSysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQGrantorSysAdminUnitId;
		[CProperty(ColumnPath ="IQGrantorSysAdminUnitId")]
		public Guid IQGrantorSysAdminUnitId
		{
			get{return _IQGrantorSysAdminUnitId;}
			set
			{
				_IQGrantorSysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		private bool _IQProcessed;
		[CProperty(ColumnPath ="IQProcessed")]
		public bool IQProcessed
		{
			get{return _IQProcessed;}
			set
			{
				_IQProcessed = value;
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
		[CProperty(Navigation ="VwSysAdminUnit:IQGrantorSysAdminUnitId")]
		public VwSysAdminUnit IQGrantorSysAdminUnit { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:IQGranteeSysAdminUnitId")]
		public VwSysAdminUnit IQGranteeSysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
