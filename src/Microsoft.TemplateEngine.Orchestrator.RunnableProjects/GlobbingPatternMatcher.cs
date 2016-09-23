﻿using Microsoft.TemplateEngine.Core.Contracts;
using Microsoft.TemplateEngine.Utils;

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects
{
    public class GlobbingPatternMatcher : IPathMatcher
    {
        private readonly Glob _pattern;

        public string Pattern { get; }

        public GlobbingPatternMatcher(string pattern)
        {
            Pattern = pattern;
            _pattern = Glob.Parse(pattern);
        }

        public bool IsMatch(string path)
        {
            return _pattern.IsMatch(path);
        }
    }
}
