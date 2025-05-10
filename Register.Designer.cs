namespace Student_Tracking_System
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RoleCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegToLogButton = new System.Windows.Forms.Button();
            this.studentTrackerDataSet = new Student_Tracking_System.StudentTrackerDataSet();
            this.studentTrackerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordBox.Location = new System.Drawing.Point(143, 127);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(229, 30);
            this.PasswordBox.TabIndex = 7;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameBox.Location = new System.Drawing.Point(143, 22);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(229, 30);
            this.UsernameBox.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordLabel.Location = new System.Drawing.Point(24, 132);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(109, 25);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password :";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameLabel.Location = new System.Drawing.Point(24, 27);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(113, 25);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username :";
            // 
            // RoleCombo
            // 
            this.RoleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.RoleCombo.Location = new System.Drawing.Point(143, 234);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(229, 30);
            this.RoleCombo.TabIndex = 8;
            this.RoleCombo.SelectedIndexChanged += new System.EventHandler(this.RoleCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Role :";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(532, 352);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(181, 52);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegToLogButton
            // 
            this.RegToLogButton.Location = new System.Drawing.Point(92, 352);
            this.RegToLogButton.Name = "RegToLogButton";
            this.RegToLogButton.Size = new System.Drawing.Size(181, 52);
            this.RegToLogButton.TabIndex = 11;
            this.RegToLogButton.Text = "Login Page";
            this.RegToLogButton.UseVisualStyleBackColor = true;
            this.RegToLogButton.Click += new System.EventHandler(this.RegToLogButton_Click);
            // 
            // studentTrackerDataSet
            // 
            this.studentTrackerDataSet.DataSetName = "StudentTrackerDataSet";
            this.studentTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTrackerDataSetBindingSource
            // 
            this.studentTrackerDataSetBindingSource.DataSource = this.studentTrackerDataSet;
            this.studentTrackerDataSetBindingSource.Position = 0;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastNameBox.Location = new System.Drawing.Point(532, 127);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(229, 30);
            this.LastNameBox.TabIndex = 15;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstNameBox.Location = new System.Drawing.Point(532, 22);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(229, 30);
            this.FirstNameBox.TabIndex = 14;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastNameLabel.Location = new System.Drawing.Point(413, 132);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(117, 25);
            this.LastNameLabel.TabIndex = 13;
            this.LastNameLabel.Text = "Last Name :";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstNameLabel.Location = new System.Drawing.Point(413, 27);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(117, 25);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "First Name :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.RegToLogButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleCombo);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ComboBox RoleCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button RegToLogButton;
        private StudentTrackerDataSet studentTrackerDataSet;
        private System.Windows.Forms.BindingSource studentTrackerDataSetBindingSource;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}