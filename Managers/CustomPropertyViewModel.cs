using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.ComponentModel;

namespace SingularityBase.Managers
{
    /// <summary>
    /// Custom property suitable for MVVM. Implements INotifyPropertyChanged
    /// </summary>
    public class CustomPropertyViewModel : ISingleCustomProperty, INotifyPropertyChanged
    {
        private ISingleCustomProperty baseProperty;
        public CustomPropertyViewModel(ISingleCustomProperty property)
        {
            baseProperty = property;
            ResetToDefault();
        }

        public string Name { get; set; }
        public string RawValue { get; set; }
        public string ResolvedValue { get; private set; }
        public swCustomInfoType_e Type { get; set; }
        public string Configuration => baseProperty.Configuration;
        public ISingleModelDoc Document => baseProperty.Document;
        public bool ToBeDeleted { get; set; } 


        //TODO add a command 'Delete'
        //TODO add a command refresh

        /// <summary>
        /// Will indicate if property has changed from last load
        /// </summary>
        public bool HasChanged => Name != baseProperty.Name || RawValue != baseProperty.RawValue || Type != baseProperty.Type || ToBeDeleted;

        public ISingleCustomPropertyManager CustPropMgr => baseProperty.CustPropMgr;
        public CustomPropertyType CustomPropertyType => baseProperty.CustomPropertyType;


        public void ResetToDefault()
        {
            Name = baseProperty.Name;
            RawValue = baseProperty.RawValue;
            ResolvedValue = baseProperty.ResolvedValue;
            Type = baseProperty.Type;
            ToBeDeleted = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
