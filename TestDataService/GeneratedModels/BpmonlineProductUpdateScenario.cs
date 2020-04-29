using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineProductUpdateScenario")]
	public class BpmonlineProductUpdateScenario : BaseEntity
	{
		#region Values
		private Guid _BpmonlineProductId;
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId
		{
			get{return _BpmonlineProductId;}
			set
			{
				_BpmonlineProductId = value;
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
		private string _Localization;
		[CProperty(ColumnPath ="Localization")]
		public string Localization
		{
			get{return _Localization;}
			set
			{
				_Localization = value;
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
		private string _SourceVersion;
		[CProperty(ColumnPath ="SourceVersion")]
		public string SourceVersion
		{
			get{return _SourceVersion;}
			set
			{
				_SourceVersion = value;
				OnPropertyChanged();
			}
		}
		private string _TargetVersion;
		[CProperty(ColumnPath ="TargetVersion")]
		public string TargetVersion
		{
			get{return _TargetVersion;}
			set
			{
				_TargetVersion = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
