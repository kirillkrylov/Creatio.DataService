using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RegionalLanguagePartner")]
	public class RegionalLanguagePartner : BaseEntity
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
		private bool _IsActual;
		[CProperty(ColumnPath ="IsActual")]
		public bool IsActual
		{
			get{return _IsActual;}
			set
			{
				_IsActual = value;
				OnPropertyChanged();
			}
		}
		private Guid _LanguageId;
		[CProperty(ColumnPath ="LanguageId")]
		public Guid LanguageId
		{
			get{return _LanguageId;}
			set
			{
				_LanguageId = value;
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
		private Guid _PartnerAccountId;
		[CProperty(ColumnPath ="PartnerAccountId")]
		public Guid PartnerAccountId
		{
			get{return _PartnerAccountId;}
			set
			{
				_PartnerAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnershipId;
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId
		{
			get{return _PartnershipId;}
			set
			{
				_PartnershipId = value;
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
		private DateTime _UpdateDate;
		[CProperty(ColumnPath ="UpdateDate")]
		public DateTime UpdateDate
		{
			get{return _UpdateDate;}
			set
			{
				_UpdateDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerAccountId")]
		public Account PartnerAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
