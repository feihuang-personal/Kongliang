﻿using System.Web.Mvc;

namespace WitBird.XiaoChangHe.Areas.WeChat
{
    public class WeChatAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WeChat";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "WeChat_default",
                "WeChat/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
