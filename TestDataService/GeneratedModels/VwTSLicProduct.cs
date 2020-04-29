using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwTSLicProduct")]
	public class VwTSLicProduct : BaseEntity
	{
		#region Values
		private DateTime _ActivationDate;
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate
		{
			get{return _ActivationDate;}
			set
			{
				_ActivationDate = value;
				OnPropertyChanged();
			}
		}
		private int _Count;
		[CProperty(ColumnPath ="Count")]
		public int Count
		{
			get{return _Count;}
			set
			{
				_Count = value;
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
		private DateTime _DeactivationDate;
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate
		{
			get{return _DeactivationDate;}
			set
			{
				_DeactivationDate = value;
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
		private bool _IsCompetitive;
		[CProperty(ColumnPath ="IsCompetitive")]
		public bool IsCompetitive
		{
			get{return _IsCompetitive;}
			set
			{
				_IsCompetitive = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTrial;
		[CProperty(ColumnPath ="IsTrial")]
		public bool IsTrial
		{
			get{return _IsTrial;}
			set
			{
				_IsTrial = value;
				OnPropertyChanged();
			}
		}
		private Guid _KindId;
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId
		{
			get{return _KindId;}
			set
			{
				_KindId = value;
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
		private string _Product;
		[CProperty(ColumnPath ="Product")]
		public string Product
		{
			get{return _Product;}
			set
			{
				_Product = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionId;
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId
		{
			get{return _SubscriptionId;}
			set
			{
				_SubscriptionId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductKind:KindId")]
		public ProductKind Kind { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
