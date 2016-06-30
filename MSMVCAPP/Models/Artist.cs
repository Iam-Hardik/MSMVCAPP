using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSMVCAPP.Models
{
    public class Artist
    {

        public int ArtistID { get; set; }
        public String Name { get; set; }
        public virtual List<Album> Albums  { get; set; }
    }
}