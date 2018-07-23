﻿namespace DillenManagementStudio
{
    partial class FrmCommandExplanation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommandExplanation));
            this.lbTitle = new System.Windows.Forms.Label();
            this.rchtxtTryCode = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grvSelectTry = new System.Windows.Forms.DataGridView();
            this.lbExecutionResult = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rchtxtAux = new System.Windows.Forms.RichTextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(209, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(400, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Part of Command Explanation";
            // 
            // rchtxtTryCode
            // 
            this.rchtxtTryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTryCode.Location = new System.Drawing.Point(24, 281);
            this.rchtxtTryCode.Name = "rchtxtTryCode";
            this.rchtxtTryCode.Size = new System.Drawing.Size(315, 234);
            this.rchtxtTryCode.TabIndex = 2;
            this.rchtxtTryCode.Text = "";
            this.rchtxtTryCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCommandExplanation_KeyDown);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(349, 379);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(78, 50);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute >>";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 530);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(64, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(754, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grvSelectTry
            // 
            this.grvSelectTry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSelectTry.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvSelectTry.Location = new System.Drawing.Point(438, 297);
            this.grvSelectTry.Name = "grvSelectTry";
            this.grvSelectTry.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvSelectTry.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvSelectTry.Size = new System.Drawing.Size(361, 218);
            this.grvSelectTry.TabIndex = 6;
            // 
            // lbExecutionResult
            // 
            this.lbExecutionResult.AutoSize = true;
            this.lbExecutionResult.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExecutionResult.ForeColor = System.Drawing.Color.Green;
            this.lbExecutionResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbExecutionResult.Location = new System.Drawing.Point(438, 279);
            this.lbExecutionResult.Name = "lbExecutionResult";
            this.lbExecutionResult.Size = new System.Drawing.Size(138, 15);
            this.lbExecutionResult.TabIndex = 31;
            this.lbExecutionResult.Text = "Succesfully executed!";
            this.lbExecutionResult.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(344, 281);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(26, 26);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rchtxtAux
            // 
            this.rchtxtAux.Location = new System.Drawing.Point(24, 281);
            this.rchtxtAux.Name = "rchtxtAux";
            this.rchtxtAux.Size = new System.Drawing.Size(249, 161);
            this.rchtxtAux.TabIndex = 33;
            this.rchtxtAux.Text = "";
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.Image = global::DillenManagementStudio.Properties.Resources.Loading_icon1;
            this.picLoading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLoading.Location = new System.Drawing.Point(116, 329);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(66, 66);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 38;
            this.picLoading.TabStop = false;
            // 
            // FrmCommandExplanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 565);
            this.Controls.Add(this.rchtxtTryCode);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbExecutionResult);
            this.Controls.Add(this.grvSelectTry);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.rchtxtAux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCommandExplanation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCommandExplanation_FormClosed);
            this.Shown += new System.EventHandler(this.FrmCommandExplanation_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCommandExplanation_KeyDown);
            this.Resize += new System.EventHandler(this.FrmCommandExplanation_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RichTextBox rchtxtTryCode;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView grvSelectTry;
        private System.Windows.Forms.Label lbExecutionResult;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RichTextBox rchtxtAux;
        private System.Windows.Forms.PictureBox picLoading;
    }
}