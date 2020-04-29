using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleReportTable")]
	public class SysModuleReportTable : BaseEntity
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
		private byte[] _Filter;
		[CProperty(ColumnPath ="Filter")]
		public byte[] Filter
		{
			get{return _Filter;}
			set
			{
				_Filter = value;
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
		private bool _IsEmptyTableHide;
		[CProperty(ColumnPath ="IsEmptyTableHide")]
		public bool IsEmptyTableHide
		{
			get{return _IsEmptyTableHide;}
			set
			{
				_IsEmptyTableHide = value;
				OnPropertyChanged();
			}
		}
		private string _MacrosList;
		[CProperty(ColumnPath ="MacrosList")]
		public string MacrosList
		{
			get{return _MacrosList;}
			set
			{
				_MacrosList = value;
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
		private string _ObjectColumnCaption;
		[CProperty(ColumnPath ="ObjectColumnCaption")]
		public string ObjectColumnCaption
		{
			get{return _ObjectColumnCaption;}
			set
			{
				_ObjectColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private string _ObjectColumnPath;
		[CProperty(ColumnPath ="ObjectColumnPath")]
		public string ObjectColumnPath
		{
			get{return _ObjectColumnPath;}
			set
			{
				_ObjectColumnPath = value;
				OnPropertyChanged();
			}
		}
		private Guid _ObjectId;
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId
		{
			get{return _ObjectId;}
			set
			{
				_ObjectId = value;
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
		private string _ReferenceColumn;
		[CProperty(ColumnPath ="ReferenceColumn")]
		public string ReferenceColumn
		{
			get{return _ReferenceColumn;}
			set
			{
				_ReferenceColumn = value;
				OnPropertyChanged();
			}
		}
		private string _ReferenceColumnCaption;
		[CProperty(ColumnPath ="ReferenceColumnCaption")]
		public string ReferenceColumnCaption
		{
			get{return _ReferenceColumnCaption;}
			set
			{
				_ReferenceColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleReportId;
		[CProperty(ColumnPath ="SysModuleReportId")]
		public Guid SysModuleReportId
		{
			get{return _SysModuleReportId;}
			set
			{
				_SysModuleReportId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleReport:SysModuleReportId")]
		public SysModuleReport SysModuleReport { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
