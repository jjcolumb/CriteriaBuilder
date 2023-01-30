namespace CriteriaBuilder.Blazor.Server.Components.BlazorCriteriaBuilder.Utils
{
    public class CriteriaRuleDataField
    {
        public string Text { get; set; }
        public CriteriaRuleDataType DataType { get; set; }
        public Type OriginalType { get; set; }

        public CriteriaRuleDataField Parent { get; set; }
        public IEnumerable<CriteriaRuleDataField> Children { get; set; }

        public static CriteriaRuleDataType GetCriteriaRuleDataType(Type type)
        {
            Dictionary<Type, CriteriaRuleDataType> mapDictionary = new Dictionary<Type, CriteriaRuleDataType>()
            {
                { typeof(string), CriteriaRuleDataType.String },
                { typeof(bool), CriteriaRuleDataType.Boolean },
                { typeof(int), CriteriaRuleDataType.Number },
                { typeof(decimal), CriteriaRuleDataType.Number },
                { typeof(double), CriteriaRuleDataType.Number },
                { typeof(Guid), CriteriaRuleDataType.Guid },
                { typeof(DateTime), CriteriaRuleDataType.Date },
            };

            if (mapDictionary.ContainsKey(type))
            {
                return mapDictionary[type];
            }
            else if (type.IsEnum)
            {
                return CriteriaRuleDataType.Enum;
            }
            else
            {
                return CriteriaRuleDataType.Object;
            }
        }
    }

    public enum CriteriaRuleDataType
    {
        String,
        Number,
        Boolean,
        Enum,
        Guid,
        Date,
        Object
    }
}
