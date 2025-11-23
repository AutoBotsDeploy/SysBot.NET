using SysBot.Pokemon.WinForms.Properties;

namespace SysBot.Pokemon.WinForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TC_Main = new System.Windows.Forms.TabControl();
            Tab_Bots = new System.Windows.Forms.TabPage();
            FLP_Bots = new System.Windows.Forms.FlowLayoutPanel();
            FLP_BotCreator = new System.Windows.Forms.FlowLayoutPanel();
            B_New = new System.Windows.Forms.Button();
            TB_IP = new System.Windows.Forms.TextBox();
            NUD_Port = new System.Windows.Forms.TextBox();
            CB_Protocol = new System.Windows.Forms.ComboBox();
            CB_Routine = new System.Windows.Forms.ComboBox();
            FLP_Line = new System.Windows.Forms.FlowLayoutPanel();
            Tab_Hub = new System.Windows.Forms.TabPage();
            PG_Hub = new System.Windows.Forms.PropertyGrid();
            Tab_Logs = new System.Windows.Forms.TabPage();
            RTB_Logs = new System.Windows.Forms.RichTextBox();
            B_Stop = new System.Windows.Forms.Button();
            B_Start = new System.Windows.Forms.Button();
            TC_Main.SuspendLayout();
            Tab_Bots.SuspendLayout();
            FLP_Bots.SuspendLayout();
            FLP_BotCreator.SuspendLayout();
            Tab_Hub.SuspendLayout();
            Tab_Logs.SuspendLayout();
            SuspendLayout();
            // 
            // TC_Main
            // 
            TC_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            TC_Main.Controls.Add(Tab_Bots);
            TC_Main.Controls.Add(Tab_Hub);
            TC_Main.Controls.Add(Tab_Logs);
            TC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            TC_Main.ItemSize = new System.Drawing.Size(70, 30);
            TC_Main.Location = new System.Drawing.Point(0, 0);
            TC_Main.Margin = new System.Windows.Forms.Padding(0);
            TC_Main.Name = "TC_Main";
            TC_Main.SelectedIndex = 0;
            TC_Main.Size = new System.Drawing.Size(684, 248);
            TC_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            TC_Main.TabIndex = 3;
            // 
            // Tab_Bots
            // 
            Tab_Bots.BackColor = System.Drawing.Color.Black;
            Tab_Bots.Controls.Add(FLP_Bots);
            Tab_Bots.ForeColor = System.Drawing.SystemColors.Control;
            Tab_Bots.Location = new System.Drawing.Point(4, 34);
            Tab_Bots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Tab_Bots.Name = "Tab_Bots";
            Tab_Bots.Size = new System.Drawing.Size(676, 210);
            Tab_Bots.TabIndex = 0;
            Tab_Bots.Text = "Bots";
            // 
            // FLP_Bots
            // 
            FLP_Bots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLP_Bots.Controls.Add(FLP_BotCreator);
            FLP_Bots.Controls.Add(FLP_Line);
            FLP_Bots.Dock = System.Windows.Forms.DockStyle.Fill;
            FLP_Bots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLP_Bots.ForeColor = System.Drawing.Color.Lime;
            FLP_Bots.Location = new System.Drawing.Point(0, 0);
            FLP_Bots.Margin = new System.Windows.Forms.Padding(0);
            FLP_Bots.Name = "FLP_Bots";
            FLP_Bots.Size = new System.Drawing.Size(676, 210);
            FLP_Bots.TabIndex = 9;
            FLP_Bots.Paint += FLP_Bots_Paint;
            FLP_Bots.Resize += FLP_Bots_Resize;
            // 
            // FLP_BotCreator
            // 
            FLP_BotCreator.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FLP_BotCreator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            FLP_BotCreator.Controls.Add(B_New);
            FLP_BotCreator.Controls.Add(TB_IP);
            FLP_BotCreator.Controls.Add(NUD_Port);
            FLP_BotCreator.Controls.Add(CB_Protocol);
            FLP_BotCreator.Controls.Add(CB_Routine);
            FLP_Bots.SetFlowBreak(FLP_BotCreator, true);
            FLP_BotCreator.Location = new System.Drawing.Point(0, 0);
            FLP_BotCreator.Margin = new System.Windows.Forms.Padding(0);
            FLP_BotCreator.Name = "FLP_BotCreator";
            FLP_BotCreator.Size = new System.Drawing.Size(65535, 40);
            FLP_BotCreator.TabIndex = 12;
            // 
            // B_New
            // 
            B_New.BackColor = System.Drawing.SystemColors.Control;
            B_New.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            B_New.ForeColor = System.Drawing.SystemColors.ControlText;
            B_New.Location = new System.Drawing.Point(4, 4);
            B_New.Margin = new System.Windows.Forms.Padding(4);
            B_New.Name = "B_New";
            B_New.Size = new System.Drawing.Size(63, 32);
            B_New.TabIndex = 0;
            B_New.Text = "Add";
            B_New.UseVisualStyleBackColor = false;
            B_New.Click += B_New_Click;
            // 
            // TB_IP
            // 
            TB_IP.BackColor = System.Drawing.SystemColors.InfoText;
            TB_IP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            TB_IP.ForeColor = System.Drawing.Color.Lime;
            TB_IP.Location = new System.Drawing.Point(71, 4);
            TB_IP.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            TB_IP.Name = "TB_IP";
            TB_IP.Size = new System.Drawing.Size(150, 32);
            TB_IP.TabIndex = 8;
            TB_IP.Text = "192.168.0.1";
            TB_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_Port
            // 
            NUD_Port.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            NUD_Port.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            NUD_Port.ForeColor = System.Drawing.Color.CornflowerBlue;
            NUD_Port.Location = new System.Drawing.Point(225, 4);
            NUD_Port.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            NUD_Port.Name = "NUD_Port";
            NUD_Port.ReadOnly = true;
            NUD_Port.Size = new System.Drawing.Size(67, 32);
            NUD_Port.TabIndex = 6;
            NUD_Port.Text = "6000";
            NUD_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_Protocol
            // 
            CB_Protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_Protocol.Font = new System.Drawing.Font("Segoe UI", 14F);
            CB_Protocol.FormattingEnabled = true;
            CB_Protocol.Location = new System.Drawing.Point(296, 4);
            CB_Protocol.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            CB_Protocol.Name = "CB_Protocol";
            CB_Protocol.Size = new System.Drawing.Size(67, 33);
            CB_Protocol.TabIndex = 10;
            CB_Protocol.SelectedIndexChanged += CB_Protocol_SelectedIndexChanged;
            // 
            // CB_Routine
            // 
            CB_Routine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_Routine.Font = new System.Drawing.Font("Segoe UI", 14F);
            CB_Routine.FormattingEnabled = true;
            CB_Routine.Location = new System.Drawing.Point(367, 4);
            CB_Routine.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            CB_Routine.Name = "CB_Routine";
            CB_Routine.Size = new System.Drawing.Size(160, 33);
            CB_Routine.TabIndex = 7;
            // 
            // FLP_Line
            // 
            FLP_Line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            FLP_Bots.SetFlowBreak(FLP_Line, true);
            FLP_Line.Location = new System.Drawing.Point(0, 40);
            FLP_Line.Margin = new System.Windows.Forms.Padding(0);
            FLP_Line.Name = "FLP_Line";
            FLP_Line.Size = new System.Drawing.Size(65535, 1);
            FLP_Line.TabIndex = 5;
            // 
            // Tab_Hub
            // 
            Tab_Hub.BackColor = System.Drawing.Color.Black;
            Tab_Hub.Controls.Add(PG_Hub);
            Tab_Hub.ForeColor = System.Drawing.Color.Lime;
            Tab_Hub.Location = new System.Drawing.Point(4, 34);
            Tab_Hub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Tab_Hub.Name = "Tab_Hub";
            Tab_Hub.Size = new System.Drawing.Size(676, 210);
            Tab_Hub.TabIndex = 2;
            Tab_Hub.Text = "Settings";
            // 
            // PG_Hub
            // 
            PG_Hub.BackColor = System.Drawing.SystemColors.Control;
            PG_Hub.CategoryForeColor = System.Drawing.Color.White;
            PG_Hub.CategorySplitterColor = System.Drawing.Color.FromArgb(40, 40, 40);
            PG_Hub.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(0, 192, 0);
            PG_Hub.CommandsBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            PG_Hub.CommandsBorderColor = System.Drawing.Color.Red;
            PG_Hub.DisabledItemForeColor = System.Drawing.Color.Fuchsia;
            PG_Hub.Dock = System.Windows.Forms.DockStyle.Fill;
            PG_Hub.HelpBackColor = System.Drawing.Color.Black;
            PG_Hub.HelpBorderColor = System.Drawing.Color.Black;
            PG_Hub.HelpForeColor = System.Drawing.Color.Lime;
            PG_Hub.LineColor = System.Drawing.Color.FromArgb(0, 44, 0);
            PG_Hub.Location = new System.Drawing.Point(0, 0);
            PG_Hub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PG_Hub.Name = "PG_Hub";
            PG_Hub.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            PG_Hub.SelectedItemWithFocusBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            PG_Hub.SelectedItemWithFocusForeColor = System.Drawing.Color.Yellow;
            PG_Hub.Size = new System.Drawing.Size(676, 210);
            PG_Hub.TabIndex = 0;
            PG_Hub.ViewBackColor = System.Drawing.Color.Black;
            PG_Hub.ViewBorderColor = System.Drawing.Color.Yellow;
            PG_Hub.ViewForeColor = System.Drawing.Color.Lime;
            // 
            // Tab_Logs
            // 
            Tab_Logs.Controls.Add(RTB_Logs);
            Tab_Logs.Location = new System.Drawing.Point(4, 34);
            Tab_Logs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Tab_Logs.Name = "Tab_Logs";
            Tab_Logs.Size = new System.Drawing.Size(676, 210);
            Tab_Logs.TabIndex = 1;
            Tab_Logs.Text = "Logs";
            Tab_Logs.UseVisualStyleBackColor = true;
            // 
            // RTB_Logs
            // 
            RTB_Logs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            RTB_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            RTB_Logs.ForeColor = System.Drawing.Color.Lime;
            RTB_Logs.HideSelection = false;
            RTB_Logs.Location = new System.Drawing.Point(0, 0);
            RTB_Logs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RTB_Logs.Name = "RTB_Logs";
            RTB_Logs.ReadOnly = true;
            RTB_Logs.Size = new System.Drawing.Size(676, 210);
            RTB_Logs.TabIndex = 0;
            RTB_Logs.Text = "";
            // 
            // B_Stop
            // 
            B_Stop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            B_Stop.BackColor = System.Drawing.Color.FromArgb(220, 0, 0);
            B_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Stop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            B_Stop.Location = new System.Drawing.Point(560, 2);
            B_Stop.Margin = new System.Windows.Forms.Padding(0);
            B_Stop.Name = "B_Stop";
            B_Stop.Size = new System.Drawing.Size(80, 28);
            B_Stop.TabIndex = 4;
            B_Stop.Text = "Stop";
            B_Stop.UseVisualStyleBackColor = false;
            B_Stop.Click += B_Stop_Click;
            // 
            // B_Start
            // 
            B_Start.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            B_Start.BackColor = System.Drawing.Color.Lime;
            B_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            B_Start.Location = new System.Drawing.Point(480, 2);
            B_Start.Margin = new System.Windows.Forms.Padding(0);
            B_Start.Name = "B_Start";
            B_Start.Size = new System.Drawing.Size(80, 28);
            B_Start.TabIndex = 3;
            B_Start.Text = "Start";
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += B_Start_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(684, 248);
            Controls.Add(B_Stop);
            Controls.Add(B_Start);
            Controls.Add(TC_Main);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Icon = Resources.icon;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(520, 287);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SysBot.NET (2025.11.23)";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            TC_Main.ResumeLayout(false);
            Tab_Bots.ResumeLayout(false);
            FLP_Bots.ResumeLayout(false);
            FLP_BotCreator.ResumeLayout(false);
            FLP_BotCreator.PerformLayout();
            Tab_Hub.ResumeLayout(false);
            Tab_Logs.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage Tab_Bots;
        private System.Windows.Forms.TabPage Tab_Logs;
        private System.Windows.Forms.RichTextBox RTB_Logs;
        private System.Windows.Forms.TabPage Tab_Hub;
        private System.Windows.Forms.PropertyGrid PG_Hub;
        private System.Windows.Forms.Button B_Stop;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.ComboBox CB_Routine;
        private System.Windows.Forms.TextBox NUD_Port;
        private System.Windows.Forms.Button B_New;
        private System.Windows.Forms.FlowLayoutPanel FLP_Bots;
        private System.Windows.Forms.ComboBox CB_Protocol;
        private System.Windows.Forms.FlowLayoutPanel FLP_BotCreator;
        private System.Windows.Forms.FlowLayoutPanel FLP_Line;
    }
}

