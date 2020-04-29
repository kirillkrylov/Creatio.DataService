using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatAddValue")]
	public class SiteStatAddValue : BaseEntity
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
		private Guid _SiteStatId;
		[CProperty(ColumnPath ="SiteStatId")]
		public Guid SiteStatId
		{
			get{return _SiteStatId;}
			set
			{
				_SiteStatId = value;
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
		[CProperty(Navigation ="SiteStat:SiteStatId")]
		public SiteStat SiteStat { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
