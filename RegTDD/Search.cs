using System;
using System.Collections.Generic;

namespace RegTDD
{
    public class Search
    {
        public bool SearchEnter(string login, string password)
        {
            RegEnter db = new RegEnter();
            List<string> list = db.Enter(login, password);
            foreach (string str in list)
                if (str == login)
                    return true;
            return false;
        }
    }
}