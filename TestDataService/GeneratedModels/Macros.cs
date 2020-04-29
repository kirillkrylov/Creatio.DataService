using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Macros")]
	public class Macros : BaseEntity
	{
		#region Values
		private Guid _AdditionalParamId;
		[CProperty(ColumnPath ="AdditionalParamId")]
		public Guid AdditionalParamId
		{
			get{return _AdditionalParamId;}
			set
			{
				_AdditionalParamId = value;
				OnPropertyChanged();
			}
		}
		private string _AdditionalParamValue;
		[CProperty(ColumnPath ="AdditionalParamValue")]
		public string AdditionalParamValue
		{
			get{return _AdditionalParamValue;}
			set
			{
				_AdditionalParamValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _CommandId;
		[CProperty(ColumnPath ="CommandId")]
		public Guid CommandId
		{
			get{return _CommandId;}
			set
			{
				_CommandId = value;
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
		private bool _IsShared;
		[CProperty(ColumnPath ="IsShared")]
		public bool IsShared
		{
			get{return _IsShared;}
			set
			{
				_IsShared = value;
				OnPropertyChanged();
			}
		}
		private Guid _MainParamId;
		[CProperty(ColumnPath ="MainParamId")]
		public Guid MainParamId
		{
			get{return _MainParamId;}
			set
			{
				_MainParamId = value;
				OnPropertyChanged();
			}
		}
		private string _MainParamType;
		[CProperty(ColumnPath ="MainParamType")]
		public string MainParamType
		{
			get{return _MainParamType;}
			set
			{
				_MainParamType = value;
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
		[CProperty(Navigation ="AdditionalParam:AdditionalParamId")]
		public AdditionalParam AdditionalParam { get; set; }
		[CProperty(Navigation ="Command:CommandId")]
		public Command Command { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MainParam:MainParamId")]
		public MainParam MainParam { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
