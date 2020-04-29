using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderOperatorUnit")]
	public class BeesenderOperatorUnit : BaseEntity
	{
		#region Values
		private bool _AltDuty;
		[CProperty(ColumnPath ="AltDuty")]
		public bool AltDuty
		{
			get{return _AltDuty;}
			set
			{
				_AltDuty = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChatConfigId;
		[CProperty(ColumnPath ="ChatConfigId")]
		public Guid ChatConfigId
		{
			get{return _ChatConfigId;}
			set
			{
				_ChatConfigId = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private string _ProcessName;
		[CProperty(ColumnPath ="ProcessName")]
		public string ProcessName
		{
			get{return _ProcessName;}
			set
			{
				_ProcessName = value;
				OnPropertyChanged();
			}
		}
		private int _QueuePosition;
		[CProperty(ColumnPath ="QueuePosition")]
		public int QueuePosition
		{
			get{return _QueuePosition;}
			set
			{
				_QueuePosition = value;
				OnPropertyChanged();
			}
		}
		private int _Status;
		[CProperty(ColumnPath ="Status")]
		public int Status
		{
			get{return _Status;}
			set
			{
				_Status = value;
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
		private decimal _Weight;
		[CProperty(ColumnPath ="Weight")]
		public decimal Weight
		{
			get{return _Weight;}
			set
			{
				_Weight = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChatConfiguration:ChatConfigId")]
		public BeesenderChatConfiguration ChatConfig { get; set; }
		[CProperty(Navigation ="BeesenderOperatorUnit:ParentId")]
		public BeesenderOperatorUnit Parent { get; set; }
		[CProperty(Navigation ="BeesenderOperatorUnitType:TypeId")]
		public BeesenderOperatorUnitType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderOperatorChannel:UnitId")]
		public virtual ICollection<BeesenderOperatorChannel> BeesenderOperatorChannelByUnit { get; set; }
		[CProperty(Association ="BeesenderOperatorUnit:ParentId")]
		public virtual ICollection<BeesenderOperatorUnit> BeesenderOperatorUnitByParent { get; set; }
		#endregion
	}
}
