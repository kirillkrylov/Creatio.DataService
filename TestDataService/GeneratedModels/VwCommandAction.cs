using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCommandAction")]
	public class VwCommandAction : BaseEntity
	{
		#region Values
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
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnCaption;
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption
		{
			get{return _ColumnCaption;}
			set
			{
				_ColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _CommandActionId;
		[CProperty(ColumnPath ="CommandActionId")]
		public Guid CommandActionId
		{
			get{return _CommandActionId;}
			set
			{
				_CommandActionId = value;
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
		private string _MainParamCation;
		[CProperty(ColumnPath ="MainParamCation")]
		public string MainParamCation
		{
			get{return _MainParamCation;}
			set
			{
				_MainParamCation = value;
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
		private int _OrderColumn;
		[CProperty(ColumnPath ="OrderColumn")]
		public int OrderColumn
		{
			get{return _OrderColumn;}
			set
			{
				_OrderColumn = value;
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
		private Guid _SubjectColumnUId;
		[CProperty(ColumnPath ="SubjectColumnUId")]
		public Guid SubjectColumnUId
		{
			get{return _SubjectColumnUId;}
			set
			{
				_SubjectColumnUId = value;
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
		private string _TypeColumnCode;
		[CProperty(ColumnPath ="TypeColumnCode")]
		public string TypeColumnCode
		{
			get{return _TypeColumnCode;}
			set
			{
				_TypeColumnCode = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnUId;
		[CProperty(ColumnPath ="TypeColumnUId")]
		public Guid TypeColumnUId
		{
			get{return _TypeColumnUId;}
			set
			{
				_TypeColumnUId = value;
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
