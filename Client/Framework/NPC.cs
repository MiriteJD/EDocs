using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Framework
{
    public abstract class Npc : INotifyPropertyChanged
    {
        protected bool ThrowOnInvalidPropertyName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

       // [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            VerifyPropertyName(propertyName);

            var handler = PropertyChanged;
            if (handler == null)
                return;

            var e = new PropertyChangedEventArgs(propertyName);
            handler(this, e);
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        private void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,  
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] != null)
                return;

            var msg = "Invalid property name: " + propertyName;

            if (ThrowOnInvalidPropertyName)
                throw new Exception(msg);
            else
                Debug.Fail(msg);
        }
    }
}