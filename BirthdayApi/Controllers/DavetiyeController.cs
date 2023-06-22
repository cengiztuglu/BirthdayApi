using Birthdayy.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;

namespace Birthdayy.Controllers
{
    public class DavetiyeController : ApiController
    {
        
        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
        }

        public void PostEkle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {

                Veritabani.Add(model);


            }
        }
    }
}
