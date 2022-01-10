using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyAti.Blazor.ProgressBar.Model
{
    public class ProgressBarConfig
    {
        /// <summary>
        /// How much percentage should be showed by progress bar? Default: 0
        /// </summary>
        public int PercentageValue { get; set; }

        /// <summary>
        /// When can the progress bar have OK color? Default: 80
        /// </summary>
        public int OkLimit { get; set; } = 80;

        /// <summary>
        /// When can the progress bar have warning color? Default: 40
        /// </summary>
        public int WarningLimit { get; set; } = 40;

        /// <summary>
        /// Color of progressbar if OK limit reached. Default: #107C10
        /// </summary>
        public Color OkColor { get; set; } = Color.FromArgb(0x10, 0x7C, 0x10);

        /// <summary>
        /// Color of progress bar if warning limit reached. Default: #F6AB29
        /// </summary>
        public Color WarningColor { get; set; } = Color.FromArgb(0xF6, 0xB2, 0x29);

        /// <summary>
        /// Color of progress bar is value is less then warning limit. Default: #A80000
        /// </summary>
        public Color ErrorColor { get; set; } = Color.FromArgb(0xA8, 0x00, 0x00);

        /// <summary>
        /// If it is set to false, then text is displayed on progress bar and it becomes inactive. Default: true
        /// </summary>
        public bool ShowPercentage { get; set; } = true;

        /// <summary>
        /// It is displayed instead of percentage if ShowPercentage set to false. Default: Inactive
        /// </summary>
        public string InactiveText { get; set; } = "Inactive";

        /// <summary>
        /// Color of progress bar if ShowPercentage set to false. Default: #8A8886
        /// </summary>
        public Color InactiveColor { get; set; } = Color.FromArgb(0x8A, 0x88, 0x86);

        /// <summary>
        /// Color of status text (percentage or InactiveText). Default: #11100F
        /// </summary>
        public Color StatusTextColor { get; set; } = Color.FromArgb(0x11, 0x10, 0x0F);

        /// <summary>
        /// How many space should be top and bottom of the status text? Default: 3 (in px unit)
        /// </summary>
        public int UpBottomMargin { get; set; } = 3;
    }
}
