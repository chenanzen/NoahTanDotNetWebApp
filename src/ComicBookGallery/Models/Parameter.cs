using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ComicBookGallery.Models
{
    public class Parameter
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }

        public static int TimeFrameToCancelReturn
        {
            get
            {
                string keyname = "TimeFrameToCancelReturn";
                Parameter param = GetValue(keyname);
                return Convert.ToInt32(param.Value);
            }
        }

        private static Parameter GetValue(string keyName)
        {
            Parameter value = new Parameter();
            using (var db = new ApplicationDbContext())
            {
                var query = from p in db.Parameter
                            where p.Key == keyName
                            select p;

                value = query.SingleOrDefault();
                db.Dispose();
            }
            return value;
        }
    }
}