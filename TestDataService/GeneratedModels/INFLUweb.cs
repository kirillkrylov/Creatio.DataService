using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "INFLUweb")]
	public class INFLUweb : BaseEntity
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
		private string _INFLUNotes;
		[CProperty(ColumnPath ="INFLUNotes")]
		public string INFLUNotes
		{
			get{return _INFLUNotes;}
			set
			{
				_INFLUNotes = value;
				OnPropertyChanged();
			}
		}
		private string _INFLUSection;
		[CProperty(ColumnPath ="INFLUSection")]
		public string INFLUSection
		{
			get{return _INFLUSection;}
			set
			{
				_INFLUSection = value;
				OnPropertyChanged();
			}
		}
		private string _INFLUURL;
		[CProperty(ColumnPath ="INFLUURL")]
		public string INFLUURL
		{
			get{return _INFLUURL;}
			set
			{
				_INFLUURL = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="INFLUwebFile:INFLUwebId")]
		public virtual ICollection<INFLUwebFile> INFLUwebFileByINFLUweb { get; set; }
		[CProperty(Association ="INFLUwebInFolder:INFLUwebId")]
		public virtual ICollection<INFLUwebInFolder> INFLUwebInFolderByINFLUweb { get; set; }
		[CProperty(Association ="INFLUwebInTag:EntityId")]
		public virtual ICollection<INFLUwebInTag> INFLUwebInTagByEntity { get; set; }
		#endregion
	}
}
