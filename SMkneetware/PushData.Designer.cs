namespace SMkneetware
{
    partial class PushData
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
            this.dataGridViewSetup = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonPush = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSetup
            // 
            this.dataGridViewSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSetup.Location = new System.Drawing.Point(178, 2);
            this.dataGridViewSetup.Name = "dataGridViewSetup";
            this.dataGridViewSetup.ReadOnly = true;
            this.dataGridViewSetup.Size = new System.Drawing.Size(646, 491);
            this.dataGridViewSetup.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(35, 84);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(92, 47);
            this.buttonPush.TabIndex = 13;
            this.buttonPush.Text = "ADD";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // PushData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridViewSetup);
            this.Name = "PushData";
            this.Text = "PushData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSetup;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonPush;
    }
}