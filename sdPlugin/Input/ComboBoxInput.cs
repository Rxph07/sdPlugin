using System.Collections.Generic;
using System.ComponentModel;

namespace sdPlugin.Input
{
    public class ComboBoxInput : BaseInput, INotifyPropertyChanged
    {
        private List<string> _items = new List<string>();
        public List<string> Items
        {
            get => _items;
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        private int _selectedIndex = 0;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public ComboBoxInput(string name, List<string> items = null) : base(name)
        {
            Items = items != null ? new List<string>(items) : new List<string>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
