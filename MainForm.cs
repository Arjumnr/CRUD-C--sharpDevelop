/*
 * Created by SharpDevelop.
 * User: 24ind
 * Date: 19/05/2022
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRUD
{
	
	public partial class MainForm : Form
	{
		koneksi conn = new koneksi();
		MySqlCommand cmd;
		string sql;
		
		public MainForm()
		{
			InitializeComponent();
			ShowData();
			
		}
				
		void Btn_tes_koneksiClick(object sender, EventArgs e)
		{
			try{
				conn.buka();
				MessageBox.Show("Koneksi Berhasil");
			} catch (Exception ex){
				
				MessageBox.Show("Koneksi Gagal" + ex.Message);
			}
			conn.tutup();
		}
		
		private void ShowData(){
				viewData view = new viewData();
				dataGridView1.DataSource = view.viewMahasiswa();
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].HeaderText = "STAMBUK";
				dataGridView1.Columns[2].HeaderText = "NAMA";
				dataGridView1.Columns[3].HeaderText = "JURUSAN";
		}
		
		void proses (string sql, string pesan){
			try {
				conn.buka();
				cmd = new MySqlCommand(sql, conn.conn);
				cmd.Parameters.AddWithValue("@stb", text_stb.Text);
				cmd.Parameters.AddWithValue("@nama", text_nama.Text);
				cmd.Parameters.AddWithValue("@jurusan", cbx_jurusan.SelectedItem.ToString());
				cmd.Prepare();
				cmd.ExecuteNonQuery();
				MessageBox.Show(pesan);
				reset();
			} catch (Exception xx) {
				MessageBox.Show(xx.Message);
				throw;
			}
			conn.tutup();
		}
		
		void Btn_tambahClick(object sender, EventArgs e)
		{
			sql = "INSERT INTO tb_mhs(stb, nama, jurusan) VALUES (@stb, @nama, @jurusan)";
			proses(sql, "Berhasil Tambah Data");
			ShowData();
			
		}
		
		void Btn_editClick(object sender, EventArgs e)
		{
			sql = "UPDATE tb_mhs SET stb=@stb, nama=@nama, jurusan=@jurusan WHERE stb=@stb";
			proses(sql, "Berhasil Edit Data");
			ShowData();
		}
		
		void Btn_hapusClick(object sender, EventArgs e)
		{
			sql = "DELETE FROM tb_mhs WHERE stb=@stb";
			proses(sql, "Berhasil Hapus Data");
			ShowData();
			
		}
		
		void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			text_stb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			text_nama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			cbx_jurusan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void reset(){
			text_stb.Clear();
			text_nama.Clear();
			cbx_jurusan.Text = " ";
		}
	}
}
