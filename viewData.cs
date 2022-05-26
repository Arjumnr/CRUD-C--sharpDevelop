
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
	
	public class viewData
	{
		koneksi connect = new koneksi();
		MySqlDataAdapter adp;
		DataTable dataTable;
		string sql;
		
		private void proses (string sql){
			
			 dataTable = new DataTable();
			try{
				connect.buka();
//				cmd = new MySqlCommand(sql, connect.conn);
				adp = new MySqlDataAdapter(sql, connect.conn);
//				cmd.ExecuteNonQuery();
				adp.Fill(dataTable);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
			connect.tutup();
		}
		
		public DataTable viewMahasiswa(){
		
				sql = "select * from tb_mhs";
				proses(sql);
				
				return dataTable;
			
		}
	}
}
