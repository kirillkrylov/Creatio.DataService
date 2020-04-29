using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomerGift")]
	public class GlbCustomerGift : BaseEntity
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
		private Guid _GlbGiftAccountId;
		[CProperty(ColumnPath ="GlbGiftAccountId")]
		public Guid GlbGiftAccountId
		{
			get{return _GlbGiftAccountId;}
			set
			{
				_GlbGiftAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbGiftContactId;
		[CProperty(ColumnPath ="GlbGiftContactId")]
		public Guid GlbGiftContactId
		{
			get{return _GlbGiftContactId;}
			set
			{
				_GlbGiftContactId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbGiftName;
		[CProperty(ColumnPath ="GlbGiftName")]
		public string GlbGiftName
		{
			get{return _GlbGiftName;}
			set
			{
				_GlbGiftName = value;
				OnPropertyChanged();
			}
		}
		private string _GlbGiftNote;
		[CProperty(ColumnPath ="GlbGiftNote")]
		public string GlbGiftNote
		{
			get{return _GlbGiftNote;}
			set
			{
				_GlbGiftNote = value;
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
		private Guid _GlbNoteworthyEventId;
		[CProperty(ColumnPath ="GlbNoteworthyEventId")]
		public Guid GlbNoteworthyEventId
		{
			get{return _GlbNoteworthyEventId;}
			set
			{
				_GlbNoteworthyEventId = value;
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
		[CProperty(Navigation ="Account:GlbGiftAccountId")]
		public Account GlbGiftAccount { get; set; }
		[CProperty(Navigation ="AnniversaryType:GlbNoteworthyEventId")]
		public AnniversaryType GlbNoteworthyEvent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GlbGiftContactId")]
		public Contact GlbGiftContact { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbCustomerGiftFile:GlbCustomerGiftId")]
		public virtual ICollection<GlbCustomerGiftFile> GlbCustomerGiftFileByGlbCustomerGift { get; set; }
		[CProperty(Association ="GlbCustomerGiftInFolder:GlbCustomerGiftId")]
		public virtual ICollection<GlbCustomerGiftInFolder> GlbCustomerGiftInFolderByGlbCustomerGift { get; set; }
		[CProperty(Association ="GlbCustomerGiftInTag:EntityId")]
		public virtual ICollection<GlbCustomerGiftInTag> GlbCustomerGiftInTagByEntity { get; set; }
		#endregion
	}
}
