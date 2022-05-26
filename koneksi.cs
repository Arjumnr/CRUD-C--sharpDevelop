
using MySql.Data.MySqlClient;

namespace CRUD
{

	public class koneksi
	{
		
			public MySqlConnection conn = new MySqlConnection("server=localhost; database=db_mahasiswa_sharp; uid=root; pwd=; CharSet=utf8;");
			
			public void buka(){
				conn.Open();
			}
			
			public void tutup(){
				conn.Close();
			}
			
			
		
	}
	
	
	
	
}
