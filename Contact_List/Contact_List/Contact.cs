using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Contact_List
{
    [Table("Contacts")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
    }
}
