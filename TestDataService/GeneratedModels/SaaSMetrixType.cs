using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaaSMetrixType")]
	public class SaaSMetrixType : BaseEntity
	{
		#region Values
		private Guid _ARRBucketId;
		[CProperty(ColumnPath ="ARRBucketId")]
		public Guid ARRBucketId
		{
			get{return _ARRBucketId;}
			set
			{
				_ARRBucketId = value;
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
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountARRBucket:ARRBucketId")]
		public AccountARRBucket ARRBucket { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SaaSMetrix:MetrixTypeId")]
		public virtual ICollection<SaaSMetrix> SaaSMetrixByMetrixType { get; set; }
		#endregion
	}
}
