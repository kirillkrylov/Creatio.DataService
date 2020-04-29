using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LevelPartnershipParam")]
	public class LevelPartnershipParam : BaseEntity
	{
		#region Values
		private bool _BooleanValue;
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue
		{
			get{return _BooleanValue;}
			set
			{
				_BooleanValue = value;
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _FloatValue;
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue
		{
			get{return _FloatValue;}
			set
			{
				_FloatValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _GuidValue;
		[CProperty(ColumnPath ="GuidValue")]
		public Guid GuidValue
		{
			get{return _GuidValue;}
			set
			{
				_GuidValue = value;
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
		private int _IntValue;
		[CProperty(ColumnPath ="IntValue")]
		public int IntValue
		{
			get{return _IntValue;}
			set
			{
				_IntValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _ListItemValueId;
		[CProperty(ColumnPath ="ListItemValueId")]
		public Guid ListItemValueId
		{
			get{return _ListItemValueId;}
			set
			{
				_ListItemValueId = value;
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
		private Guid _ParameterTypeId;
		[CProperty(ColumnPath ="ParameterTypeId")]
		public Guid ParameterTypeId
		{
			get{return _ParameterTypeId;}
			set
			{
				_ParameterTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParameterValueTypeId;
		[CProperty(ColumnPath ="ParameterValueTypeId")]
		public Guid ParameterValueTypeId
		{
			get{return _ParameterValueTypeId;}
			set
			{
				_ParameterValueTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerLevelId;
		[CProperty(ColumnPath ="PartnerLevelId")]
		public Guid PartnerLevelId
		{
			get{return _PartnerLevelId;}
			set
			{
				_PartnerLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerParamCategoryId;
		[CProperty(ColumnPath ="PartnerParamCategoryId")]
		public Guid PartnerParamCategoryId
		{
			get{return _PartnerParamCategoryId;}
			set
			{
				_PartnerParamCategoryId = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private int _Score;
		[CProperty(ColumnPath ="Score")]
		public int Score
		{
			get{return _Score;}
			set
			{
				_Score = value;
				OnPropertyChanged();
			}
		}
		private Guid _SpecificationId;
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId
		{
			get{return _SpecificationId;}
			set
			{
				_SpecificationId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private string _StringValue;
		[CProperty(ColumnPath ="StringValue")]
		public string StringValue
		{
			get{return _StringValue;}
			set
			{
				_StringValue = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ParameterType:ParameterTypeId")]
		public ParameterType ParameterType { get; set; }
		[CProperty(Navigation ="PartnerLevel:PartnerLevelId")]
		public PartnerLevel PartnerLevel { get; set; }
		[CProperty(Navigation ="PartnerParamCategory:PartnerParamCategoryId")]
		public PartnerParamCategory PartnerParamCategory { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		[CProperty(Navigation ="SpecificationListItem:ListItemValueId")]
		public SpecificationListItem ListItemValue { get; set; }
		[CProperty(Navigation ="SpecificationType:ParameterValueTypeId")]
		public SpecificationType ParameterValueType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
