﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiscordPresenceUI.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DiscordPresenceUI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à App.
        /// </summary>
        public static string app {
            get {
                return ResourceManager.GetString("app", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Edit the form in order to update your Discord Presence. Click the update button and check your Discord. Refer to the [url=/Pages/Usage.xaml|_top]usage page[/url] for more informations about the configuration of your Discord Presence..
        /// </summary>
        public static string app_details_text {
            get {
                return ResourceManager.GetString("app_details_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à APP DETAILS.
        /// </summary>
        public static string app_details_title {
            get {
                return ResourceManager.GetString("app_details_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à App ID.
        /// </summary>
        public static string app_id {
            get {
                return ResourceManager.GetString("app_id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à App Settings.
        /// </summary>
        public static string app_settings {
            get {
                return ResourceManager.GetString("app_settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Edit the following settings according to your preferences. Click save to update them, reset if you want them to reset to default, or repair if they don&apos;t save when you tell them to..
        /// </summary>
        public static string app_settings_text {
            get {
                return ResourceManager.GetString("app_settings_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à APP SETTINGS.
        /// </summary>
        public static string app_settings_title {
            get {
                return ResourceManager.GetString("app_settings_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap apps {
            get {
                object obj = ResourceManager.GetObject("apps", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap assets {
            get {
                object obj = ResourceManager.GetObject("assets", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Start with Windows.
        /// </summary>
        public static string boot_with_windows_text {
            get {
                return ResourceManager.GetString("boot_with_windows_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Close to tray.
        /// </summary>
        public static string close_to_tray_text {
            get {
                return ResourceManager.GetString("close_to_tray_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Configuration.
        /// </summary>
        public static string configuration {
            get {
                return ResourceManager.GetString("configuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à CONFIGURE YOUR APP.
        /// </summary>
        public static string configure_your_app {
            get {
                return ResourceManager.GetString("configure_your_app", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Now that your app is created, you need to [b]name[/b] it. You will be able to change its name whenever you want, but to do so you will need to head to the Developer Portal again. 
        ///
        ///You will also need to copy your [b]client ID[/b], as it is needed in the [url=/Pages/RichPresenceSettings.xaml]settings page[/url]. 
        ///The last thing you will need to do is to [url=cmd://portal]upload one or more assets[/url]. 
        ///                    
        ///You can upload any image that has a minimum size of [b]512 x 512[/b]. You will  [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        public static string configure_your_app_text {
            get {
                return ResourceManager.GetString("configure_your_app_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à CREATING YOUR APP.
        /// </summary>
        public static string create_your_app {
            get {
                return ResourceManager.GetString("create_your_app", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à For the Discord Presence to work, you will need a few step that can not be done through this utility software. 
        ///First of all, go to the [url=https://discordapp.com/developers/applications/]Developer Portal[/url]. You may have to log in before you can do anything. 
        ///Once logged in, you will be able to [b]create an application[/b]..
        /// </summary>
        public static string create_your_app_text {
            get {
                return ResourceManager.GetString("create_your_app_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Dark.
        /// </summary>
        public static string dark {
            get {
                return ResourceManager.GetString("dark", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à End Timestamp.
        /// </summary>
        public static string end_timestamp {
            get {
                return ResourceManager.GetString("end_timestamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Exit.
        /// </summary>
        public static string exit {
            get {
                return ResourceManager.GetString("exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Are you sure you want to leave? Your Discord Presence will disappear if you do so..
        /// </summary>
        public static string exit_message {
            get {
                return ResourceManager.GetString("exit_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Game Details.
        /// </summary>
        public static string game_details {
            get {
                return ResourceManager.GetString("game_details", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Game State.
        /// </summary>
        public static string game_state {
            get {
                return ResourceManager.GetString("game_state", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à GitHub.
        /// </summary>
        public static string github {
            get {
                return ResourceManager.GetString("github", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Help.
        /// </summary>
        public static string help {
            get {
                return ResourceManager.GetString("help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à HOW TO USE.
        /// </summary>
        public static string how_to_use {
            get {
                return ResourceManager.GetString("how_to_use", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Icon semblable à (Icône).
        /// </summary>
        public static System.Drawing.Icon icon_ico {
            get {
                object obj = ResourceManager.GetObject("icon_ico", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à You can add image in the [url=cmd://portal]developer portal[/url]. More informations [url=/Pages/Usage.xaml]here[/url]..
        /// </summary>
        public static string images_hint {
            get {
                return ResourceManager.GetString("images_hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Large Image Key.
        /// </summary>
        public static string large_image_key {
            get {
                return ResourceManager.GetString("large_image_key", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Large Image Text.
        /// </summary>
        public static string large_image_text {
            get {
                return ResourceManager.GetString("large_image_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Light.
        /// </summary>
        public static string light {
            get {
                return ResourceManager.GetString("light", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Language.
        /// </summary>
        public static string locale_text {
            get {
                return ResourceManager.GetString("locale_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à A new version ({0}) is available. Current version is {1}. Do you want to download it?.
        /// </summary>
        public static string new_version {
            get {
                return ResourceManager.GetString("new_version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à New version ({0}).
        /// </summary>
        public static string new_version_text {
            get {
                return ResourceManager.GetString("new_version_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à QUICK NOTE ABOUT APPS.
        /// </summary>
        public static string quick_note {
            get {
                return ResourceManager.GetString("quick_note", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à An app is a tool that allows a developer to create [b]bots[/b], [b]third party utilities[/b], or [b]rich presences[/b] for games.
        ///If you need more informations about the Developer Portal, you can check its [url=https://discordapp.com/developers/docs/intro]documentation[/url]..
        /// </summary>
        public static string quick_note_text {
            get {
                return ResourceManager.GetString("quick_note_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Repair.
        /// </summary>
        public static string repair {
            get {
                return ResourceManager.GetString("repair", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à This will try to repair settings if they do not save after you close the app. Continue?.
        /// </summary>
        public static string repair_message {
            get {
                return ResourceManager.GetString("repair_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Reset.
        /// </summary>
        public static string reset {
            get {
                return ResourceManager.GetString("reset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Reset settings? The app will restart if you click yes..
        /// </summary>
        public static string reset_message {
            get {
                return ResourceManager.GetString("reset_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Restart.
        /// </summary>
        public static string restart {
            get {
                return ResourceManager.GetString("restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Do you want to restart?.
        /// </summary>
        public static string restart_message {
            get {
                return ResourceManager.GetString("restart_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Rich Presence.
        /// </summary>
        public static string rich_presence {
            get {
                return ResourceManager.GetString("rich_presence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Save.
        /// </summary>
        public static string save {
            get {
                return ResourceManager.GetString("save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Small Image Key.
        /// </summary>
        public static string small_image_key {
            get {
                return ResourceManager.GetString("small_image_key", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Small Image Text.
        /// </summary>
        public static string small_image_text {
            get {
                return ResourceManager.GetString("small_image_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Start in tray.
        /// </summary>
        public static string start_in_tray_text {
            get {
                return ResourceManager.GetString("start_in_tray_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Start Timestamp.
        /// </summary>
        public static string start_timestamp {
            get {
                return ResourceManager.GetString("start_timestamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Discord Rich Presence.
        /// </summary>
        public static string title {
            get {
                return ResourceManager.GetString("title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Update.
        /// </summary>
        public static string update {
            get {
                return ResourceManager.GetString("update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Usage.
        /// </summary>
        public static string usage {
            get {
                return ResourceManager.GetString("usage", resourceCulture);
            }
        }
    }
}
