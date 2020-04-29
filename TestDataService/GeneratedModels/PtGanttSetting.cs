using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PtGanttSetting")]
	public class PtGanttSetting : BaseEntity
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
		private string _DiagramColumn;
		[CProperty(ColumnPath ="DiagramColumn")]
		public string DiagramColumn
		{
			get{return _DiagramColumn;}
			set
			{
				_DiagramColumn = value;
				OnPropertyChanged();
			}
		}
		private string _DueDateColumn;
		[CProperty(ColumnPath ="DueDateColumn")]
		public string DueDateColumn
		{
			get{return _DueDateColumn;}
			set
			{
				_DueDateColumn = value;
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
		private string _NameColumn;
		[CProperty(ColumnPath ="NameColumn")]
		public string NameColumn
		{
			get{return _NameColumn;}
			set
			{
				_NameColumn = value;
				OnPropertyChanged();
			}
		}
		private string _ParentColumn;
		[CProperty(ColumnPath ="ParentColumn")]
		public string ParentColumn
		{
			get{return _ParentColumn;}
			set
			{
				_ParentColumn = value;
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
		private Guid _SectionId;
		[CProperty(ColumnPath ="SectionId")]
		public Guid SectionId
		{
			get{return _SectionId;}
			set
			{
				_SectionId = value;
				OnPropertyChanged();
			}
		}
		private string _StartDateColumn;
		[CProperty(ColumnPath ="StartDateColumn")]
		public string StartDateColumn
		{
			get{return _StartDateColumn;}
			set
			{
				_StartDateColumn = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModule:SectionId")]
		public SysModule Section { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
