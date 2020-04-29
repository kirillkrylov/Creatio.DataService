using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EnrchTextEntity")]
	public class EnrchTextEntity : BaseEntity
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
		private string _DuplicationStatus;
		[CProperty(ColumnPath ="DuplicationStatus")]
		public string DuplicationStatus
		{
			get{return _DuplicationStatus;}
			set
			{
				_DuplicationStatus = value;
				OnPropertyChanged();
			}
		}
		private Guid _EnrchEmailDataId;
		[CProperty(ColumnPath ="EnrchEmailDataId")]
		public Guid EnrchEmailDataId
		{
			get{return _EnrchEmailDataId;}
			set
			{
				_EnrchEmailDataId = value;
				OnPropertyChanged();
			}
		}
		private string _Hash;
		[CProperty(ColumnPath ="Hash")]
		public string Hash
		{
			get{return _Hash;}
			set
			{
				_Hash = value;
				OnPropertyChanged();
			}
		}
		private int _HashVersion;
		[CProperty(ColumnPath ="HashVersion")]
		public int HashVersion
		{
			get{return _HashVersion;}
			set
			{
				_HashVersion = value;
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
		private string _JsonData;
		[CProperty(ColumnPath ="JsonData")]
		public string JsonData
		{
			get{return _JsonData;}
			set
			{
				_JsonData = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private string _Source;
		[CProperty(ColumnPath ="Source")]
		public string Source
		{
			get{return _Source;}
			set
			{
				_Source = value;
				OnPropertyChanged();
			}
		}
		private string _Type;
		[CProperty(ColumnPath ="Type")]
		public string Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EnrchEmailData:EnrchEmailDataId")]
		public EnrchEmailData EnrchEmailData { get; set; }
		[CProperty(Navigation ="EnrchTextEntity:ParentId")]
		public EnrchTextEntity Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EnrchFoundAccount:EnrchTextEntityId")]
		public virtual ICollection<EnrchFoundAccount> EnrchFoundAccountByEnrchTextEntity { get; set; }
		[CProperty(Association ="EnrchFoundContact:EnrchTextEntityId")]
		public virtual ICollection<EnrchFoundContact> EnrchFoundContactByEnrchTextEntity { get; set; }
		[CProperty(Association ="EnrchTextEntity:ParentId")]
		public virtual ICollection<EnrchTextEntity> EnrchTextEntityByParent { get; set; }
		#endregion
	}
}
