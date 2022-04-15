namespace SignLanguage.MVVM.Model.Interface
{
    public delegate void ValueChangedHandler(object sender, string valueName, object oldValue, object newValue);
    public interface IModel
    {
        event ValueChangedHandler ValueChanged;
        void SendValue(string valueName, object newValue);
        bool ValidateValue(string valueName, object newValue);
        void AllValueChanged();
    }
}