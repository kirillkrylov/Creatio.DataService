using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CompletenessParameter")]
	public class CompletenessParameter : BaseEntity
	{
		#region Values
		private Guid _AttributeId;
		[CProperty(ColumnPath ="AttributeId")]
		public Guid AttributeId
		{
			get{return _AttributeId;}
			set
			{
				_AttributeId = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnName;
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName
		{
			get{return _ColumnName;}
			set
			{
				_ColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _CompletenessId;
		[CProperty(ColumnPath ="CompletenessId")]
		public Guid CompletenessId
		{
			get{return _CompletenessId;}
			set
			{
				_CompletenessId = value;
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
		private string _DetailColumn;
		[CProperty(ColumnPath ="DetailColumn")]
		public string DetailColumn
		{
			get{return _DetailColumn;}
			set
			{
				_DetailColumn = value;
				OnPropertyChanged();
			}
		}
		private string _DetailEntityName;
		[CProperty(ColumnPath ="DetailEntityName")]
		public string DetailEntityName
		{
			get{return _DetailEntityName;}
			set
			{
				_DetailEntityName = value;
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
		private bool _IsColumn;
		[CProperty(ColumnPath ="IsColumn")]
		public bool IsColumn
		{
			get{return _IsColumn;}
			set
			{
				_IsColumn = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDetail;
		[CProperty(ColumnPath ="IsDetail")]
		public bool IsDetail
		{
			get{return _IsDetail;}
			set
			{
				_IsDetail = value;
				OnPropertyChanged();
			}
		}
		private string _MasterColumn;
		[CProperty(ColumnPath ="MasterColumn")]
		public string MasterColumn
		{
			get{return _MasterColumn;}
			set
			{
				_MasterColumn = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _Percentage;
		[CProperty(ColumnPath ="Percentage")]
		public int Percentage
		{
			get{return _Percentage;}
			set
			{
				_Percentage = value;
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
		private string _TypeColumn;
		[CProperty(ColumnPath ="TypeColumn")]
		public string TypeColumn
		{
			get{return _TypeColumn;}
			set
			{
				_TypeColumn = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeValue;
		[CProperty(ColumnPath ="TypeValue")]
		public Guid TypeValue
		{
			get{return _TypeValue;}
			set
			{
				_TypeValue = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Completeness:CompletenessId")]
		public Completeness Completeness { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
