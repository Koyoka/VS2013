﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace ElevenDEMO.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class ElevenDEMONavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", ElevenDEMOConsts.LocalizationSourceName),
                        url: "#/about",
                //url: "#/about",
                        icon: "fa fa-info"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", ElevenDEMOConsts.LocalizationSourceName),
                        //url: "",
                        url: "#/",
                        icon: "fa fa-home"
                        )
                );
        }
    }
}
