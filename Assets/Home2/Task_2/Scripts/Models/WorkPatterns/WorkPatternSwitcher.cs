using System.Collections.Generic;
using System.Linq;
using System;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public class WorkPatternSwitcher {
        private Dictionary<Type, BaseWorkPattern> _workPatterns = new();
        public BaseWorkPattern CurrentPattern { get; private set; }

        public WorkPatternSwitcher(BaseWorkPattern[] workPatterns) {
            _workPatterns = workPatterns.ToDictionary(pattern => pattern.GetType());
            CurrentPattern = workPatterns[0];
        }

        public void SetNewCurrentPattern<T>() where T : BaseWorkPattern {
            CurrentPattern = _workPatterns[typeof(T)];
        }
    }
}