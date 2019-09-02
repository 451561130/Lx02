using System;

namespace Model
{
    public class UserInfo
    {
        pubilc string userName { get; set; }
        pubilc string passWord { get; set; }
        pubilc string qq { get; set; }
        pubilc string email { get; set; }
        pubilc string type { get; set; }
        pubilc string userImg { get; set; }
    }
    public class UserInfoNo : UserInfo
    {
        public int num { get; set; }
    }
    public class Page
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
