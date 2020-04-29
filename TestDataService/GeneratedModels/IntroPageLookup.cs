using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntroPageLookup")]
	public class IntroPageLookup : BaseEntity
	{
		#region Values
		private string _AcademyUrl;
		[CProperty(ColumnPath ="AcademyUrl")]
		public string AcademyUrl
		{
			get{return _AcademyUrl;}
			set
			{
				_AcademyUrl = value;
				OnPropertyChanged();
			}
		}
		private string _CodePage;
		[CProperty(ColumnPath ="CodePage")]
		public string CodePage
		{
			get{return _CodePage;}
			set
			{
				_CodePage = value;
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
		private string _VideoCaption;
		[CProperty(ColumnPath ="VideoCaption")]
		public string VideoCaption
		{
			get{return _VideoCaption;}
			set
			{
				_VideoCaption = value;
				OnPropertyChanged();
			}
		}
		private string _VideoUrl;
		[CProperty(ColumnPath ="VideoUrl")]
		public string VideoUrl
		{
			get{return _VideoUrl;}
			set
			{
				_VideoUrl = value;
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
		#endregion
	}
}
