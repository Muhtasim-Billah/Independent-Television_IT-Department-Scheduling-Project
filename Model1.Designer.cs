﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ITScheduleChecking.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ITDailyMaintenanceModel", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ITDailyMaintenanceModel", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="tID">Initial value of the tID property.</param>
        /// <param name="tName">Initial value of the tName property.</param>
        /// <param name="editAble_600AM">Initial value of the editAble_600AM property.</param>
        /// <param name="doneAt600">Initial value of the doneAt600 property.</param>
        /// <param name="editAble_400PM">Initial value of the editAble_400PM property.</param>
        /// <param name="doneAt400">Initial value of the doneAt400 property.</param>
        /// <param name="editAble_100AM">Initial value of the editAble_100AM property.</param>
        /// <param name="doneAt100">Initial value of the doneAt100 property.</param>
        /// <param name="comment">Initial value of the comment property.</param>
        /// <param name="commentedBy">Initial value of the commentedBy property.</param>
        /// <param name="orderID">Initial value of the orderID property.</param>
        public static Task CreateTask(global::System.Int32 tID, global::System.String tName, global::System.Boolean editAble_600AM, global::System.String doneAt600, global::System.Boolean editAble_400PM, global::System.String doneAt400, global::System.Boolean editAble_100AM, global::System.String doneAt100, global::System.String comment, global::System.Int32 commentedBy, global::System.Int32 orderID)
        {
            Task task = new Task();
            task.tID = tID;
            task.tName = tName;
            task.editAble_600AM = editAble_600AM;
            task.doneAt600 = doneAt600;
            task.editAble_400PM = editAble_400PM;
            task.doneAt400 = doneAt400;
            task.editAble_100AM = editAble_100AM;
            task.doneAt100 = doneAt100;
            task.comment = comment;
            task.commentedBy = commentedBy;
            task.orderID = orderID;
            return task;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tID
        {
            get
            {
                return _tID;
            }
            set
            {
                if (_tID != value)
                {
                    OntIDChanging(value);
                    ReportPropertyChanging("tID");
                    _tID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("tID");
                    OntIDChanged();
                }
            }
        }
        private global::System.Int32 _tID;
        partial void OntIDChanging(global::System.Int32 value);
        partial void OntIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String tName
        {
            get
            {
                return _tName;
            }
            set
            {
                OntNameChanging(value);
                ReportPropertyChanging("tName");
                _tName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("tName");
                OntNameChanged();
            }
        }
        private global::System.String _tName;
        partial void OntNameChanging(global::System.String value);
        partial void OntNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean editAble_600AM
        {
            get
            {
                return _editAble_600AM;
            }
            set
            {
                OneditAble_600AMChanging(value);
                ReportPropertyChanging("editAble_600AM");
                _editAble_600AM = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("editAble_600AM");
                OneditAble_600AMChanged();
            }
        }
        private global::System.Boolean _editAble_600AM;
        partial void OneditAble_600AMChanging(global::System.Boolean value);
        partial void OneditAble_600AMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String doneAt600
        {
            get
            {
                return _doneAt600;
            }
            set
            {
                OndoneAt600Changing(value);
                ReportPropertyChanging("doneAt600");
                _doneAt600 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("doneAt600");
                OndoneAt600Changed();
            }
        }
        private global::System.String _doneAt600;
        partial void OndoneAt600Changing(global::System.String value);
        partial void OndoneAt600Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean editAble_400PM
        {
            get
            {
                return _editAble_400PM;
            }
            set
            {
                OneditAble_400PMChanging(value);
                ReportPropertyChanging("editAble_400PM");
                _editAble_400PM = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("editAble_400PM");
                OneditAble_400PMChanged();
            }
        }
        private global::System.Boolean _editAble_400PM;
        partial void OneditAble_400PMChanging(global::System.Boolean value);
        partial void OneditAble_400PMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String doneAt400
        {
            get
            {
                return _doneAt400;
            }
            set
            {
                OndoneAt400Changing(value);
                ReportPropertyChanging("doneAt400");
                _doneAt400 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("doneAt400");
                OndoneAt400Changed();
            }
        }
        private global::System.String _doneAt400;
        partial void OndoneAt400Changing(global::System.String value);
        partial void OndoneAt400Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean editAble_100AM
        {
            get
            {
                return _editAble_100AM;
            }
            set
            {
                OneditAble_100AMChanging(value);
                ReportPropertyChanging("editAble_100AM");
                _editAble_100AM = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("editAble_100AM");
                OneditAble_100AMChanged();
            }
        }
        private global::System.Boolean _editAble_100AM;
        partial void OneditAble_100AMChanging(global::System.Boolean value);
        partial void OneditAble_100AMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String doneAt100
        {
            get
            {
                return _doneAt100;
            }
            set
            {
                OndoneAt100Changing(value);
                ReportPropertyChanging("doneAt100");
                _doneAt100 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("doneAt100");
                OndoneAt100Changed();
            }
        }
        private global::System.String _doneAt100;
        partial void OndoneAt100Changing(global::System.String value);
        partial void OndoneAt100Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String comment
        {
            get
            {
                return _comment;
            }
            set
            {
                OncommentChanging(value);
                ReportPropertyChanging("comment");
                _comment = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("comment");
                OncommentChanged();
            }
        }
        private global::System.String _comment;
        partial void OncommentChanging(global::System.String value);
        partial void OncommentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 commentedBy
        {
            get
            {
                return _commentedBy;
            }
            set
            {
                OncommentedByChanging(value);
                ReportPropertyChanging("commentedBy");
                _commentedBy = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("commentedBy");
                OncommentedByChanged();
            }
        }
        private global::System.Int32 _commentedBy;
        partial void OncommentedByChanging(global::System.Int32 value);
        partial void OncommentedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CheckedBy
        {
            get
            {
                return _CheckedBy;
            }
            set
            {
                OnCheckedByChanging(value);
                ReportPropertyChanging("CheckedBy");
                _CheckedBy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CheckedBy");
                OnCheckedByChanged();
            }
        }
        private global::System.String _CheckedBy;
        partial void OnCheckedByChanging(global::System.String value);
        partial void OnCheckedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SupervisedBy
        {
            get
            {
                return _SupervisedBy;
            }
            set
            {
                OnSupervisedByChanging(value);
                ReportPropertyChanging("SupervisedBy");
                _SupervisedBy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SupervisedBy");
                OnSupervisedByChanged();
            }
        }
        private global::System.String _SupervisedBy;
        partial void OnSupervisedByChanging(global::System.String value);
        partial void OnSupervisedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 orderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                OnorderIDChanging(value);
                ReportPropertyChanging("orderID");
                _orderID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("orderID");
                OnorderIDChanged();
            }
        }
        private global::System.Int32 _orderID;
        partial void OnorderIDChanging(global::System.Int32 value);
        partial void OnorderIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ITDailyMaintenanceModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userID">Initial value of the userID property.</param>
        /// <param name="userName">Initial value of the userName property.</param>
        /// <param name="userPass">Initial value of the userPass property.</param>
        /// <param name="userlsSupervisor">Initial value of the userlsSupervisor property.</param>
        /// <param name="checkedBy">Initial value of the checkedBy property.</param>
        /// <param name="supervisedBy">Initial value of the supervisedBy property.</param>
        public static User CreateUser(global::System.Int32 userID, global::System.String userName, global::System.String userPass, global::System.Boolean userlsSupervisor, global::System.String checkedBy, global::System.String supervisedBy)
        {
            User user = new User();
            user.userID = userID;
            user.userName = userName;
            user.userPass = userPass;
            user.userlsSupervisor = userlsSupervisor;
            user.checkedBy = checkedBy;
            user.supervisedBy = supervisedBy;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 userID
        {
            get
            {
                return _userID;
            }
            set
            {
                if (_userID != value)
                {
                    OnuserIDChanging(value);
                    ReportPropertyChanging("userID");
                    _userID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("userID");
                    OnuserIDChanged();
                }
            }
        }
        private global::System.Int32 _userID;
        partial void OnuserIDChanging(global::System.Int32 value);
        partial void OnuserIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String userName
        {
            get
            {
                return _userName;
            }
            set
            {
                OnuserNameChanging(value);
                ReportPropertyChanging("userName");
                _userName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("userName");
                OnuserNameChanged();
            }
        }
        private global::System.String _userName;
        partial void OnuserNameChanging(global::System.String value);
        partial void OnuserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String userPass
        {
            get
            {
                return _userPass;
            }
            set
            {
                OnuserPassChanging(value);
                ReportPropertyChanging("userPass");
                _userPass = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("userPass");
                OnuserPassChanged();
            }
        }
        private global::System.String _userPass;
        partial void OnuserPassChanging(global::System.String value);
        partial void OnuserPassChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean userlsSupervisor
        {
            get
            {
                return _userlsSupervisor;
            }
            set
            {
                OnuserlsSupervisorChanging(value);
                ReportPropertyChanging("userlsSupervisor");
                _userlsSupervisor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("userlsSupervisor");
                OnuserlsSupervisorChanged();
            }
        }
        private global::System.Boolean _userlsSupervisor;
        partial void OnuserlsSupervisorChanging(global::System.Boolean value);
        partial void OnuserlsSupervisorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String checkedBy
        {
            get
            {
                return _checkedBy;
            }
            set
            {
                OncheckedByChanging(value);
                ReportPropertyChanging("checkedBy");
                _checkedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("checkedBy");
                OncheckedByChanged();
            }
        }
        private global::System.String _checkedBy;
        partial void OncheckedByChanging(global::System.String value);
        partial void OncheckedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String supervisedBy
        {
            get
            {
                return _supervisedBy;
            }
            set
            {
                OnsupervisedByChanging(value);
                ReportPropertyChanging("supervisedBy");
                _supervisedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("supervisedBy");
                OnsupervisedByChanged();
            }
        }
        private global::System.String _supervisedBy;
        partial void OnsupervisedByChanging(global::System.String value);
        partial void OnsupervisedByChanged();

        #endregion
    
    }

    #endregion
    
}
