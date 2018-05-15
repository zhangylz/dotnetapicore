using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductsApp
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // default API
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}", // api是固定部分，区别于其他的mvc， controller是控制器占位符部分，在真实在真实的url里面，该部分对应的是具体的控制器的名称
                                                        //{id}”是参数的占位符部分，表示参数，一般这个参数都会在default里面设置可选
                defaults: new { id = RouteParameter.Optional } // 路由默认值
                // constraints : new { id = @"\d+" } 约束条件 必须要匹配一道多个参数iddoc
            );

            // custome API
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "actionapi/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // custome API
            config.Routes.MapHttpRoute(
                name: "TestApi",
                routeTemplate: "testapi/{controller}/{ordertype}/{id}",
                defaults: new { ordertype = "aa", id = RouteParameter.Optional }
            );
        }
    }
}
