using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace codeAPP.Models
{
    public class usuario
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100)]
        public string nombre { get; set; }
        [MaxLength(100)]
        public string correo { get; set;}
        [MaxLength(100)]
        public string password { get; set;}
    }
}
