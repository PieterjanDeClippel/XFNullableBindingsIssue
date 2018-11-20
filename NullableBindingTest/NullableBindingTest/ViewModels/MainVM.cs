using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NullableBindingTest.ViewModels
{
    public class MainVM : BaseVM
    {
        #region NullableValue
        private int? nullable_value;
        public int? NullableValue
        {
            get { return nullable_value; }
            set
            {
                nullable_value = value;
                OnPropertyChanged(nameof(NullableValue));
            }
        }
        #endregion
        #region Value
        private int val;
        public int Value
        {
            get { return val; }
            set
            {
                val = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Text
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region ResetTextCommand
        private Command reset_text_command;
        public Command ResetTextCommand
        {
            get { return reset_text_command; }
            set
            {
                reset_text_command = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region ResetNumbersCommand
        private Command reset_numbers_command;
        public Command ResetNumbersCommand
        {
            get { return reset_numbers_command; }
            set
            {
                reset_numbers_command = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
