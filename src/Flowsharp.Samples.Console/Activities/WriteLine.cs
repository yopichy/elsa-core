﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Flowsharp.Expressions;
using Flowsharp.Models;
using Flowsharp.Results;
using Newtonsoft.Json;
using Activity = Flowsharp.Models.Activity;

namespace Flowsharp.Samples.Console.Activities 
{
    /// <summary>
    /// Writes a text string to the specified stream.
    /// </summary>
    public class WriteLine : Activity
    {
        public WriteLine()
        {
        }

        public WriteLine(string text)
        {
            TextExpression = new WorkflowExpression<string>(PlainTextEvaluator.SyntaxName, text);
        }
        
        public WorkflowExpression<string> TextExpression { get; set; }
    }
}
