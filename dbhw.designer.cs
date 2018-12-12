﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_homework
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbhw")]
	public partial class dbhwDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 擴充性方法定義
    partial void OnCreated();
    partial void Insertbloodpressure(bloodpressure instance);
    partial void Updatebloodpressure(bloodpressure instance);
    partial void Deletebloodpressure(bloodpressure instance);
    #endregion
		
		public dbhwDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbhwConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbhwDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbhwDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbhwDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbhwDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bloodpressure> bloodpressure
		{
			get
			{
				return this.GetTable<bloodpressure>();
			}
		}
	}

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.bloodpressure")]
    public partial class bloodpressure : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _f_ID;

        private System.Nullable<double> _f_SBP;

        private System.Nullable<double> _f_DBP;

        private System.Nullable<int> _f_Age;

        private System.Nullable<System.DateTime> _f_time;

        #region 擴充性方法定義
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void Onf_IDChanging(int value);
        partial void Onf_IDChanged();
        partial void Onf_SBPChanging(System.Nullable<double> value);
        partial void Onf_SBPChanged();
        partial void Onf_DBPChanging(System.Nullable<double> value);
        partial void Onf_DBPChanged();
        partial void Onf_AgeChanging(System.Nullable<int> value);
        partial void Onf_AgeChanged();
        partial void Onf_timeChanging(System.Nullable<System.DateTime> value);
        partial void Onf_timeChanged();
        #endregion

        public bloodpressure()
        {
            OnCreated();
        }
        [DisplayName("編號")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_f_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int f_ID
        {
            get
            {
                return this._f_ID;
            }
            set
            {
                if ((this._f_ID != value))
                {
                    this.Onf_IDChanging(value);
                    this.SendPropertyChanging();
                    this._f_ID = value;
                    this.SendPropertyChanged("f_ID");
                    this.Onf_IDChanged();
                }
            }
        }
		[DisplayName("收縮壓")]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_SBP", DbType="Float")]
		public System.Nullable<double> f_SBP
		{
			get
			{
				return this._f_SBP;
			}
			set
			{
				if ((this._f_SBP != value))
				{
					this.Onf_SBPChanging(value);
					this.SendPropertyChanging();
					this._f_SBP = value;
					this.SendPropertyChanged("f_SBP");
					this.Onf_SBPChanged();
				}
			}
		}
        [DisplayName("舒張壓")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_DBP", DbType="Float")]
		public System.Nullable<double> f_DBP
		{
			get
			{
				return this._f_DBP;
			}
			set
			{
				if ((this._f_DBP != value))
				{
					this.Onf_DBPChanging(value);
					this.SendPropertyChanging();
					this._f_DBP = value;
					this.SendPropertyChanged("f_DBP");
					this.Onf_DBPChanged();
				}
			}
		}
        [DisplayName("年齡")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_Age", DbType="Int")]
		public System.Nullable<int> f_Age
		{
			get
			{
				return this._f_Age;
			}
			set
			{
				if ((this._f_Age != value))
				{
					this.Onf_AgeChanging(value);
					this.SendPropertyChanging();
					this._f_Age = value;
					this.SendPropertyChanged("f_Age");
					this.Onf_AgeChanged();
				}
			}
		}
        [DisplayName("測量時間")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> f_time
		{
			get
			{
				return this._f_time;
			}
			set
			{
				if ((this._f_time != value))
				{
					this.Onf_timeChanging(value);
					this.SendPropertyChanging();
					this._f_time = value;
					this.SendPropertyChanged("f_time");
					this.Onf_timeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591