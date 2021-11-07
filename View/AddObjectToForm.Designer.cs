namespace View
{
    partial class AddObjectToForm
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
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonGCar = new System.Windows.Forms.RadioButton();
            this.radioButtonHelicopter = new System.Windows.Forms.RadioButton();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.textBoxParam3 = new System.Windows.Forms.TextBox();
            this.labelParam1 = new System.Windows.Forms.Label();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.labelParam3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCRD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(174, 21);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.Text = "Машина";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonGCar
            // 
            this.radioButtonGCar.AutoSize = true;
            this.radioButtonGCar.Location = new System.Drawing.Point(174, 50);
            this.radioButtonGCar.Name = "radioButtonGCar";
            this.radioButtonGCar.Size = new System.Drawing.Size(104, 17);
            this.radioButtonGCar.TabIndex = 1;
            this.radioButtonGCar.Text = "Машина-гибрид";
            this.radioButtonGCar.UseVisualStyleBackColor = true;
            this.radioButtonGCar.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonHelicopter
            // 
            this.radioButtonHelicopter.AutoSize = true;
            this.radioButtonHelicopter.Checked = true;
            this.radioButtonHelicopter.Location = new System.Drawing.Point(174, 76);
            this.radioButtonHelicopter.Name = "radioButtonHelicopter";
            this.radioButtonHelicopter.Size = new System.Drawing.Size(72, 17);
            this.radioButtonHelicopter.TabIndex = 2;
            this.radioButtonHelicopter.TabStop = true;
            this.radioButtonHelicopter.Text = "Вертолёт";
            this.radioButtonHelicopter.UseVisualStyleBackColor = true;
            this.radioButtonHelicopter.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(43, 21);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam1.TabIndex = 3;
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(43, 47);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam2.TabIndex = 4;
            // 
            // textBoxParam3
            // 
            this.textBoxParam3.Location = new System.Drawing.Point(43, 73);
            this.textBoxParam3.Name = "textBoxParam3";
            this.textBoxParam3.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam3.TabIndex = 5;
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Location = new System.Drawing.Point(20, 25);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(17, 13);
            this.labelParam1.TabIndex = 6;
            this.labelParam1.Text = "V:";
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Location = new System.Drawing.Point(20, 50);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(17, 13);
            this.labelParam2.TabIndex = 7;
            this.labelParam2.Text = "S:";
            // 
            // labelParam3
            // 
            this.labelParam3.AutoSize = true;
            this.labelParam3.Location = new System.Drawing.Point(20, 76);
            this.labelParam3.Name = "labelParam3";
            this.labelParam3.Size = new System.Drawing.Size(17, 13);
            this.labelParam3.TabIndex = 8;
            this.labelParam3.Text = "K:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(43, 111);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(43, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonCRD
            // 
            this.buttonCRD.Location = new System.Drawing.Point(43, 197);
            this.buttonCRD.Name = "buttonCRD";
            this.buttonCRD.Size = new System.Drawing.Size(126, 23);
            this.buttonCRD.TabIndex = 11;
            this.buttonCRD.Text = "Create Random Data";
            this.buttonCRD.UseVisualStyleBackColor = true;
            this.buttonCRD.Click += new System.EventHandler(this.ButtonCRD_Click);
            // 
            // AddObjectToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.buttonCRD);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelParam3);
            this.Controls.Add(this.labelParam2);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.textBoxParam3);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.textBoxParam1);
            this.Controls.Add(this.radioButtonHelicopter);
            this.Controls.Add(this.radioButtonGCar);
            this.Controls.Add(this.radioButtonCar);
            this.MaximizeBox = false;
            this.Name = "AddObjectToForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddObjectToForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonGCar;
        private System.Windows.Forms.RadioButton radioButtonHelicopter;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.TextBox textBoxParam3;
        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.Label labelParam2;
        private System.Windows.Forms.Label labelParam3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCRD;
    }
}