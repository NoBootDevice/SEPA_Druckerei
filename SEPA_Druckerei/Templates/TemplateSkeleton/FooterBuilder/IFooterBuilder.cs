using System;
using static SEPA_Druckerei.TemplateBuilder.FooterBuilder.MasterFooterBuilder;

namespace SEPA_Druckerei.TemplateBuilder.FooterBuilder
{
    public interface IFooterBuilder
    {
        String isAnchorObject { get; set; }
        String isButtonObject { get; set; }

        // Define the name , of the toe - object 

        String ToeName { get; set; }

        // Define the class of the resulting Toe 

        ToeClasses ToeClass { get; set;  }
    }
}
