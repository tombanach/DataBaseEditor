using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.UserInterface.Classes
{
    class StatusChangeEventArgs : EventArgs
    {
        public StatusChangeModel StatusChange { private set; get; }

        public StatusChangeEventArgs(StatusChangeModel statusChange)
        {
            StatusChange = statusChange;
        }
    }
}
