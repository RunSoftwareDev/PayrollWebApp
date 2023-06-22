namespace Gregg_CourseProject_Part2
{
    partial class MainForm
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
            AddButton = new Button();
            RemoveButton = new Button();
            DisplayButton = new Button();
            PrintPaychecksButton = new Button();
            EmployeesListBox = new ListBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ButtonFace;
            AddButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(96, 61);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(189, 70);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.ButtonFace;
            RemoveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(306, 61);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(189, 70);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.BackColor = SystemColors.ButtonFace;
            DisplayButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayButton.Location = new Point(516, 61);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(189, 70);
            DisplayButton.TabIndex = 2;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = false;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // PrintPaychecksButton
            // 
            PrintPaychecksButton.BackColor = SystemColors.ButtonFace;
            PrintPaychecksButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrintPaychecksButton.Location = new Point(726, 61);
            PrintPaychecksButton.Name = "PrintPaychecksButton";
            PrintPaychecksButton.Size = new Size(189, 70);
            PrintPaychecksButton.TabIndex = 3;
            PrintPaychecksButton.Text = "Print Paychecks";
            PrintPaychecksButton.UseVisualStyleBackColor = false;
            PrintPaychecksButton.Click += PrintPaychecksButton_Click;
            // 
            // EmployeesListBox
            // 
            EmployeesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesListBox.FormattingEnabled = true;
            EmployeesListBox.HorizontalScrollbar = true;
            EmployeesListBox.ItemHeight = 32;
            EmployeesListBox.Location = new Point(96, 170);
            EmployeesListBox.Name = "EmployeesListBox";
            EmployeesListBox.Size = new Size(819, 356);
            EmployeesListBox.TabIndex = 4;
            EmployeesListBox.SelectedIndexChanged += EmployeesListBox_DoubleClick;
            EmployeesListBox.DoubleClick += EmployeesListBox_DoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1132, 617);
            Controls.Add(EmployeesListBox);
            Controls.Add(PrintPaychecksButton);
            Controls.Add(DisplayButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button RemoveButton;
        private Button DisplayButton;
        private Button PrintPaychecksButton;
        public Button AddButton;
        public ListBox EmployeesListBox;
    }
}