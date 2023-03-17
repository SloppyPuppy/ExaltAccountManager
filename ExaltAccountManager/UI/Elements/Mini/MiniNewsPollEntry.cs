﻿using Bunifu.UI.WinForms.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaltAccountManager.UI.Elements.Mini
{
    public sealed partial class MiniNewsPollEntry : UserControl
    {
        private FrmMain frm;
        private int entryNumber = -1;
        private int votes = 0;
        private int allVotes = 0;
        private bool isOwnVote = false;
        private string entryText = "";
        private bool reveal = false;
        public event EventHandler OnClick;
        public MiniNewsPollEntry(FrmMain _frm, int _entryNumber, int _votes, int allVotes, bool isOwnVote, string entryText, bool _reveal)
        {
            InitializeComponent();
            frm = _frm;

            this.entryNumber = _entryNumber;
            this.votes = _votes;
            this.allVotes = allVotes;
            this.isOwnVote = isOwnVote;
            this.entryText = entryText;
            this.reveal = _reveal;

            SetReveal(reveal);

            lChoice.Text = entryText;
            lResults.Text = (allVotes == 0 ? 0 : (Math.Round((float)votes / (float)allVotes * 100f))) + "%";
            radioOwnChoice.Visible = isOwnVote;

            frm.ThemeChanged += ApplyTheme;
            this.Disposed += (s, e) => frm.ThemeChanged -= ApplyTheme;
            ApplyTheme(frm, null);
        }

        private void ApplyTheme(object sender, EventArgs e)
        {
            this.BackColor = ColorScheme.GetColorDef(frm.UseDarkmode);
            this.ForeColor = ColorScheme.GetColorFont(frm.UseDarkmode);
        }

        public void SetReveal(bool _reveal)
        {
            pPercentage.Visible = reveal = _reveal;

            this.Invalidate();
        }

        public void SetOwnVote(bool _isOwnVote)
        {
            radioOwnChoice.Visible = isOwnVote = _isOwnVote;
        }

        private void MiniNewsPollEntry_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawResultbar(e.Graphics, (float)votes / (float)allVotes * 100f);

            //Draw border
            using (Pen p = new System.Drawing.Pen(ColorScheme.GetColorSecond(frm.UseDarkmode), 1))
            {
                var lines = entryNumber == 0 ? 
                new Point[] 
                {
                        new Point(0, 0),
                        new Point(0, this.Height - 1),
                        new Point(this.Width - 1, this.Height - 1),
                        new Point(this.Width - 1, 0),
                        new Point(0, 0)
                } :
                new Point[]
                {
                    new Point(0, 0),
                        new Point(0, this.Height - 1),
                        new Point(this.Width - 1, this.Height - 1),
                        new Point(this.Width - 1, 0),
                };
                e.Graphics.DrawLines(p, lines);
            }
        }

        private void DrawResultbar(Graphics g, float percentage)
        {
            if (!reveal)
                return;

            float fillWidth = ((float)Width * percentage) / 100f;
            Color fillColor = Color.FromArgb(175, 98, 0, 238);

            using (SolidBrush brush = new SolidBrush(fillColor))
            {
                g.FillRectangle(brush, 0, 0, fillWidth, this.Height);
            }
        }

        private void MiniNewsPollEntry_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = frm.UseDarkmode ? this.BackColor.LightenBy(3) : this.BackColor.DarkenBy(3);
        }

        private void MiniNewsPollEntry_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorScheme.GetColorDef(frm.UseDarkmode);
        }

        private void MiniNewsPollEntry_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, e);
        }
    }
}
