using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Extensions
{
    public static class ExtensionsMethods
    {
        public static void SetDateTimePickerValue(this DateTimePicker dtp, DateTime? dt)
        {
            if (dt.HasValue)
            {
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Value = dt.Value;
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Custom;
            }
        }

        public static void DateTimePickerValueChanged(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Short;
        }
    }
}
