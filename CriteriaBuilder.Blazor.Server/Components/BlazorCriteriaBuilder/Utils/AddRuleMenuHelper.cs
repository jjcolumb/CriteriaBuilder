using CriteriaBuilder.Blazor.Server.Components.Bases;

namespace CriteriaBuilder.Blazor.Server.Components.BlazorCriteriaBuilder.Utils
{
    public class AddRuleMenuHelper
    {
        public static IEnumerable<TreeItem> GetAddRuleMenuItems()
        {
            IEnumerable<TreeItem> ruleMenuItems = new List<TreeItem>()
            {
                new TreeItem(){ Name = "Add Condition"},
                //new TreeItem(){ Name = "Add Group"},
            };

            return ruleMenuItems;
        }
    }
}
