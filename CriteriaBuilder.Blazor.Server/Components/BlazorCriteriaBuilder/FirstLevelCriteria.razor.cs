using CriteriaBuilder.Blazor.Server.Components.BlazorCriteriaBuilder.Utils;
using Microsoft.AspNetCore.Components;

namespace CriteriaBuilder.Blazor.Server.Components.BlazorCriteriaBuilder
{
    public class FirstLevelCriteriaBase : ComponentBase
    {
        [Parameter]
        public Type TargetType { get; set; }

        [Parameter]
        public CriteriaRule CriteriaRule { get; set; }

        [Parameter]
        public EventCallback<CriteriaRule> CriteriaRuleRemoved { get; set; }

        protected void OnCriteriaRuleRemoved(CriteriaRule criteriaRule)
        {
            CriteriaRuleRemoved.InvokeAsync(criteriaRule);
        }
    }
}
