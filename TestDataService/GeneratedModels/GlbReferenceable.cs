using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbReferenceable")]
	public class GlbReferenceable : BaseEntity
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
		private Guid _GlbAccountCustomerId;
		[CProperty(ColumnPath ="GlbAccountCustomerId")]
		public Guid GlbAccountCustomerId
		{
			get{return _GlbAccountCustomerId;}
			set
			{
				_GlbAccountCustomerId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbName;
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName
		{
			get{return _GlbName;}
			set
			{
				_GlbName = value;
				OnPropertyChanged();
			}
		}
		private string _GlbNotes;
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes
		{
			get{return _GlbNotes;}
			set
			{
				_GlbNotes = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbReferenceableDetailsId;
		[CProperty(ColumnPath ="GlbReferenceableDetailsId")]
		public Guid GlbReferenceableDetailsId
		{
			get{return _GlbReferenceableDetailsId;}
			set
			{
				_GlbReferenceableDetailsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbReferenceableTypeId;
		[CProperty(ColumnPath ="GlbReferenceableTypeId")]
		public Guid GlbReferenceableTypeId
		{
			get{return _GlbReferenceableTypeId;}
			set
			{
				_GlbReferenceableTypeId = value;
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
		[CProperty(Navigation ="Account:GlbAccountCustomerId")]
		public Account GlbAccountCustomer { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlbReferenceableDetails:GlbReferenceableDetailsId")]
		public GlbReferenceableDetails GlbReferenceableDetails { get; set; }
		[CProperty(Navigation ="GlbReferenceableTypeValue:GlbReferenceableTypeId")]
		public GlbReferenceableTypeValue GlbReferenceableType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbReferenceableFile:GlbReferenceableId")]
		public virtual ICollection<GlbReferenceableFile> GlbReferenceableFileByGlbReferenceable { get; set; }
		[CProperty(Association ="GlbReferenceableInFolder:GlbReferenceableId")]
		public virtual ICollection<GlbReferenceableInFolder> GlbReferenceableInFolderByGlbReferenceable { get; set; }
		[CProperty(Association ="GlbReferenceableInTag:EntityId")]
		public virtual ICollection<GlbReferenceableInTag> GlbReferenceableInTagByEntity { get; set; }
		#endregion
	}
}
