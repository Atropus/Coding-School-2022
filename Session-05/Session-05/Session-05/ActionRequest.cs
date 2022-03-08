using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest
    {
        public Guid RequestID { get; set; }

        public string Input { get; set; } 

        public ActionEnums Action { get; set; }

        public ActionRequest(Guid requestId, string input, ActionEnums action)
        {
            RequestID = requestId;
            Input = input;
            Action = action;
        }
    }
}
