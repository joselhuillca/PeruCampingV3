//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLearningDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class lo_comment_with_username
    {
        public int id { get; set; }
        public int lo_id { get; set; }
        public int user_id { get; set; }
        public string text { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string image_url { get; set; }
    }
}