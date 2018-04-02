using System;
using System.Collections.ObjectModel;
using SEPA_Druckerei.TemplateBuilder.FooterBuilder;

namespace SEPA_Druckerei.Templates.TemplateSkeleton.ColumnBuilder.MainColumn
{
    public interface IMainColumn
    {

        String MainColumnHeadline { get; set; }

        String DisplayHeader { get; set; }


        String DisplayFooter { get; set;  }

        Collection<IFooterBuilder> DetermineToes { get; set; }
    }
}
