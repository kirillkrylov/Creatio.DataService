using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessUserTask")]
	public class SysProcessUserTask : BaseEntity
	{
		#region Values
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
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
		private bool _IsQuickModel;
		[CProperty(ColumnPath ="IsQuickModel")]
		public bool IsQuickModel
		{
			get{return _IsQuickModel;}
			set
			{
				_IsQuickModel = value;
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
		private Guid _QuickModelEditPageSchemaUId;
		[CProperty(ColumnPath ="QuickModelEditPageSchemaUId")]
		public Guid QuickModelEditPageSchemaUId
		{
			get{return _QuickModelEditPageSchemaUId;}
			set
			{
				_QuickModelEditPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysImageId;
		[CProperty(ColumnPath ="SysImageId")]
		public Guid SysImageId
		{
			get{return _SysImageId;}
			set
			{
				_SysImageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysUserTaskSchemaUId;
		[CProperty(ColumnPath ="SysUserTaskSchemaUId")]
		public Guid SysUserTaskSchemaUId
		{
			get{return _SysUserTaskSchemaUId;}
			set
			{
				_SysUserTaskSchemaUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:SysImageId")]
		public SysImage SysImage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
