﻿using System.Drawing;
using System.Windows.Forms;

namespace ExaltAccountManager
{
    public partial class ChangeLogEntry : UserControl
    {
        bool isSecond = false;
        public ChangeLogEntry(string headline, string entries, string releaseDate, bool isDarkmode, bool _isSecond = false)
        {
            InitializeComponent();
            isSecond = _isSecond;

            LoadUI(headline, entries, releaseDate);
            ApplyTheme(isDarkmode);
        }

        private void LoadUI(string headline, string entries, string releaseDate)
        {
            lHeadline.Text = headline;
            lEntry.Text = entries;
            lReleaseDate.Text = releaseDate;

            this.Height = lEntry.Bottom + 5;
        }

        public void ApplyTheme(bool isDarkmode)
        {
            if (isDarkmode)
            {
                Color def = Color.FromArgb(32, 32, 32);
                Color second = Color.FromArgb(23, 23, 23);
                Color third = Color.FromArgb(0, 0, 0);
                Color font = Color.White;

                this.ForeColor = font;
                this.BackColor = isSecond ? def : second;
                pLine.BackColor = font;
            }
            else if (isSecond) this.BackColor = Color.White;
        }
    }
}
