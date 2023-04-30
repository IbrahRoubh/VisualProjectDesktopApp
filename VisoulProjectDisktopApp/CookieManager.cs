using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VisoulProjectDisktopApp
{
    public class CookieManager
    {
        private CookieContainer cookieContainer;
        public void setCooike(String username)
        {
            Cookie cookie = new Cookie("username", username, "/", "localhost");
            cookie.Expires = DateTime.Now.AddDays(1);
            cookieContainer = new CookieContainer();
            cookieContainer.Add(cookie);
        }

        public CookieContainer GetCookie()
        {
            return cookieContainer;
        }
    }
}
