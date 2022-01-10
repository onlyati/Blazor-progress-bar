using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyAti.Blazor.ProgressBar.Model;

namespace OnlyAti.Blazor.ProgressBar
{
    public partial class ProgressBar : ComponentBase
    {
        [Parameter]
        public ProgressBarConfig Config { get; set; } = new();
    }
}
