using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Workflow : IActivity
    {
        private List<IActivity> _workflowActivities = new List<IActivity>();

        public Workflow()
        {
            _workflowActivities.Add(new UploadVideo());
            _workflowActivities.Add(new EncodingVideo());
            _workflowActivities.Add(new EmailNotifier());
            _workflowActivities.Add(new VideoDatabase());
        }
        public void Execute()
        {
            foreach (var exec in _workflowActivities)
            {
                exec.Execute();
            }
        }

    }
}
