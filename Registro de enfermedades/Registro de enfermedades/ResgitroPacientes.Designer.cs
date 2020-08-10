namespace Registro_de_enfermedades
{
    partial class RegistroPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPacientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEstadisticas = new System.Windows.Forms.RadioButton();
            this.rbtnConfirmada = new System.Windows.Forms.RadioButton();
            this.rbtnSospecha = new System.Windows.Forms.RadioButton();
            this.ListEnf = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn50a59 = new System.Windows.Forms.RadioButton();
            this.rbtn60ymas = new System.Windows.Forms.RadioButton();
            this.rbtn10a19 = new System.Windows.Forms.RadioButton();
            this.rbtn5a9 = new System.Windows.Forms.RadioButton();
            this.rtbn30a39 = new System.Windows.Forms.RadioButton();
            this.rbtn40a49 = new System.Windows.Forms.RadioButton();
            this.rbtn1a4 = new System.Windows.Forms.RadioButton();
            this.rbtn1año = new System.Windows.Forms.RadioButton();
            this.rbtn20a29 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.viewEnfermedadFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnfermedadFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEstadisticas);
            this.groupBox1.Controls.Add(this.rbtnConfirmada);
            this.groupBox1.Controls.Add(this.rbtnSospecha);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(147, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clasificacion";
            // 
            // rbtnEstadisticas
            // 
            this.rbtnEstadisticas.AutoSize = true;
            this.rbtnEstadisticas.Location = new System.Drawing.Point(12, 72);
            this.rbtnEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnEstadisticas.Name = "rbtnEstadisticas";
            this.rbtnEstadisticas.Size = new System.Drawing.Size(132, 18);
            this.rbtnEstadisticas.TabIndex = 2;
            this.rbtnEstadisticas.TabStop = true;
            this.rbtnEstadisticas.Text = "Estadisticas Vitales";
            this.rbtnEstadisticas.UseVisualStyleBackColor = true;
            this.rbtnEstadisticas.CheckedChanged += new System.EventHandler(this.rbtnEstadisticas_CheckedChanged);
            // 
            // rbtnConfirmada
            // 
            this.rbtnConfirmada.AutoSize = true;
            this.rbtnConfirmada.Location = new System.Drawing.Point(13, 46);
            this.rbtnConfirmada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnConfirmada.Name = "rbtnConfirmada";
            this.rbtnConfirmada.Size = new System.Drawing.Size(86, 18);
            this.rbtnConfirmada.TabIndex = 1;
            this.rbtnConfirmada.TabStop = true;
            this.rbtnConfirmada.Text = "Confirmada";
            this.rbtnConfirmada.UseVisualStyleBackColor = true;
            this.rbtnConfirmada.CheckedChanged += new System.EventHandler(this.rbtnConfirmada_CheckedChanged);
            // 
            // rbtnSospecha
            // 
            this.rbtnSospecha.AutoSize = true;
            this.rbtnSospecha.Location = new System.Drawing.Point(13, 24);
            this.rbtnSospecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSospecha.Name = "rbtnSospecha";
            this.rbtnSospecha.Size = new System.Drawing.Size(77, 18);
            this.rbtnSospecha.TabIndex = 0;
            this.rbtnSospecha.TabStop = true;
            this.rbtnSospecha.Text = "Sospecha";
            this.rbtnSospecha.UseVisualStyleBackColor = true;
            this.rbtnSospecha.CheckedChanged += new System.EventHandler(this.rbtnSospecha_CheckedChanged);
            // 
            // ListEnf
            // 
            this.ListEnf.FormattingEnabled = true;
            this.ListEnf.Location = new System.Drawing.Point(23, 192);
            this.ListEnf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListEnf.Name = "ListEnf";
            this.ListEnf.Size = new System.Drawing.Size(203, 69);
            this.ListEnf.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn50a59);
            this.groupBox2.Controls.Add(this.rbtn60ymas);
            this.groupBox2.Controls.Add(this.rbtn10a19);
            this.groupBox2.Controls.Add(this.rbtn5a9);
            this.groupBox2.Controls.Add(this.rtbn30a39);
            this.groupBox2.Controls.Add(this.rbtn40a49);
            this.groupBox2.Controls.Add(this.rbtn1a4);
            this.groupBox2.Controls.Add(this.rbtn1año);
            this.groupBox2.Controls.Add(this.rbtn20a29);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(249, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(193, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edad";
            // 
            // rbtn50a59
            // 
            this.rbtn50a59.AutoSize = true;
            this.rbtn50a59.Location = new System.Drawing.Point(93, 132);
            this.rbtn50a59.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn50a59.Name = "rbtn50a59";
            this.rbtn50a59.Size = new System.Drawing.Size(92, 18);
            this.rbtn50a59.TabIndex = 6;
            this.rbtn50a59.TabStop = true;
            this.rbtn50a59.Text = "50 a 59 años";
            this.rbtn50a59.UseVisualStyleBackColor = true;
            this.rbtn50a59.CheckedChanged += new System.EventHandler(this.rbtn50a59_CheckedChanged);
            // 
            // rbtn60ymas
            // 
            this.rbtn60ymas.AutoSize = true;
            this.rbtn60ymas.Location = new System.Drawing.Point(40, 168);
            this.rbtn60ymas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn60ymas.Name = "rbtn60ymas";
            this.rbtn60ymas.Size = new System.Drawing.Size(101, 18);
            this.rbtn60ymas.TabIndex = 7;
            this.rbtn60ymas.TabStop = true;
            this.rbtn60ymas.Text = "60 y más años";
            this.rbtn60ymas.UseVisualStyleBackColor = true;
            this.rbtn60ymas.CheckedChanged += new System.EventHandler(this.rbtn60ymas_CheckedChanged);
            // 
            // rbtn10a19
            // 
            this.rbtn10a19.AutoSize = true;
            this.rbtn10a19.Location = new System.Drawing.Point(93, 58);
            this.rbtn10a19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn10a19.Name = "rbtn10a19";
            this.rbtn10a19.Size = new System.Drawing.Size(92, 18);
            this.rbtn10a19.TabIndex = 3;
            this.rbtn10a19.TabStop = true;
            this.rbtn10a19.Text = "10 a 19 años";
            this.rbtn10a19.UseVisualStyleBackColor = true;
            this.rbtn10a19.CheckedChanged += new System.EventHandler(this.rbtn10a19_CheckedChanged);
            // 
            // rbtn5a9
            // 
            this.rbtn5a9.AutoSize = true;
            this.rbtn5a9.Location = new System.Drawing.Point(4, 58);
            this.rbtn5a9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn5a9.Name = "rbtn5a9";
            this.rbtn5a9.Size = new System.Drawing.Size(80, 18);
            this.rbtn5a9.TabIndex = 2;
            this.rbtn5a9.TabStop = true;
            this.rbtn5a9.Text = "5 a 9 años";
            this.rbtn5a9.UseVisualStyleBackColor = true;
            this.rbtn5a9.CheckedChanged += new System.EventHandler(this.rbtn5a9_CheckedChanged);
            // 
            // rtbn30a39
            // 
            this.rtbn30a39.AutoSize = true;
            this.rtbn30a39.Location = new System.Drawing.Point(93, 93);
            this.rtbn30a39.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbn30a39.Name = "rtbn30a39";
            this.rtbn30a39.Size = new System.Drawing.Size(92, 18);
            this.rtbn30a39.TabIndex = 4;
            this.rtbn30a39.TabStop = true;
            this.rtbn30a39.Text = "30 a 39 años";
            this.rtbn30a39.UseVisualStyleBackColor = true;
            this.rtbn30a39.CheckedChanged += new System.EventHandler(this.rtbn30a39_CheckedChanged);
            // 
            // rbtn40a49
            // 
            this.rbtn40a49.AutoSize = true;
            this.rbtn40a49.Location = new System.Drawing.Point(3, 132);
            this.rbtn40a49.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn40a49.Name = "rbtn40a49";
            this.rbtn40a49.Size = new System.Drawing.Size(92, 18);
            this.rbtn40a49.TabIndex = 5;
            this.rbtn40a49.TabStop = true;
            this.rbtn40a49.Text = "40 a 49 años";
            this.rbtn40a49.UseVisualStyleBackColor = true;
            this.rbtn40a49.CheckedChanged += new System.EventHandler(this.rbtn40a49_CheckedChanged);
            // 
            // rbtn1a4
            // 
            this.rbtn1a4.AutoSize = true;
            this.rbtn1a4.Location = new System.Drawing.Point(93, 24);
            this.rbtn1a4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn1a4.Name = "rbtn1a4";
            this.rbtn1a4.Size = new System.Drawing.Size(80, 18);
            this.rbtn1a4.TabIndex = 1;
            this.rbtn1a4.TabStop = true;
            this.rbtn1a4.Text = "1 a 4 años";
            this.rbtn1a4.UseVisualStyleBackColor = true;
            this.rbtn1a4.CheckedChanged += new System.EventHandler(this.rbtn1a4_CheckedChanged);
            // 
            // rbtn1año
            // 
            this.rbtn1año.AutoSize = true;
            this.rbtn1año.Location = new System.Drawing.Point(4, 24);
            this.rbtn1año.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn1año.Name = "rbtn1año";
            this.rbtn1año.Size = new System.Drawing.Size(61, 18);
            this.rbtn1año.TabIndex = 0;
            this.rbtn1año.TabStop = true;
            this.rbtn1año.Text = "<1 año";
            this.rbtn1año.UseVisualStyleBackColor = true;
            this.rbtn1año.CheckedChanged += new System.EventHandler(this.rbtn1año_CheckedChanged);
            // 
            // rbtn20a29
            // 
            this.rbtn20a29.AutoSize = true;
            this.rbtn20a29.Location = new System.Drawing.Point(4, 93);
            this.rbtn20a29.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn20a29.Name = "rbtn20a29";
            this.rbtn20a29.Size = new System.Drawing.Size(92, 18);
            this.rbtn20a29.TabIndex = 3;
            this.rbtn20a29.TabStop = true;
            this.rbtn20a29.Text = "20 a 29 años";
            this.rbtn20a29.UseVisualStyleBackColor = true;
            this.rbtn20a29.CheckedChanged += new System.EventHandler(this.rbtn20a29_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnF);
            this.groupBox3.Controls.Add(this.rbtnM);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(172, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(73, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.rbtnF.Location = new System.Drawing.Point(18, 58);
            this.rbtnF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(36, 27);
            this.rbtnF.TabIndex = 1;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            this.rbtnF.CheckedChanged += new System.EventHandler(this.rbtnF_CheckedChanged);
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.rbtnM.Location = new System.Drawing.Point(18, 24);
            this.rbtnM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(40, 27);
            this.rbtnM.TabIndex = 0;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            this.rbtnM.CheckedChanged += new System.EventHandler(this.rbtnM_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.label1.Location = new System.Drawing.Point(18, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enfermedad o Evento:";
            // 
            // btnvolver
            // 
            this.btnvolver.BackgroundImage = global::Registro_de_enfermedades.Properties.Resources.icons8_izquierda_64;
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Location = new System.Drawing.Point(21, 11);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(59, 45);
            this.btnvolver.TabIndex = 7;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.viewEnfermedadFechaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(446, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 199);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Registro_de_enfermedades.Properties.Resources.icons8_editar_64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(579, 288);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 42);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Registro_de_enfermedades.Properties.Resources.icons8_eliminar_64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(435, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 48);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewEnfermedadFechaBindingSource
            // 
            this.viewEnfermedadFechaBindingSource.DataMember = "ViewEnfermedadFecha";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Registro_de_enfermedades.Properties.Resources.icons8_comprobado_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(312, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 48);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(796, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ListEnf);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPacientes";
            this.Load += new System.EventHandler(this.RegistroPacientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnfermedadFechaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnConfirmada;
        private System.Windows.Forms.RadioButton rbtnSospecha;
        private System.Windows.Forms.ListBox ListEnf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn50a59;
        private System.Windows.Forms.RadioButton rbtn60ymas;
        private System.Windows.Forms.RadioButton rbtn10a19;
        private System.Windows.Forms.RadioButton rbtn5a9;
        private System.Windows.Forms.RadioButton rtbn30a39;
        private System.Windows.Forms.RadioButton rbtn40a49;
        private System.Windows.Forms.RadioButton rbtn1a4;
        private System.Windows.Forms.RadioButton rbtn1año;
        private System.Windows.Forms.RadioButton rbtn20a29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnfermedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
     //   private EnfermedadesFecha enfermedadesFecha;
        private System.Windows.Forms.BindingSource viewEnfermedadFechaBindingSource;
       // private EnfermedadesFechaTableAdapters.ViewEnfermedadFechaTableAdapter viewEnfermedadFechaTableAdapter;
    }
}