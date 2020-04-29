using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwActiveProduct")]
	public class VwActiveProduct : BaseEntity
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
		[CProperty(Navigation ="SocialSubscription:SubscriptionId")]
		public SocialSubscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
