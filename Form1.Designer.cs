
namespace Weather_app
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelWeatherInfo1 = new System.Windows.Forms.Panel();
            this.comboBoxCity1 = new System.Windows.Forms.ComboBox();
            this.labTemperature1 = new System.Windows.Forms.Label();
            this.btnIcon1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelWeatherInfo2 = new System.Windows.Forms.Panel();
            this.comboBoxCity2 = new System.Windows.Forms.ComboBox();
            this.labTemperature2 = new System.Windows.Forms.Label();
            this.btnIcon2 = new System.Windows.Forms.Button();
            this.panelWeatherInfo3 = new System.Windows.Forms.Panel();
            this.comboBoxCity3 = new System.Windows.Forms.ComboBox();
            this.labTemperature3 = new System.Windows.Forms.Label();
            this.btnIcon3 = new System.Windows.Forms.Button();
            this.panelWeatherInfo4 = new System.Windows.Forms.Panel();
            this.comboBoxCity4 = new System.Windows.Forms.ComboBox();
            this.labTemperature4 = new System.Windows.Forms.Label();
            this.btnIcon4 = new System.Windows.Forms.Button();
            this.panelWeatherInfo5 = new System.Windows.Forms.Panel();
            this.comboBoxCity5 = new System.Windows.Forms.ComboBox();
            this.labTemperature5 = new System.Windows.Forms.Label();
            this.btnIcon5 = new System.Windows.Forms.Button();
            this.panelWeatherInfo1.SuspendLayout();
            this.panelWeatherInfo2.SuspendLayout();
            this.panelWeatherInfo3.SuspendLayout();
            this.panelWeatherInfo4.SuspendLayout();
            this.panelWeatherInfo5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWeatherInfo1
            // 
            this.panelWeatherInfo1.BackColor = System.Drawing.Color.Silver;
            this.panelWeatherInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWeatherInfo1.Controls.Add(this.comboBoxCity1);
            this.panelWeatherInfo1.Controls.Add(this.labTemperature1);
            this.panelWeatherInfo1.Controls.Add(this.btnIcon1);
            this.panelWeatherInfo1.Location = new System.Drawing.Point(104, 75);
            this.panelWeatherInfo1.Name = "panelWeatherInfo1";
            this.panelWeatherInfo1.Size = new System.Drawing.Size(584, 83);
            this.panelWeatherInfo1.TabIndex = 0;
            this.panelWeatherInfo1.Paint += new System.Windows.Forms.PaintEventHandler(this.weatherInfo_Paint);
            // 
            // comboBoxCity1
            // 
            this.comboBoxCity1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCity1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCity1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCity1.FormattingEnabled = true;
            this.comboBoxCity1.Location = new System.Drawing.Point(103, 12);
            this.comboBoxCity1.Name = "comboBoxCity1";
            this.comboBoxCity1.Size = new System.Drawing.Size(186, 33);
            this.comboBoxCity1.TabIndex = 7;
            this.comboBoxCity1.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // labTemperature1
            // 
            this.labTemperature1.AutoSize = true;
            this.labTemperature1.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTemperature1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labTemperature1.Location = new System.Drawing.Point(524, 0);
            this.labTemperature1.Name = "labTemperature1";
            this.labTemperature1.Size = new System.Drawing.Size(60, 31);
            this.labTemperature1.TabIndex = 6;
            this.labTemperature1.Text = "N/A";
            this.labTemperature1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTemperature1.Click += new System.EventHandler(this.labTemperature_Click);
            // 
            // btnIcon1
            // 
            this.btnIcon1.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIcon1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon1.FlatAppearance.BorderSize = 0;
            this.btnIcon1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIcon1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIcon1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon1.ImageKey = "sunny_icon.png";
            this.btnIcon1.ImageList = this.imageList1;
            this.btnIcon1.Location = new System.Drawing.Point(0, 0);
            this.btnIcon1.Name = "btnIcon1";
            this.btnIcon1.Size = new System.Drawing.Size(97, 83);
            this.btnIcon1.TabIndex = 5;
            this.btnIcon1.Text = "N/A";
            this.btnIcon1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcon1.UseVisualStyleBackColor = false;
            this.btnIcon1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sunny_icon.png");
            this.imageList1.Images.SetKeyName(1, "clouds_sun_icon.png");
            this.imageList1.Images.SetKeyName(2, "cloudy_icon.png");
            this.imageList1.Images.SetKeyName(3, "rain_icon.png");
            this.imageList1.Images.SetKeyName(4, "snow_icon.png");
            // 
            // panelWeatherInfo2
            // 
            this.panelWeatherInfo2.BackColor = System.Drawing.Color.Silver;
            this.panelWeatherInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWeatherInfo2.Controls.Add(this.comboBoxCity2);
            this.panelWeatherInfo2.Controls.Add(this.labTemperature2);
            this.panelWeatherInfo2.Controls.Add(this.btnIcon2);
            this.panelWeatherInfo2.Location = new System.Drawing.Point(104, 180);
            this.panelWeatherInfo2.Name = "panelWeatherInfo2";
            this.panelWeatherInfo2.Size = new System.Drawing.Size(584, 83);
            this.panelWeatherInfo2.TabIndex = 1;
            // 
            // comboBoxCity2
            // 
            this.comboBoxCity2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCity2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCity2.FormattingEnabled = true;
            this.comboBoxCity2.Location = new System.Drawing.Point(103, 12);
            this.comboBoxCity2.Name = "comboBoxCity2";
            this.comboBoxCity2.Size = new System.Drawing.Size(186, 33);
            this.comboBoxCity2.TabIndex = 7;
            this.comboBoxCity2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity2_SelectedIndexChanged);
            // 
            // labTemperature2
            // 
            this.labTemperature2.AutoSize = true;
            this.labTemperature2.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTemperature2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labTemperature2.Location = new System.Drawing.Point(524, 0);
            this.labTemperature2.Name = "labTemperature2";
            this.labTemperature2.Size = new System.Drawing.Size(60, 31);
            this.labTemperature2.TabIndex = 6;
            this.labTemperature2.Text = "N/A";
            this.labTemperature2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIcon2
            // 
            this.btnIcon2.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIcon2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon2.FlatAppearance.BorderSize = 0;
            this.btnIcon2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIcon2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIcon2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon2.ImageKey = "sunny_icon.png";
            this.btnIcon2.ImageList = this.imageList1;
            this.btnIcon2.Location = new System.Drawing.Point(0, 0);
            this.btnIcon2.Name = "btnIcon2";
            this.btnIcon2.Size = new System.Drawing.Size(97, 83);
            this.btnIcon2.TabIndex = 5;
            this.btnIcon2.Text = "N/A";
            this.btnIcon2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcon2.UseVisualStyleBackColor = false;
            // 
            // panelWeatherInfo3
            // 
            this.panelWeatherInfo3.BackColor = System.Drawing.Color.Silver;
            this.panelWeatherInfo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWeatherInfo3.Controls.Add(this.comboBoxCity3);
            this.panelWeatherInfo3.Controls.Add(this.labTemperature3);
            this.panelWeatherInfo3.Controls.Add(this.btnIcon3);
            this.panelWeatherInfo3.Location = new System.Drawing.Point(104, 285);
            this.panelWeatherInfo3.Name = "panelWeatherInfo3";
            this.panelWeatherInfo3.Size = new System.Drawing.Size(584, 83);
            this.panelWeatherInfo3.TabIndex = 8;
            // 
            // comboBoxCity3
            // 
            this.comboBoxCity3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCity3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCity3.FormattingEnabled = true;
            this.comboBoxCity3.Location = new System.Drawing.Point(103, 12);
            this.comboBoxCity3.Name = "comboBoxCity3";
            this.comboBoxCity3.Size = new System.Drawing.Size(186, 33);
            this.comboBoxCity3.TabIndex = 7;
            this.comboBoxCity3.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity3_SelectedIndexChanged);
            // 
            // labTemperature3
            // 
            this.labTemperature3.AutoSize = true;
            this.labTemperature3.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature3.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTemperature3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labTemperature3.Location = new System.Drawing.Point(524, 0);
            this.labTemperature3.Name = "labTemperature3";
            this.labTemperature3.Size = new System.Drawing.Size(60, 31);
            this.labTemperature3.TabIndex = 6;
            this.labTemperature3.Text = "N/A";
            this.labTemperature3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIcon3
            // 
            this.btnIcon3.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIcon3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon3.FlatAppearance.BorderSize = 0;
            this.btnIcon3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIcon3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIcon3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon3.ImageKey = "sunny_icon.png";
            this.btnIcon3.ImageList = this.imageList1;
            this.btnIcon3.Location = new System.Drawing.Point(0, 0);
            this.btnIcon3.Name = "btnIcon3";
            this.btnIcon3.Size = new System.Drawing.Size(97, 83);
            this.btnIcon3.TabIndex = 5;
            this.btnIcon3.Text = "N/A";
            this.btnIcon3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcon3.UseVisualStyleBackColor = false;
            // 
            // panelWeatherInfo4
            // 
            this.panelWeatherInfo4.BackColor = System.Drawing.Color.Silver;
            this.panelWeatherInfo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWeatherInfo4.Controls.Add(this.comboBoxCity4);
            this.panelWeatherInfo4.Controls.Add(this.labTemperature4);
            this.panelWeatherInfo4.Controls.Add(this.btnIcon4);
            this.panelWeatherInfo4.Location = new System.Drawing.Point(104, 385);
            this.panelWeatherInfo4.Name = "panelWeatherInfo4";
            this.panelWeatherInfo4.Size = new System.Drawing.Size(584, 83);
            this.panelWeatherInfo4.TabIndex = 8;
            // 
            // comboBoxCity4
            // 
            this.comboBoxCity4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCity4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCity4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCity4.FormattingEnabled = true;
            this.comboBoxCity4.Location = new System.Drawing.Point(103, 12);
            this.comboBoxCity4.Name = "comboBoxCity4";
            this.comboBoxCity4.Size = new System.Drawing.Size(186, 33);
            this.comboBoxCity4.TabIndex = 7;
            this.comboBoxCity4.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity4_SelectedIndexChanged);
            // 
            // labTemperature4
            // 
            this.labTemperature4.AutoSize = true;
            this.labTemperature4.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature4.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTemperature4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labTemperature4.Location = new System.Drawing.Point(524, 0);
            this.labTemperature4.Name = "labTemperature4";
            this.labTemperature4.Size = new System.Drawing.Size(60, 31);
            this.labTemperature4.TabIndex = 6;
            this.labTemperature4.Text = "N/A";
            this.labTemperature4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIcon4
            // 
            this.btnIcon4.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIcon4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon4.FlatAppearance.BorderSize = 0;
            this.btnIcon4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIcon4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIcon4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon4.ImageKey = "sunny_icon.png";
            this.btnIcon4.ImageList = this.imageList1;
            this.btnIcon4.Location = new System.Drawing.Point(0, 0);
            this.btnIcon4.Name = "btnIcon4";
            this.btnIcon4.Size = new System.Drawing.Size(97, 83);
            this.btnIcon4.TabIndex = 5;
            this.btnIcon4.Text = "N/A";
            this.btnIcon4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcon4.UseVisualStyleBackColor = false;
            // 
            // panelWeatherInfo5
            // 
            this.panelWeatherInfo5.BackColor = System.Drawing.Color.Silver;
            this.panelWeatherInfo5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWeatherInfo5.Controls.Add(this.comboBoxCity5);
            this.panelWeatherInfo5.Controls.Add(this.labTemperature5);
            this.panelWeatherInfo5.Controls.Add(this.btnIcon5);
            this.panelWeatherInfo5.Location = new System.Drawing.Point(104, 496);
            this.panelWeatherInfo5.Name = "panelWeatherInfo5";
            this.panelWeatherInfo5.Size = new System.Drawing.Size(584, 83);
            this.panelWeatherInfo5.TabIndex = 8;
            // 
            // comboBoxCity5
            // 
            this.comboBoxCity5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCity5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCity5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCity5.FormattingEnabled = true;
            this.comboBoxCity5.Location = new System.Drawing.Point(103, 12);
            this.comboBoxCity5.Name = "comboBoxCity5";
            this.comboBoxCity5.Size = new System.Drawing.Size(186, 33);
            this.comboBoxCity5.TabIndex = 7;
            this.comboBoxCity5.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity5_SelectedIndexChanged);
            // 
            // labTemperature5
            // 
            this.labTemperature5.AutoSize = true;
            this.labTemperature5.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature5.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTemperature5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemperature5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labTemperature5.Location = new System.Drawing.Point(524, 0);
            this.labTemperature5.Name = "labTemperature5";
            this.labTemperature5.Size = new System.Drawing.Size(60, 31);
            this.labTemperature5.TabIndex = 6;
            this.labTemperature5.Text = "N/A";
            this.labTemperature5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIcon5
            // 
            this.btnIcon5.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIcon5.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon5.FlatAppearance.BorderSize = 0;
            this.btnIcon5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIcon5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIcon5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon5.ImageKey = "sunny_icon.png";
            this.btnIcon5.ImageList = this.imageList1;
            this.btnIcon5.Location = new System.Drawing.Point(0, 0);
            this.btnIcon5.Name = "btnIcon5";
            this.btnIcon5.Size = new System.Drawing.Size(97, 83);
            this.btnIcon5.TabIndex = 5;
            this.btnIcon5.Text = "N/A";
            this.btnIcon5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcon5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Weather_app.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.panelWeatherInfo5);
            this.Controls.Add(this.panelWeatherInfo4);
            this.Controls.Add(this.panelWeatherInfo3);
            this.Controls.Add(this.panelWeatherInfo2);
            this.Controls.Add(this.panelWeatherInfo1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Weather app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWeatherInfo1.ResumeLayout(false);
            this.panelWeatherInfo1.PerformLayout();
            this.panelWeatherInfo2.ResumeLayout(false);
            this.panelWeatherInfo2.PerformLayout();
            this.panelWeatherInfo3.ResumeLayout(false);
            this.panelWeatherInfo3.PerformLayout();
            this.panelWeatherInfo4.ResumeLayout(false);
            this.panelWeatherInfo4.PerformLayout();
            this.panelWeatherInfo5.ResumeLayout(false);
            this.panelWeatherInfo5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWeatherInfo1;
        private System.Windows.Forms.Button btnIcon1;
        private System.Windows.Forms.Label labTemperature1;
        private System.Windows.Forms.ComboBox comboBoxCity1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelWeatherInfo2;
        private System.Windows.Forms.ComboBox comboBoxCity2;
        private System.Windows.Forms.Label labTemperature2;
        private System.Windows.Forms.Button btnIcon2;
        private System.Windows.Forms.Panel panelWeatherInfo3;
        private System.Windows.Forms.ComboBox comboBoxCity3;
        private System.Windows.Forms.Label labTemperature3;
        private System.Windows.Forms.Button btnIcon3;
        private System.Windows.Forms.Panel panelWeatherInfo4;
        private System.Windows.Forms.ComboBox comboBoxCity4;
        private System.Windows.Forms.Label labTemperature4;
        private System.Windows.Forms.Button btnIcon4;
        private System.Windows.Forms.Panel panelWeatherInfo5;
        private System.Windows.Forms.ComboBox comboBoxCity5;
        private System.Windows.Forms.Label labTemperature5;
        private System.Windows.Forms.Button btnIcon5;
    }
}

