using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AttributeInSiteEvent")]
	public class AttributeInSiteEvent : BaseEntity
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
		private Guid _ProductCategoryValueId;
		[CProperty(ColumnPath ="ProductCategoryValueId")]
		public Guid ProductCategoryValueId
		{
			get{return _ProductCategoryValueId;}
			set
			{
				_ProductCategoryValueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductTradeMarkValueId;
		[CProperty(ColumnPath ="ProductTradeMarkValueId")]
		public Guid ProductTradeMarkValueId
		{
			get{return _ProductTradeMarkValueId;}
			set
			{
				_ProductTradeMarkValueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductTypeValueId;
		[CProperty(ColumnPath ="ProductTypeValueId")]
		public Guid ProductTypeValueId
		{
			get{return _ProductTypeValueId;}
			set
			{
				_ProductTypeValueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductValueId;
		[CProperty(ColumnPath ="ProductValueId")]
		public Guid ProductValueId
		{
			get{return _ProductValueId;}
			set
			{
				_ProductValueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SiteEventAttributeId;
		[CProperty(ColumnPath ="SiteEventAttributeId")]
		public Guid SiteEventAttributeId
		{
			get{return _SiteEventAttributeId;}
			set
			{
				_SiteEventAttributeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SiteEventId;
		[CProperty(ColumnPath ="SiteEventId")]
		public Guid SiteEventId
		{
			get{return _SiteEventId;}
			set
			{
				_SiteEventId = value;
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
		[CProperty(Navigation ="Product:ProductValueId")]
		public Product ProductValue { get; set; }
		[CProperty(Navigation ="ProductCategory:ProductCategoryValueId")]
		public ProductCategory ProductCategoryValue { get; set; }
		[CProperty(Navigation ="ProductType:ProductTypeValueId")]
		public ProductType ProductTypeValue { get; set; }
		[CProperty(Navigation ="SiteEvent:SiteEventId")]
		public SiteEvent SiteEvent { get; set; }
		[CProperty(Navigation ="SiteEventAttribute:SiteEventAttributeId")]
		public SiteEventAttribute SiteEventAttribute { get; set; }
		[CProperty(Navigation ="SiteEventAttrListItem:ListItemValueId")]
		public SiteEventAttrListItem ListItemValue { get; set; }
		[CProperty(Navigation ="TradeMark:ProductTradeMarkValueId")]
		public TradeMark ProductTradeMarkValue { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
