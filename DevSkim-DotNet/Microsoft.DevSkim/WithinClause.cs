﻿// Copyright (C) Microsoft. All rights reserved. Licensed under the MIT License.

using Microsoft.CST.OAT;

namespace Microsoft.DevSkim
{
    internal class WithinClause : Clause
    {
        public WithinClause(string? field = null) : base(Operation.Custom, field) 
        {
            CustomOperation = "Within";
        }

        public int Before { get; set; }
        public int After { get; set; }
        public bool FindingOnly { get; set; }
        public bool SameLineOnly { get; internal set; }
    }
}