﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuAnhKhoa_Lab456.Startup))]
namespace TuAnhKhoa_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
