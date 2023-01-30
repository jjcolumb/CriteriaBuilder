using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CriteriaBuilder.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Department : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Department(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string name;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        bool isPrincipal;
        public bool IsPrincipal
        {
            get => isPrincipal;
            set => SetPropertyValue(nameof(IsPrincipal), ref isPrincipal, value);
        }

        int number;
        public int Number
        {
            get => number;
            set => SetPropertyValue(nameof(Number), ref number, value);
        }

        DepartmentType departmentType;
        public DepartmentType DepartmentType
        {
            get => departmentType;
            set => SetPropertyValue(nameof(DepartmentType), ref departmentType, value);
        }

        [Association("Department-Employee")]
        public XPCollection<Employee> Employees
        {
            get
            {
                return GetCollection<Employee>(nameof(Employees));
            }
        }
    }

    public enum DepartmentType
    {
        RootDepartment,
        PrimaryDepartment,
        SecondaryDepartment
    }
}