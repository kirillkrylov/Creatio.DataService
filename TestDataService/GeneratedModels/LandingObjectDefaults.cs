using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LandingObjectDefaults")]
	public class LandingObjectDefaults : BaseEntity
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
		private Guid _ColumnUId;
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId
		{
			get{return _ColumnUId;}
			set
			{
				_ColumnUId = value;
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
		private DateTime _DateTimeValue;
		[CProperty(ColumnPath ="DateTimeValue")]
		public DateTime DateTimeValue
		{
			get{return _DateTimeValue;}
			set
			{
				_DateTimeValue = value;
				OnPropertyChanged();
			}
		}
		private string _DisplayValue;
		[CProperty(ColumnPath ="DisplayValue")]
		public string DisplayValue
		{
			get{return _DisplayValue;}
			set
			{
				_DisplayValue = value;
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
		private int _IntegerValue;
		[CProperty(ColumnPath ="IntegerValue")]
		public int IntegerValue
		{
			get{return _IntegerValue;}
			set
			{
				_IntegerValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _LandingId;
		[CProperty(ColumnPath ="LandingId")]
		public Guid LandingId
		{
			get{return _LandingId;}
			set
			{
				_LandingId = value;
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
		private string _TextValue;
		[CProperty(ColumnPath ="TextValue")]
		public string TextValue
		{
			get{return _TextValue;}
			set
			{
				_TextValue = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:LandingId")]
		public GeneratedWebForm Landing { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
