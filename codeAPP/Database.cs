using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

// librerias de sqlite

namespace codeAPP
{
    public interface Database
    {

        SQLiteAsyncConnection GetConnection();

    }
}
