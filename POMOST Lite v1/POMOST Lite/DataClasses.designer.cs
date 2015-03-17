﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POMOST_Lite
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mops")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdokumenty(dokumenty instance);
    partial void Updatedokumenty(dokumenty instance);
    partial void Deletedokumenty(dokumenty instance);
    partial void Insertświadczenie(świadczenie instance);
    partial void Updateświadczenie(świadczenie instance);
    partial void Deleteświadczenie(świadczenie instance);
    partial void Insertpetent(petent instance);
    partial void Updatepetent(petent instance);
    partial void Deletepetent(petent instance);
    partial void Insertpracownik(pracownik instance);
    partial void Updatepracownik(pracownik instance);
    partial void Deletepracownik(pracownik instance);
    partial void Insertadministratorzy(administratorzy instance);
    partial void Updateadministratorzy(administratorzy instance);
    partial void Deleteadministratorzy(administratorzy instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::POMOST_Lite.Properties.Settings.Default.mopsConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<dokumenty> dokumenties
		{
			get
			{
				return this.GetTable<dokumenty>();
			}
		}
		
		public System.Data.Linq.Table<świadczenie> świadczenies
		{
			get
			{
				return this.GetTable<świadczenie>();
			}
		}
		
		public System.Data.Linq.Table<petent> petents
		{
			get
			{
				return this.GetTable<petent>();
			}
		}
		
		public System.Data.Linq.Table<pracownik> pracowniks
		{
			get
			{
				return this.GetTable<pracownik>();
			}
		}
		
		public System.Data.Linq.Table<administratorzy> administratorzies
		{
			get
			{
				return this.GetTable<administratorzy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dokumenty")]
	public partial class dokumenty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_dokumentu;
		
		private System.DateTime _data;
		
		private string _typ_dokumentu;
		
		private string _zawartość_dokumentu;
		
		private System.Nullable<int> _id_petent;
		
		private System.Nullable<int> _id_pracownik;
		
		private EntitySet<świadczenie> _świadczenies;
		
		private EntityRef<petent> _petent;
		
		private EntityRef<pracownik> _pracownik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_dokumentuChanging(int value);
    partial void Onid_dokumentuChanged();
    partial void OndataChanging(System.DateTime value);
    partial void OndataChanged();
    partial void Ontyp_dokumentuChanging(string value);
    partial void Ontyp_dokumentuChanged();
    partial void Onzawartość_dokumentuChanging(string value);
    partial void Onzawartość_dokumentuChanged();
    partial void Onid_petentChanging(System.Nullable<int> value);
    partial void Onid_petentChanged();
    partial void Onid_pracownikChanging(System.Nullable<int> value);
    partial void Onid_pracownikChanged();
    #endregion
		
		public dokumenty()
		{
			this._świadczenies = new EntitySet<świadczenie>(new Action<świadczenie>(this.attach_świadczenies), new Action<świadczenie>(this.detach_świadczenies));
			this._petent = default(EntityRef<petent>);
			this._pracownik = default(EntityRef<pracownik>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_dokumentu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_dokumentu
		{
			get
			{
				return this._id_dokumentu;
			}
			set
			{
				if ((this._id_dokumentu != value))
				{
					this.Onid_dokumentuChanging(value);
					this.SendPropertyChanging();
					this._id_dokumentu = value;
					this.SendPropertyChanged("id_dokumentu");
					this.Onid_dokumentuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="Date NOT NULL")]
		public System.DateTime data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typ_dokumentu", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string typ_dokumentu
		{
			get
			{
				return this._typ_dokumentu;
			}
			set
			{
				if ((this._typ_dokumentu != value))
				{
					this.Ontyp_dokumentuChanging(value);
					this.SendPropertyChanging();
					this._typ_dokumentu = value;
					this.SendPropertyChanged("typ_dokumentu");
					this.Ontyp_dokumentuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zawartość_dokumentu", DbType="NVarChar(1500) NOT NULL", CanBeNull=false)]
		public string zawartość_dokumentu
		{
			get
			{
				return this._zawartość_dokumentu;
			}
			set
			{
				if ((this._zawartość_dokumentu != value))
				{
					this.Onzawartość_dokumentuChanging(value);
					this.SendPropertyChanging();
					this._zawartość_dokumentu = value;
					this.SendPropertyChanged("zawartość_dokumentu");
					this.Onzawartość_dokumentuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_petent", DbType="Int")]
		public System.Nullable<int> id_petent
		{
			get
			{
				return this._id_petent;
			}
			set
			{
				if ((this._id_petent != value))
				{
					if (this._petent.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_petentChanging(value);
					this.SendPropertyChanging();
					this._id_petent = value;
					this.SendPropertyChanged("id_petent");
					this.Onid_petentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pracownik", DbType="Int")]
		public System.Nullable<int> id_pracownik
		{
			get
			{
				return this._id_pracownik;
			}
			set
			{
				if ((this._id_pracownik != value))
				{
					if (this._pracownik.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pracownikChanging(value);
					this.SendPropertyChanging();
					this._id_pracownik = value;
					this.SendPropertyChanged("id_pracownik");
					this.Onid_pracownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dokumenty_świadczenie", Storage="_świadczenies", ThisKey="id_dokumentu", OtherKey="id_dokumentu")]
		public EntitySet<świadczenie> świadczenies
		{
			get
			{
				return this._świadczenies;
			}
			set
			{
				this._świadczenies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="petent_dokumenty", Storage="_petent", ThisKey="id_petent", OtherKey="id_petent", IsForeignKey=true)]
		public petent petent
		{
			get
			{
				return this._petent.Entity;
			}
			set
			{
				petent previousValue = this._petent.Entity;
				if (((previousValue != value) 
							|| (this._petent.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._petent.Entity = null;
						previousValue.dokumenties.Remove(this);
					}
					this._petent.Entity = value;
					if ((value != null))
					{
						value.dokumenties.Add(this);
						this._id_petent = value.id_petent;
					}
					else
					{
						this._id_petent = default(Nullable<int>);
					}
					this.SendPropertyChanged("petent");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_dokumenty", Storage="_pracownik", ThisKey="id_pracownik", OtherKey="id_pracownik", IsForeignKey=true)]
		public pracownik pracownik
		{
			get
			{
				return this._pracownik.Entity;
			}
			set
			{
				pracownik previousValue = this._pracownik.Entity;
				if (((previousValue != value) 
							|| (this._pracownik.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._pracownik.Entity = null;
						previousValue.dokumenties.Remove(this);
					}
					this._pracownik.Entity = value;
					if ((value != null))
					{
						value.dokumenties.Add(this);
						this._id_pracownik = value.id_pracownik;
					}
					else
					{
						this._id_pracownik = default(Nullable<int>);
					}
					this.SendPropertyChanged("pracownik");
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
		
		private void attach_świadczenies(świadczenie entity)
		{
			this.SendPropertyChanging();
			entity.dokumenty = this;
		}
		
		private void detach_świadczenies(świadczenie entity)
		{
			this.SendPropertyChanging();
			entity.dokumenty = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.świadczenie")]
	public partial class świadczenie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_świadczenia;
		
		private decimal _kwota;
		
		private string _operacja;
		
		private System.DateTime _data;
		
		private System.Nullable<int> _id_pracownik;
		
		private System.Nullable<int> _id_dokumentu;
		
		private EntityRef<dokumenty> _dokumenty;
		
		private EntityRef<pracownik> _pracownik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_świadczeniaChanging(int value);
    partial void Onid_świadczeniaChanged();
    partial void OnkwotaChanging(decimal value);
    partial void OnkwotaChanged();
    partial void OnoperacjaChanging(string value);
    partial void OnoperacjaChanged();
    partial void OndataChanging(System.DateTime value);
    partial void OndataChanged();
    partial void Onid_pracownikChanging(System.Nullable<int> value);
    partial void Onid_pracownikChanged();
    partial void Onid_dokumentuChanging(System.Nullable<int> value);
    partial void Onid_dokumentuChanged();
    #endregion
		
		public świadczenie()
		{
			this._dokumenty = default(EntityRef<dokumenty>);
			this._pracownik = default(EntityRef<pracownik>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_świadczenia", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_świadczenia
		{
			get
			{
				return this._id_świadczenia;
			}
			set
			{
				if ((this._id_świadczenia != value))
				{
					this.Onid_świadczeniaChanging(value);
					this.SendPropertyChanging();
					this._id_świadczenia = value;
					this.SendPropertyChanged("id_świadczenia");
					this.Onid_świadczeniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kwota", DbType="Money NOT NULL")]
		public decimal kwota
		{
			get
			{
				return this._kwota;
			}
			set
			{
				if ((this._kwota != value))
				{
					this.OnkwotaChanging(value);
					this.SendPropertyChanging();
					this._kwota = value;
					this.SendPropertyChanged("kwota");
					this.OnkwotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_operacja", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string operacja
		{
			get
			{
				return this._operacja;
			}
			set
			{
				if ((this._operacja != value))
				{
					this.OnoperacjaChanging(value);
					this.SendPropertyChanging();
					this._operacja = value;
					this.SendPropertyChanged("operacja");
					this.OnoperacjaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="Date NOT NULL")]
		public System.DateTime data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pracownik", DbType="Int")]
		public System.Nullable<int> id_pracownik
		{
			get
			{
				return this._id_pracownik;
			}
			set
			{
				if ((this._id_pracownik != value))
				{
					if (this._pracownik.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pracownikChanging(value);
					this.SendPropertyChanging();
					this._id_pracownik = value;
					this.SendPropertyChanged("id_pracownik");
					this.Onid_pracownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_dokumentu", DbType="Int")]
		public System.Nullable<int> id_dokumentu
		{
			get
			{
				return this._id_dokumentu;
			}
			set
			{
				if ((this._id_dokumentu != value))
				{
					if (this._dokumenty.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_dokumentuChanging(value);
					this.SendPropertyChanging();
					this._id_dokumentu = value;
					this.SendPropertyChanged("id_dokumentu");
					this.Onid_dokumentuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dokumenty_świadczenie", Storage="_dokumenty", ThisKey="id_dokumentu", OtherKey="id_dokumentu", IsForeignKey=true)]
		public dokumenty dokumenty
		{
			get
			{
				return this._dokumenty.Entity;
			}
			set
			{
				dokumenty previousValue = this._dokumenty.Entity;
				if (((previousValue != value) 
							|| (this._dokumenty.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._dokumenty.Entity = null;
						previousValue.świadczenies.Remove(this);
					}
					this._dokumenty.Entity = value;
					if ((value != null))
					{
						value.świadczenies.Add(this);
						this._id_dokumentu = value.id_dokumentu;
					}
					else
					{
						this._id_dokumentu = default(Nullable<int>);
					}
					this.SendPropertyChanged("dokumenty");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_świadczenie", Storage="_pracownik", ThisKey="id_pracownik", OtherKey="id_pracownik", IsForeignKey=true)]
		public pracownik pracownik
		{
			get
			{
				return this._pracownik.Entity;
			}
			set
			{
				pracownik previousValue = this._pracownik.Entity;
				if (((previousValue != value) 
							|| (this._pracownik.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._pracownik.Entity = null;
						previousValue.świadczenies.Remove(this);
					}
					this._pracownik.Entity = value;
					if ((value != null))
					{
						value.świadczenies.Add(this);
						this._id_pracownik = value.id_pracownik;
					}
					else
					{
						this._id_pracownik = default(Nullable<int>);
					}
					this.SendPropertyChanged("pracownik");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.petent")]
	public partial class petent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_petent;
		
		private string _imie;
		
		private string _nazwisko;
		
		private System.DateTime _d_ur;
		
		private string _pesel;
		
		private string _województwo;
		
		private string _miasto;
		
		private string _kod_pocztowy;
		
		private string _ulica;
		
		private System.Nullable<int> _nr_ulicy;
		
		private System.Nullable<int> _nr_mieszkania;
		
		private string _nr_telefonu;
		
		private System.Nullable<int> _id_pracownik;
		
		private EntitySet<dokumenty> _dokumenties;
		
		private EntityRef<pracownik> _pracownik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_petentChanging(int value);
    partial void Onid_petentChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void Ond_urChanging(System.DateTime value);
    partial void Ond_urChanged();
    partial void OnpeselChanging(string value);
    partial void OnpeselChanged();
    partial void OnwojewództwoChanging(string value);
    partial void OnwojewództwoChanged();
    partial void OnmiastoChanging(string value);
    partial void OnmiastoChanged();
    partial void Onkod_pocztowyChanging(string value);
    partial void Onkod_pocztowyChanged();
    partial void OnulicaChanging(string value);
    partial void OnulicaChanged();
    partial void Onnr_ulicyChanging(System.Nullable<int> value);
    partial void Onnr_ulicyChanged();
    partial void Onnr_mieszkaniaChanging(System.Nullable<int> value);
    partial void Onnr_mieszkaniaChanged();
    partial void Onnr_telefonuChanging(string value);
    partial void Onnr_telefonuChanged();
    partial void Onid_pracownikChanging(System.Nullable<int> value);
    partial void Onid_pracownikChanged();
    #endregion
		
		public petent()
		{
			this._dokumenties = new EntitySet<dokumenty>(new Action<dokumenty>(this.attach_dokumenties), new Action<dokumenty>(this.detach_dokumenties));
			this._pracownik = default(EntityRef<pracownik>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_petent", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_petent
		{
			get
			{
				return this._id_petent;
			}
			set
			{
				if ((this._id_petent != value))
				{
					this.Onid_petentChanging(value);
					this.SendPropertyChanging();
					this._id_petent = value;
					this.SendPropertyChanged("id_petent");
					this.Onid_petentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d_ur", DbType="Date NOT NULL")]
		public System.DateTime d_ur
		{
			get
			{
				return this._d_ur;
			}
			set
			{
				if ((this._d_ur != value))
				{
					this.Ond_urChanging(value);
					this.SendPropertyChanging();
					this._d_ur = value;
					this.SendPropertyChanged("d_ur");
					this.Ond_urChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pesel", DbType="Char(11)")]
		public string pesel
		{
			get
			{
				return this._pesel;
			}
			set
			{
				if ((this._pesel != value))
				{
					this.OnpeselChanging(value);
					this.SendPropertyChanging();
					this._pesel = value;
					this.SendPropertyChanged("pesel");
					this.OnpeselChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_województwo", DbType="NVarChar(30)")]
		public string województwo
		{
			get
			{
				return this._województwo;
			}
			set
			{
				if ((this._województwo != value))
				{
					this.OnwojewództwoChanging(value);
					this.SendPropertyChanging();
					this._województwo = value;
					this.SendPropertyChanged("województwo");
					this.OnwojewództwoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_miasto", DbType="NVarChar(30)")]
		public string miasto
		{
			get
			{
				return this._miasto;
			}
			set
			{
				if ((this._miasto != value))
				{
					this.OnmiastoChanging(value);
					this.SendPropertyChanging();
					this._miasto = value;
					this.SendPropertyChanged("miasto");
					this.OnmiastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kod_pocztowy", DbType="NVarChar(20)")]
		public string kod_pocztowy
		{
			get
			{
				return this._kod_pocztowy;
			}
			set
			{
				if ((this._kod_pocztowy != value))
				{
					this.Onkod_pocztowyChanging(value);
					this.SendPropertyChanging();
					this._kod_pocztowy = value;
					this.SendPropertyChanged("kod_pocztowy");
					this.Onkod_pocztowyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ulica", DbType="NVarChar(30)")]
		public string ulica
		{
			get
			{
				return this._ulica;
			}
			set
			{
				if ((this._ulica != value))
				{
					this.OnulicaChanging(value);
					this.SendPropertyChanging();
					this._ulica = value;
					this.SendPropertyChanged("ulica");
					this.OnulicaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nr_ulicy", DbType="Int")]
		public System.Nullable<int> nr_ulicy
		{
			get
			{
				return this._nr_ulicy;
			}
			set
			{
				if ((this._nr_ulicy != value))
				{
					this.Onnr_ulicyChanging(value);
					this.SendPropertyChanging();
					this._nr_ulicy = value;
					this.SendPropertyChanged("nr_ulicy");
					this.Onnr_ulicyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nr_mieszkania", DbType="Int")]
		public System.Nullable<int> nr_mieszkania
		{
			get
			{
				return this._nr_mieszkania;
			}
			set
			{
				if ((this._nr_mieszkania != value))
				{
					this.Onnr_mieszkaniaChanging(value);
					this.SendPropertyChanging();
					this._nr_mieszkania = value;
					this.SendPropertyChanged("nr_mieszkania");
					this.Onnr_mieszkaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nr_telefonu", DbType="Char(9)")]
		public string nr_telefonu
		{
			get
			{
				return this._nr_telefonu;
			}
			set
			{
				if ((this._nr_telefonu != value))
				{
					this.Onnr_telefonuChanging(value);
					this.SendPropertyChanging();
					this._nr_telefonu = value;
					this.SendPropertyChanged("nr_telefonu");
					this.Onnr_telefonuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pracownik", DbType="Int")]
		public System.Nullable<int> id_pracownik
		{
			get
			{
				return this._id_pracownik;
			}
			set
			{
				if ((this._id_pracownik != value))
				{
					if (this._pracownik.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pracownikChanging(value);
					this.SendPropertyChanging();
					this._id_pracownik = value;
					this.SendPropertyChanged("id_pracownik");
					this.Onid_pracownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="petent_dokumenty", Storage="_dokumenties", ThisKey="id_petent", OtherKey="id_petent")]
		public EntitySet<dokumenty> dokumenties
		{
			get
			{
				return this._dokumenties;
			}
			set
			{
				this._dokumenties.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_petent", Storage="_pracownik", ThisKey="id_pracownik", OtherKey="id_pracownik", IsForeignKey=true)]
		public pracownik pracownik
		{
			get
			{
				return this._pracownik.Entity;
			}
			set
			{
				pracownik previousValue = this._pracownik.Entity;
				if (((previousValue != value) 
							|| (this._pracownik.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._pracownik.Entity = null;
						previousValue.petents.Remove(this);
					}
					this._pracownik.Entity = value;
					if ((value != null))
					{
						value.petents.Add(this);
						this._id_pracownik = value.id_pracownik;
					}
					else
					{
						this._id_pracownik = default(Nullable<int>);
					}
					this.SendPropertyChanged("pracownik");
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
		
		private void attach_dokumenties(dokumenty entity)
		{
			this.SendPropertyChanging();
			entity.petent = this;
		}
		
		private void detach_dokumenties(dokumenty entity)
		{
			this.SendPropertyChanging();
			entity.petent = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pracownik")]
	public partial class pracownik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_pracownik;
		
		private string _imie;
		
		private string _nazwisko;
		
		private string _login;
		
		private string _haslo;
		
		private string _dzielnica;
		
		private string _miasto;
		
		private EntitySet<dokumenty> _dokumenties;
		
		private EntitySet<świadczenie> _świadczenies;
		
		private EntitySet<petent> _petents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pracownikChanging(int value);
    partial void Onid_pracownikChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnhasloChanging(string value);
    partial void OnhasloChanged();
    partial void OndzielnicaChanging(string value);
    partial void OndzielnicaChanged();
    partial void OnmiastoChanging(string value);
    partial void OnmiastoChanged();
    #endregion
		
		public pracownik()
		{
			this._dokumenties = new EntitySet<dokumenty>(new Action<dokumenty>(this.attach_dokumenties), new Action<dokumenty>(this.detach_dokumenties));
			this._świadczenies = new EntitySet<świadczenie>(new Action<świadczenie>(this.attach_świadczenies), new Action<świadczenie>(this.detach_świadczenies));
			this._petents = new EntitySet<petent>(new Action<petent>(this.attach_petents), new Action<petent>(this.detach_petents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pracownik", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_pracownik
		{
			get
			{
				return this._id_pracownik;
			}
			set
			{
				if ((this._id_pracownik != value))
				{
					this.Onid_pracownikChanging(value);
					this.SendPropertyChanging();
					this._id_pracownik = value;
					this.SendPropertyChanged("id_pracownik");
					this.Onid_pracownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haslo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string haslo
		{
			get
			{
				return this._haslo;
			}
			set
			{
				if ((this._haslo != value))
				{
					this.OnhasloChanging(value);
					this.SendPropertyChanging();
					this._haslo = value;
					this.SendPropertyChanged("haslo");
					this.OnhasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dzielnica", DbType="NVarChar(50)")]
		public string dzielnica
		{
			get
			{
				return this._dzielnica;
			}
			set
			{
				if ((this._dzielnica != value))
				{
					this.OndzielnicaChanging(value);
					this.SendPropertyChanging();
					this._dzielnica = value;
					this.SendPropertyChanged("dzielnica");
					this.OndzielnicaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_miasto", DbType="NVarChar(50)")]
		public string miasto
		{
			get
			{
				return this._miasto;
			}
			set
			{
				if ((this._miasto != value))
				{
					this.OnmiastoChanging(value);
					this.SendPropertyChanging();
					this._miasto = value;
					this.SendPropertyChanged("miasto");
					this.OnmiastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_dokumenty", Storage="_dokumenties", ThisKey="id_pracownik", OtherKey="id_pracownik")]
		public EntitySet<dokumenty> dokumenties
		{
			get
			{
				return this._dokumenties;
			}
			set
			{
				this._dokumenties.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_świadczenie", Storage="_świadczenies", ThisKey="id_pracownik", OtherKey="id_pracownik")]
		public EntitySet<świadczenie> świadczenies
		{
			get
			{
				return this._świadczenies;
			}
			set
			{
				this._świadczenies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownik_petent", Storage="_petents", ThisKey="id_pracownik", OtherKey="id_pracownik")]
		public EntitySet<petent> petents
		{
			get
			{
				return this._petents;
			}
			set
			{
				this._petents.Assign(value);
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
		
		private void attach_dokumenties(dokumenty entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = this;
		}
		
		private void detach_dokumenties(dokumenty entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = null;
		}
		
		private void attach_świadczenies(świadczenie entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = this;
		}
		
		private void detach_świadczenies(świadczenie entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = null;
		}
		
		private void attach_petents(petent entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = this;
		}
		
		private void detach_petents(petent entity)
		{
			this.SendPropertyChanging();
			entity.pracownik = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.administratorzy")]
	public partial class administratorzy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _login;
		
		private string _haslo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnhasloChanging(string value);
    partial void OnhasloChanged();
    #endregion
		
		public administratorzy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haslo", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string haslo
		{
			get
			{
				return this._haslo;
			}
			set
			{
				if ((this._haslo != value))
				{
					this.OnhasloChanging(value);
					this.SendPropertyChanging();
					this._haslo = value;
					this.SendPropertyChanged("haslo");
					this.OnhasloChanged();
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
