using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineVersion")]
	public class BpmonlineVersion : BaseEntity
	{
		#region Values
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private DateTime _ReleaseDate;
		[CProperty(ColumnPath ="ReleaseDate")]
		public DateTime ReleaseDate
		{
			get{return _ReleaseDate;}
			set
			{
				_ReleaseDate = value;
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
		[CProperty(Association ="BpmonlineBuild:BpmonlineVersionId")]
		public virtual ICollection<BpmonlineBuild> BpmonlineBuildByBpmonlineVersion { get; set; }
		[CProperty(Association ="BpmonlineBuildVersion:BpmonlineVersionId")]
		public virtual ICollection<BpmonlineBuildVersion> BpmonlineBuildVersionByBpmonlineVersion { get; set; }
		[CProperty(Association ="ConfItem:BpmonlineVersionId")]
		public virtual ICollection<ConfItem> ConfItemByBpmonlineVersion { get; set; }
		[CProperty(Association ="Problem:FoundInVersionId")]
		public virtual ICollection<Problem> ProblemByFoundInVersion { get; set; }
		[CProperty(Association ="Problem:ResolvedInVersionId")]
		public virtual ICollection<Problem> ProblemByResolvedInVersion { get; set; }
		[CProperty(Association ="Product:PlatformVersionId")]
		public virtual ICollection<Product> ProductByPlatformVersion { get; set; }
		[CProperty(Association ="Release:BpmonlineVersionId")]
		public virtual ICollection<Release> ReleaseByBpmonlineVersion { get; set; }
		#endregion
	}
}
