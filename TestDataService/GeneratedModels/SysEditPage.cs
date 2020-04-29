using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysEditPage")]
	public class SysEditPage : BaseEntity
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
		private Guid _SysEntitySchemaId;
		[CProperty(ColumnPath ="SysEntitySchemaId")]
		public Guid SysEntitySchemaId
		{
			get{return _SysEntitySchemaId;}
			set
			{
				_SysEntitySchemaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysGridPageId;
		[CProperty(ColumnPath ="SysGridPageId")]
		public Guid SysGridPageId
		{
			get{return _SysGridPageId;}
			set
			{
				_SysGridPageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysPageSchemaId;
		[CProperty(ColumnPath ="SysPageSchemaId")]
		public Guid SysPageSchemaId
		{
			get{return _SysPageSchemaId;}
			set
			{
				_SysPageSchemaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnValue;
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue
		{
			get{return _TypeColumnValue;}
			set
			{
				_TypeColumnValue = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysGridPage:SysGridPageId")]
		public SysGridPage SysGridPage { get; set; }
		[CProperty(Navigation ="SysSchema:SysPageSchemaId")]
		public SysSchema SysPageSchema { get; set; }
		[CProperty(Navigation ="SysSchema:SysEntitySchemaId")]
		public SysSchema SysEntitySchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
