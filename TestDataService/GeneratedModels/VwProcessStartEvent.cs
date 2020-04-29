using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProcessStartEvent")]
	public class VwProcessStartEvent : BaseEntity
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
		private string _ElementName;
		[CProperty(ColumnPath ="ElementName")]
		public string ElementName
		{
			get{return _ElementName;}
			set
			{
				_ElementName = value;
				OnPropertyChanged();
			}
		}
		private string _EntitySchemaName;
		[CProperty(ColumnPath ="EntitySchemaName")]
		public string EntitySchemaName
		{
			get{return _EntitySchemaName;}
			set
			{
				_EntitySchemaName = value;
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
		private Guid _ProcessElementUId;
		[CProperty(ColumnPath ="ProcessElementUId")]
		public Guid ProcessElementUId
		{
			get{return _ProcessElementUId;}
			set
			{
				_ProcessElementUId = value;
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
		private Guid _ProcessUId;
		[CProperty(ColumnPath ="ProcessUId")]
		public Guid ProcessUId
		{
			get{return _ProcessUId;}
			set
			{
				_ProcessUId = value;
				OnPropertyChanged();
			}
		}
		private string _RecordChangeTypeName;
		[CProperty(ColumnPath ="RecordChangeTypeName")]
		public string RecordChangeTypeName
		{
			get{return _RecordChangeTypeName;}
			set
			{
				_RecordChangeTypeName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
