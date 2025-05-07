namespace PoljeAPP
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
            this.btnSljedeci = new System.Windows.Forms.Button();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.btnIza = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtElBr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSljedeci
            // 
            this.btnSljedeci.Location = new System.Drawing.Point(269, 56);
            this.btnSljedeci.Name = "btnSljedeci";
            this.btnSljedeci.Size = new System.Drawing.Size(90, 45);
            this.btnSljedeci.TabIndex = 0;
            this.btnSljedeci.Text = "Sljedeci Element";
            this.btnSljedeci.UseVisualStyleBackColor = true;
            this.btnSljedeci.Click += new System.EventHandler(this.btnSljedeci_Click);
            // 
            // txtElement
            // 
            this.txtElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElement.Location = new System.Drawing.Point(44, 56);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(101, 44);
            this.txtElement.TabIndex = 1;
            // 
            // btnIza
            // 
            this.btnIza.Location = new System.Drawing.Point(173, 56);
            this.btnIza.Name = "btnIza";
            this.btnIza.Size = new System.Drawing.Size(90, 45);
            this.btnIza.TabIndex = 2;
            this.btnIza.Text = "Predhodni element";
            this.btnIza.UseVisualStyleBackColor = true;
            this.btnIza.Click += new System.EventHandler(this.btnIza_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(269, 149);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(90, 45);
            this.btnIspis.TabIndex = 3;
            this.btnIspis.Text = "Ispisi sve";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Izbrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtElBr
            // 
            this.txtElBr.Location = new System.Drawing.Point(326, 21);
            this.txtElBr.Name = "txtElBr";
            this.txtElBr.ReadOnly = true;
            this.txtElBr.Size = new System.Drawing.Size(33, 20);
            this.txtElBr.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 228);
            this.Controls.Add(this.txtElBr);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnIza);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.btnSljedeci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSljedeci;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Button btnIza;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtElBr;
    }
}

