/*
 * Created by SharpDevelop.
 * User: 24ind
 * Date: 19/05/2022
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CRUD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_jurusan = new System.Windows.Forms.ComboBox();
			this.text_stb = new System.Windows.Forms.TextBox();
			this.text_nama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_tes_koneksi = new System.Windows.Forms.Button();
			this.btn_tambah = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_hapus = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(406, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 72);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data Mahasiswa";
			// 
			// cbx_jurusan
			// 
			this.cbx_jurusan.FormattingEnabled = true;
			this.cbx_jurusan.Items.AddRange(new object[] {
									"Teknik Informatika",
									"Sistem Informasi"});
			this.cbx_jurusan.Location = new System.Drawing.Point(406, 188);
			this.cbx_jurusan.Name = "cbx_jurusan";
			this.cbx_jurusan.Size = new System.Drawing.Size(152, 24);
			this.cbx_jurusan.TabIndex = 1;
			// 
			// text_stb
			// 
			this.text_stb.Location = new System.Drawing.Point(38, 188);
			this.text_stb.Name = "text_stb";
			this.text_stb.Size = new System.Drawing.Size(100, 22);
			this.text_stb.TabIndex = 2;
			// 
			// text_nama
			// 
			this.text_nama.Location = new System.Drawing.Point(176, 188);
			this.text_nama.Name = "text_nama";
			this.text_nama.Size = new System.Drawing.Size(198, 22);
			this.text_nama.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "STB";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(406, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Jurusan";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nama";
			// 
			// btn_tes_koneksi
			// 
			this.btn_tes_koneksi.Location = new System.Drawing.Point(38, 272);
			this.btn_tes_koneksi.Name = "btn_tes_koneksi";
			this.btn_tes_koneksi.Size = new System.Drawing.Size(115, 58);
			this.btn_tes_koneksi.TabIndex = 7;
			this.btn_tes_koneksi.Text = "Tes Koneksi";
			this.btn_tes_koneksi.UseVisualStyleBackColor = true;
			this.btn_tes_koneksi.Click += new System.EventHandler(this.Btn_tes_koneksiClick);
			// 
			// btn_tambah
			// 
			this.btn_tambah.Location = new System.Drawing.Point(217, 272);
			this.btn_tambah.Name = "btn_tambah";
			this.btn_tambah.Size = new System.Drawing.Size(87, 58);
			this.btn_tambah.TabIndex = 8;
			this.btn_tambah.Text = "Tambah";
			this.btn_tambah.UseVisualStyleBackColor = true;
			this.btn_tambah.Click += new System.EventHandler(this.Btn_tambahClick);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(349, 272);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(87, 58);
			this.btn_edit.TabIndex = 9;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.Btn_editClick);
			// 
			// btn_hapus
			// 
			this.btn_hapus.Location = new System.Drawing.Point(483, 272);
			this.btn_hapus.Name = "btn_hapus";
			this.btn_hapus.Size = new System.Drawing.Size(87, 58);
			this.btn_hapus.TabIndex = 10;
			this.btn_hapus.Text = "Hapus";
			this.btn_hapus.UseVisualStyleBackColor = true;
			this.btn_hapus.Click += new System.EventHandler(this.Btn_hapusClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Location = new System.Drawing.Point(614, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(558, 363);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1197, 569);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_hapus);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_tambah);
			this.Controls.Add(this.btn_tes_koneksi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.text_nama);
			this.Controls.Add(this.text_stb);
			this.Controls.Add(this.cbx_jurusan);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CRUD";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_hapus;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_tambah;
		private System.Windows.Forms.Button btn_tes_koneksi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_nama;
		private System.Windows.Forms.TextBox text_stb;
		private System.Windows.Forms.ComboBox cbx_jurusan;
		private System.Windows.Forms.Label label1;
	}
}
