using SignLanguage.MVVM.Model.Interface;

namespace SignLanguage.MVVM.Model
{
    class ModelClass : IModel
    {
        public event ValueChangedHandler ValueChanged;

        public static string StringValue { get; }
        private string stringValue;
        private void SetText(string newText)
        {
            if (stringValue == newText)
                return;

            string oldText = stringValue;
            stringValue = newText;

            ValueChanged?.Invoke(this, nameof(StringValue), oldText, stringValue);
        }

        public void SendValue(string valueName, object newValue)
        {
            switch (valueName)
            {
                case nameof(StringValue): SetText((string)newValue); break;
                default: throw new System.ArgumentException(nameof(valueName));
            }
        }

        public bool ValidateValue(string valueName, object newValue)
        {
            switch (valueName)
            {
                case nameof(StringValue): return newValue is string;
                default: return false;
            }
        }

        public void AllValueChanged()
        {
            ValueChanged?.Invoke(this, nameof(StringValue), null, stringValue);
        }
    }
}