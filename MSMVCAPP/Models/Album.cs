using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MSMVCAPP.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
    }
}