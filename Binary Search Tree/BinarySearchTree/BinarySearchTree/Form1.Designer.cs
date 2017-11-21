namespace BinarySearchTree
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonFindMin = new System.Windows.Forms.Button();
            this.buttonFindMax = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonMakeEmpty = new System.Windows.Forms.Button();
            this.buttonIsEmpty = new System.Windows.Forms.Button();
            this.buttonTrace = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxEmpty = new System.Windows.Forms.TextBox();
            this.textBoxTrace = new System.Windows.Forms.TextBox();
            this.textBoxRoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(288, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 238);
            this.listBox1.TabIndex = 0;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(54, 65);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(49, 23);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(109, 65);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(60, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(69, 94);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 23);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "RemoveMin";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonFindMin
            // 
            this.buttonFindMin.Location = new System.Drawing.Point(69, 162);
            this.buttonFindMin.Name = "buttonFindMin";
            this.buttonFindMin.Size = new System.Drawing.Size(75, 23);
            this.buttonFindMin.TabIndex = 4;
            this.buttonFindMin.Text = "FindMin";
            this.buttonFindMin.UseVisualStyleBackColor = true;
            this.buttonFindMin.Click += new System.EventHandler(this.buttonFindMin_Click);
            // 
            // buttonFindMax
            // 
            this.buttonFindMax.Location = new System.Drawing.Point(69, 191);
            this.buttonFindMax.Name = "buttonFindMax";
            this.buttonFindMax.Size = new System.Drawing.Size(75, 23);
            this.buttonFindMax.TabIndex = 5;
            this.buttonFindMax.Text = "FindMax";
            this.buttonFindMax.UseVisualStyleBackColor = true;
            this.buttonFindMax.Click += new System.EventHandler(this.buttonFindMax_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(69, 220);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonMakeEmpty
            // 
            this.buttonMakeEmpty.Location = new System.Drawing.Point(69, 319);
            this.buttonMakeEmpty.Name = "buttonMakeEmpty";
            this.buttonMakeEmpty.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeEmpty.TabIndex = 7;
            this.buttonMakeEmpty.Text = "Make Empty";
            this.buttonMakeEmpty.UseVisualStyleBackColor = true;
            this.buttonMakeEmpty.Click += new System.EventHandler(this.buttonMakeEmpty_Click);
            // 
            // buttonIsEmpty
            // 
            this.buttonIsEmpty.Location = new System.Drawing.Point(69, 290);
            this.buttonIsEmpty.Name = "buttonIsEmpty";
            this.buttonIsEmpty.Size = new System.Drawing.Size(75, 23);
            this.buttonIsEmpty.TabIndex = 8;
            this.buttonIsEmpty.Text = "Is Empty";
            this.buttonIsEmpty.UseVisualStyleBackColor = true;
            this.buttonIsEmpty.Click += new System.EventHandler(this.buttonIsEmpty_Click);
            // 
            // buttonTrace
            // 
            this.buttonTrace.Location = new System.Drawing.Point(288, 394);
            this.buttonTrace.Name = "buttonTrace";
            this.buttonTrace.Size = new System.Drawing.Size(75, 23);
            this.buttonTrace.TabIndex = 9;
            this.buttonTrace.Text = "Trace";
            this.buttonTrace.UseVisualStyleBackColor = true;
            this.buttonTrace.Click += new System.EventHandler(this.buttonTrace_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(54, 39);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(113, 20);
            this.textBoxInput.TabIndex = 11;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(54, 136);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(113, 20);
            this.textBoxFind.TabIndex = 12;
            // 
            // textBoxEmpty
            // 
            this.textBoxEmpty.Enabled = false;
            this.textBoxEmpty.Location = new System.Drawing.Point(54, 264);
            this.textBoxEmpty.Name = "textBoxEmpty";
            this.textBoxEmpty.Size = new System.Drawing.Size(113, 20);
            this.textBoxEmpty.TabIndex = 13;
            // 
            // textBoxTrace
            // 
            this.textBoxTrace.Location = new System.Drawing.Point(288, 368);
            this.textBoxTrace.Name = "textBoxTrace";
            this.textBoxTrace.Size = new System.Drawing.Size(575, 20);
            this.textBoxTrace.TabIndex = 14;
            // 
            // textBoxRoot
            // 
            this.textBoxRoot.Enabled = false;
            this.textBoxRoot.Location = new System.Drawing.Point(343, 280);
            this.textBoxRoot.Name = "textBoxRoot";
            this.textBoxRoot.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoot.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Root is ";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(508, 278);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(124, 23);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "Generate Random";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 480);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoot);
            this.Controls.Add(this.textBoxTrace);
            this.Controls.Add(this.textBoxEmpty);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonTrace);
            this.Controls.Add(this.buttonIsEmpty);
            this.Controls.Add(this.buttonMakeEmpty);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonFindMax);
            this.Controls.Add(this.buttonFindMin);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Binary Search Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonFindMin;
        private System.Windows.Forms.Button buttonFindMax;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonMakeEmpty;
        private System.Windows.Forms.Button buttonIsEmpty;
        private System.Windows.Forms.Button buttonTrace;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxEmpty;
        private System.Windows.Forms.TextBox textBoxTrace;
        private System.Windows.Forms.TextBox textBoxRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

