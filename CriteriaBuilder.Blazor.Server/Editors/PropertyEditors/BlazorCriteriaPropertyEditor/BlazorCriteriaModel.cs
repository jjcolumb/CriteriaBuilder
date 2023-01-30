using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Components.Models;

namespace CriteriaBuilder.Blazor.Server.Editors.PropertyEditors.BlazorCriteriaPropertyEditor
{
    public class BlazorCriteriaModel : ComponentModelBase
    {
        public string Value
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }

        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }

        public Type ObjectType
        {
            get => GetPropertyValue<Type>();
            set => SetPropertyValue(value);
        }

        public void SetValueFromUI(string value)
        {
            SetPropertyValue(value, notify: false, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;
    }
}
