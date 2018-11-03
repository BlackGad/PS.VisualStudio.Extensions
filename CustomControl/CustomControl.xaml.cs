using System;

namespace $rootnamespace$
{
    public class $safeitemname$ : Control
    {
        #region Constructors

        static $safeitemname$()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof($safeitemname$), new FrameworkPropertyMetadata(typeof($safeitemname$)));
            ResourceHelper.SetDefaultStyle(typeof($safeitemname$), Resource.ControlStyle);
        }

        #endregion

        #region Nested type: Resource

        public static class Resource
        {
            #region Constants

            [Obsolete("Require manual correction", 1)]
            private static readonly Uri Default =
                new Uri("/$projectname$;component/Controls/$safeitemname$.xaml", UriKind.RelativeOrAbsolute);

            public static readonly ResourceDescriptor ControlStyle =
                ResourceDescriptor.Create<Style>(description: "Default $safeitemname$ style",
                                                 resourceDictionary: Default);

            public static readonly ResourceDescriptor ControlTemplate =
                ResourceDescriptor.Create<ControlTemplate>(description: "Default $safeitemname$ control template",
                                                           resourceDictionary: Default);

            #endregion
        }

        #endregion
    }
}