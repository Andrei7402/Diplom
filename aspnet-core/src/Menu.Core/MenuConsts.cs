using Menu.Debugging;

namespace Menu
{
    public class MenuConsts
    {
        public const string LocalizationSourceName = "Menu";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4d528f1ea0384b2bb5057c36cfd3f837";
    }
}
