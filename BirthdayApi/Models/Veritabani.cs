using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Birthdayy.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _Liste;
        static Veritabani()
        {
            _Liste = new Dictionary<string, DavetiyeModel>();
            _Liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true


            });
            _Liste.Add("Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Eposta = "mehmet@gmail.com",
                KatilmaDurumu = false


            });
            _Liste.Add("Berin", new DavetiyeModel
            {
                Ad = "berrin",
                Eposta = "mberiirn@gmail.com",
                KatilmaDurumu = true


            });

        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_Liste.ContainsKey(key))
            {
                _Liste[key] = model;
            }
            else
            {
                _Liste.Add(key, model);
            }

        }
        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _Liste.Values; }
        }
    }
}
