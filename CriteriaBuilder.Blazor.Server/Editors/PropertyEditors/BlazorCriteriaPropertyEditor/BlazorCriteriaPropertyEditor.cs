using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using System;
using System.Linq;
using System.ComponentModel;
using DevExpress.Data.Helpers;
using DevExpress.Data;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using CriteriaBuilder.Module.BusinessObjects;

namespace CriteriaBuilder.Blazor.Server.Editors.PropertyEditors.BlazorCriteriaPropertyEditor
{
    [PropertyEditor(typeof(string), "BlazorCriteriaPropertyEditor", false)]
    public class BlazorCriteriaPropertyEditor : BlazorPropertyEditorBase, IComplexViewItem
    {
        public BlazorCriteriaPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

        protected override IComponentAdapter CreateComponentAdapter()
        {
            Type objectType = ((FilteringCriterion)CurrentObject).ObjectType;

            BlazorCriteriaModel model = new BlazorCriteriaModel();
            model.ObjectType = objectType;

            return new BlazorCriteriaAdapter(model);
        }

        #region IComplexViewItem
        private IObjectSpace objectSpace;
        private XafApplication application;

        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            this.objectSpace = objectSpace;
            this.application = application;
        }
        #endregion

        protected override void OnCurrentObjectChanged()
        {
            base.OnCurrentObjectChanged();
            if (Control is not null)
            {
                BlazorCriteriaModel model = ((BlazorCriteriaAdapter)Control).ComponentModel;
                Type objectType = ((FilteringCriterion)CurrentObject).ObjectType;
                string value = ((FilteringCriterion)CurrentObject).CriterionPlusCriteriaRuleJson;
                if (model.ObjectType != objectType)
                {
                    model.ObjectType = objectType;
                }
            }
        }
    }
}
