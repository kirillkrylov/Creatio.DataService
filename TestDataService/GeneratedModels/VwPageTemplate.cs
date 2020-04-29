using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPageTemplate")]
	public class VwPageTemplate : BaseEntity
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
		private string _PageSchemaName;
		[CProperty(ColumnPath ="PageSchemaName")]
		public string PageSchemaName
		{
			get{return _PageSchemaName;}
			set
			{
				_PageSchemaName = value;
				OnPropertyChanged();
			}
		}
		private Guid _PageSchemaUId;
		[CProperty(ColumnPath ="PageSchemaUId")]
		public Guid PageSchemaUId
		{
			get{return _PageSchemaUId;}
			set
			{
				_PageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
				OnPropertyChanged();
			}
		}
		private Guid _PreviewImageId;
		[CProperty(ColumnPath ="PreviewImageId")]
		public Guid PreviewImageId
		{
			get{return _PreviewImageId;}
			set
			{
				_PreviewImageId = value;
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
		private string _SchemaCaption;
		[CProperty(ColumnPath ="SchemaCaption")]
		public string SchemaCaption
		{
			get{return _SchemaCaption;}
			set
			{
				_SchemaCaption = value;
				OnPropertyChanged();
			}
		}
		private string _SchemaDescription;
		[CProperty(ColumnPath ="SchemaDescription")]
		public string SchemaDescription
		{
			get{return _SchemaDescription;}
			set
			{
				_SchemaDescription = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaId;
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId
		{
			get{return _SysSchemaId;}
			set
			{
				_SysSchemaId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:PreviewImageId")]
		public SysImage PreviewImage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
