namespace Creatio.DataService
{
    public class Parameter
    {
        public Parameter() { }

        public Enums.DataValueType DataValueType { get; set; }

        public bool ShouldSerializeValue()
        {
            return (Value != null);
        }
        public object Value { get; set; }


        public bool ShouldSerializeArrayValue()
        {
            return (ArrayValue != null && ArrayValue.Length > 0);
        }
        public string[] ArrayValue { get; set; }

        /// <summary>
        /// Indicates whether the value conversion process should be skipped in 
        /// Terrasoft.Nui.ServiceModel.DataContract.Parameter.GetValue(Terrasoft.Core.UserConnection,Terrasoft.Core.DataValueType,System.Boolean).
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeShouldSkipConvertion()
        {
            return (ShouldSkipConvertion);
        }
        public bool ShouldSkipConvertion { get; set; }
    }
}
