//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Cirrious.MvvmCross.Community.Plugins.Sqlite;

namespace MLearningDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOsection
    {

		[PrimaryKey, AutoIncrement]
		public int id_pk { get; set;}
        public int id { get; set; }
        public string name { get; set; }
        public int LO_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    

    }
}