using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Basics
{
    class WorkFlowEngine
    {
        private readonly IActivity _activity;
        public WorkFlowEngine(IActivity activity)
        {
            _activity = activity;
        }
        public void Run()
        {
            _activity.Execute();
        }

    }
}
