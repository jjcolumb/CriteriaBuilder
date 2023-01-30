namespace CriteriaBuilder.Blazor.Server.Components.Bases
{
    public class ContextMenuItem
    {
        public virtual string Text { get; set; }
        public virtual string IconUrl { get { return null; } }
        public virtual bool Checked { get; set; }
        public virtual bool HasValue { get { return Checked; } }

        public ContextMenuItem Parent { get; set; }

        public List<ContextMenuItem> Children { get; set; }
        public bool BeginGroup { get; set; }
        public string IconCss { get; set; }
        public string CssClass { get { return Checked ? "checked-item" : ""; } }
        public bool SplitMenuButton { get; set; }
        public string Category { get; set; }
        public string Tooltip { get; set; }
        public virtual bool Enabled => true;
        public virtual void Click() { }
    }
}
