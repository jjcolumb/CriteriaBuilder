using DevExpress.Data.Filtering;
using DevExpress.Export.Xl;
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
    public class Employee : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Employee(Session session)
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

        DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => SetPropertyValue(nameof(BirthDate), ref birthDate, value);
        }

        decimal salary;
        public decimal Salary
        {
            get => salary;
            set => SetPropertyValue(nameof(Salary), ref salary, value);
        }

        Address address1;
        public Address Address1
        {
            get => address1;
            set => SetPropertyValue(nameof(Address1), ref address1, value);
        }

        Department department;
        [Association("Department-Employee")]
        public Department Department
        {
            get => department;
            set => SetPropertyValue(nameof(Department), ref department, value);
        }
    }
}