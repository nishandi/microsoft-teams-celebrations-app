// <copyright file="AiHandleErrorAttribute.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Celebration.ErrorHandler
    using System;
    using System.Web.Mvc;
    using Microsoft.ApplicationInsights;

    /// <summary>
    /// Application Insights error logger
    /// </summary>
        public override void OnException(ExceptionContext filterContext)