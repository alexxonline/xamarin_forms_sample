using System;
using SQLite;

namespace exelxior
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
