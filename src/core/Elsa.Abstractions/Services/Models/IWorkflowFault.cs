﻿using Elsa.Models;
using Microsoft.Extensions.Localization;

namespace Elsa.Services.Models
{
    public interface IWorkflowFault
    {
        ActivityDefinition? FaultedActivity { get; }
        LocalizedString? Message { get; }
    }
}