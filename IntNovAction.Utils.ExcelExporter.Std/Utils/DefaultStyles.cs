﻿using IntNovAction.Utils.ExcelExporter.Configurators;

namespace IntNovAction.Utils.ExcelExporter.Utils
{
    internal class DefaultStyles
    {
        internal static FormatConfigurator GetCellDefaultStyle()
        {
            var formatConfig = new FormatConfigurator()
                .Bold(false)
                .Italic(false)
                .BottomBorder(false)
                .Color(0, 0, 0)
                .FontSize(11);

            return formatConfig;
        }

        internal static FormatConfigurator GetHeadersDefaultStyle()
        {
            var formatConfig = new FormatConfigurator()
                .Bold()
                .BottomBorder()
                .FontSize(12);

            return formatConfig;
        }

        internal static FormatConfigurator GetTitleDefaultStyle()
        {
            var formatConfig = new FormatConfigurator()
                .Bold()
                .Italic()
                .FontSize(18);

            return formatConfig;
        }
    }
}