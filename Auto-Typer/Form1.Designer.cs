namespace Auto_Typer
{
    partial class Form1
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
            Stop = new Button();
            Type = new Button();
            TB001 = new TextBox();
            TB002 = new TextBox();
            label1 = new Label();
            TB003 = new TextBox();
            SuspendLayout();
            // 
            // Stop
            // 
            Stop.Location = new Point(200, 157);
            Stop.Name = "Stop";
            Stop.Size = new Size(94, 29);
            Stop.TabIndex = 0;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Type
            // 
            Type.Location = new Point(200, 104);
            Type.Name = "Type";
            Type.Size = new Size(94, 29);
            Type.TabIndex = 0;
            Type.Text = "Type";
            Type.UseVisualStyleBackColor = true;
            Type.Click += Type_Click;
            // 
            // TB001
            // 
            TB001.Location = new Point(12, 58);
            TB001.Name = "TB001";
            TB001.Size = new Size(125, 27);
            TB001.TabIndex = 1;
            // 
            // TB002
            // 
            TB002.Location = new Point(182, 58);
            TB002.Name = "TB002";
            TB002.Size = new Size(125, 27);
            TB002.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Interval";
            // 
            // TB003
            // 
            TB003.Location = new Point(12, 106);
            TB003.Name = "TB003";
            TB003.Size = new Size(125, 27);
            TB003.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(TB003);
            Controls.Add(label1);
            Controls.Add(TB002);
            Controls.Add(TB001);
            Controls.Add(Type);
            Controls.Add(Stop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Stop;
        private Button Type;
        private TextBox TB001;
        private TextBox TB002;
        private Label label1;
        private TextBox TB003;
    }
}