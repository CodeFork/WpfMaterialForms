﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using SchemaPrompt.Launcher.Validation;

namespace SchemaPrompt.Launcher.Schema
{
    public class BaseSchemaViewModel
    {
        private static readonly Random Random = new Random();

        public Visibility IconVisibility { get; set; } = Visibility.Visible;

        public PackIconKind IconKind { get; set; } = (PackIconKind)Random.Next((600));

        public string Hint { get; set; } = "Control Hint";

        public string ToolTip { get; set; } = "Control Tooltip";

        public ValidationRule ValidationRule { get; set; } = new NotEmptyValidationRule();
    }
}
