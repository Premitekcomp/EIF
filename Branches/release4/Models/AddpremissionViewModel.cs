using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EIF.Models
{
    public class AddpremissionViewModel
    {
        public SelectList Domaintypes { get; set; }
        public SelectList Domaindatausers { get; set; }
        public SelectList portalaccess { get; set; }
        public SelectList Domaindatagroups { get; set; }
        public List<permission> permissionslst { get; set; }
    }
    public class permission
    {
        public int permissionid { get; set; }
        public int? DomaintypeId { get; set; }
        public int? DomaindataId { get; set; }
        public string portalaccessIds { get; set; }
    }
    public class _UserDataScope
    {
        public int? BankId { get; set; }
        public List<int?> TypeIds { get; set; }
        public List<int?> ProductIds { get; set; }
        public List<string> Regions { get; set; }
    }
}