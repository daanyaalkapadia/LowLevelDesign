using LowLevelDesign.Factory.Platform;

namespace LowLevelDesign.Factory
{
    internal class Client
    {
        public static void FactoryMain()
        {
            Flutter flutter = new Flutter();
            var platform = flutter.GetPlatform(SupportedPlatform.Android);
            platform.AddMenu();
            platform.AddButton();
            platform.AddDropDown();
        }
    }
}
