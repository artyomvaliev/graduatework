
namespace graduatework.Forms
{
    partial class MainObject
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
            this.comboBox47 = new System.Windows.Forms.ComboBox();
            this.пОценкеПодлежитBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graduatedbDataSet = new graduatework.graduatedbDataSet();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.comboBox46 = new System.Windows.Forms.ComboBox();
            this.пТипПомещенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label79 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.пТипПомещенияTableAdapter = new graduatework.graduatedbDataSetTableAdapters.ПТипПомещенияTableAdapter();
            this.пОценкеПодлежитTableAdapter = new graduatework.graduatedbDataSetTableAdapters.ПОценкеПодлежитTableAdapter();
            this.queriesTableAdapter1 = new graduatework.graduatedbDataSetTableAdapters.QueriesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.пОценкеПодлежитBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduatedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТипПомещенияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox47
            // 
            this.comboBox47.DataSource = this.пОценкеПодлежитBindingSource;
            this.comboBox47.DisplayMember = "Оценке подлежит";
            this.comboBox47.FormattingEnabled = true;
            this.comboBox47.Location = new System.Drawing.Point(180, 541);
            this.comboBox47.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox47.Name = "comboBox47";
            this.comboBox47.Size = new System.Drawing.Size(336, 29);
            this.comboBox47.TabIndex = 62;
            this.comboBox47.ValueMember = "Код";
            this.comboBox47.SelectedIndexChanged += new System.EventHandler(this.comboBox47_SelectedIndexChanged);
            // 
            // пОценкеПодлежитBindingSource
            // 
            this.пОценкеПодлежитBindingSource.DataMember = "ПОценкеПодлежит";
            this.пОценкеПодлежитBindingSource.DataSource = this.graduatedbDataSet;
            // 
            // graduatedbDataSet
            // 
            this.graduatedbDataSet.DataSetName = "graduatedbDataSet";
            this.graduatedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(21, 544);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(151, 21);
            this.label83.TabIndex = 61;
            this.label83.Text = "Оценке подлежит";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(294, 613);
            this.textBox33.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(336, 27);
            this.textBox33.TabIndex = 59;
            this.textBox33.TextChanged += new System.EventHandler(this.textBox33_TextChanged);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(53)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(53)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 0;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(638, 609);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(228, 36);
            this.rjButton4.TabIndex = 60;
            this.rjButton4.Text = "Добавить выписку";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(21, 616);
            this.label82.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(265, 21);
            this.label82.TabIndex = 58;
            this.label82.Text = "Кадастровый(условный)  номер";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(220, 467);
            this.textBox32.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(336, 27);
            this.textBox32.TabIndex = 57;
            this.textBox32.TextChanged += new System.EventHandler(this.textBox32_TextChanged);
            this.textBox32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CharOnlyAnd);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(21, 470);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(191, 21);
            this.label81.TabIndex = 56;
            this.label81.Text = "Общая площадь, кв.м.";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(243, 393);
            this.textBox31.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(336, 27);
            this.textBox31.TabIndex = 55;
            this.textBox31.TextChanged += new System.EventHandler(this.textBox31_TextChanged);
            this.textBox31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CharOnly);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(21, 396);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(214, 21);
            this.label80.TabIndex = 54;
            this.label80.Text = "Количество жилых комнат";
            // 
            // comboBox46
            // 
            this.comboBox46.DataSource = this.пТипПомещенияBindingSource;
            this.comboBox46.DisplayMember = "Тип помещения";
            this.comboBox46.FormattingEnabled = true;
            this.comboBox46.Location = new System.Drawing.Point(168, 319);
            this.comboBox46.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox46.Name = "comboBox46";
            this.comboBox46.Size = new System.Drawing.Size(336, 29);
            this.comboBox46.TabIndex = 53;
            this.comboBox46.ValueMember = "Код";
            this.comboBox46.SelectedIndexChanged += new System.EventHandler(this.comboBox46_SelectedIndexChanged);
            // 
            // пТипПомещенияBindingSource
            // 
            this.пТипПомещенияBindingSource.DataMember = "ПТипПомещения";
            this.пТипПомещенияBindingSource.DataSource = this.graduatedbDataSet;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(21, 322);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(139, 21);
            this.label79.TabIndex = 52;
            this.label79.Text = "Тип помещения";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(89, 245);
            this.textBox30.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(336, 27);
            this.textBox30.TabIndex = 51;
            this.textBox30.TextChanged += new System.EventHandler(this.textBox30_TextChanged);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(21, 248);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(60, 21);
            this.label78.TabIndex = 50;
            this.label78.Text = "Улица";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(130, 23);
            this.textBox29.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(336, 27);
            this.textBox29.TabIndex = 49;
            this.textBox29.TextChanged += new System.EventHandler(this.textBox29_TextChanged);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(251, 171);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(336, 27);
            this.textBox27.TabIndex = 48;
            this.textBox27.TextChanged += new System.EventHandler(this.textBox27_TextChanged);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(187, 97);
            this.textBox28.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(336, 27);
            this.textBox28.TabIndex = 47;
            this.textBox28.TextChanged += new System.EventHandler(this.textBox28_TextChanged);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(21, 174);
            this.label76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(224, 21);
            this.label76.TabIndex = 46;
            this.label76.Text = "Административный район";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(21, 100);
            this.label77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(158, 21);
            this.label77.TabIndex = 45;
            this.label77.Text = "Населенный пункт";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(21, 26);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(101, 21);
            this.label75.TabIndex = 44;
            this.label75.Text = "Субъект РФ";
            // 
            // пТипПомещенияTableAdapter
            // 
            this.пТипПомещенияTableAdapter.ClearBeforeFill = true;
            // 
            // пОценкеПодлежитTableAdapter
            // 
            this.пОценкеПодлежитTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 23);
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.comboBox47);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.comboBox46);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label75);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainObject";
            this.Text = "MainObject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainObject_FormClosing);
            this.Load += new System.EventHandler(this.MainObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пОценкеПодлежитBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduatedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТипПомещенияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox47;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox textBox33;
        private CustomControls.RJControls.RJButton rjButton4;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.ComboBox comboBox46;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label75;
        private graduatedbDataSet graduatedbDataSet;
        private System.Windows.Forms.BindingSource пТипПомещенияBindingSource;
        private graduatedbDataSetTableAdapters.ПТипПомещенияTableAdapter пТипПомещенияTableAdapter;
        private System.Windows.Forms.BindingSource пОценкеПодлежитBindingSource;
        private graduatedbDataSetTableAdapters.ПОценкеПодлежитTableAdapter пОценкеПодлежитTableAdapter;
        private graduatedbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}