using System;
using System.Collections.ObjectModel;
using SEPA_Druckerei.TemplateBuilder.FooterBuilder;
using static SEPA_Druckerei.TemplateBuilder.ColumnBuilder.MasterColumnBuilder;

namespace SEPA_Druckerei.TemplateBuilder.ColumnBuilder
{
    public interface IColumnBuilder
    {

        String Headline { get; set; }
        String FooterArea { get; set; }


        ColumnClasses ColumnClass { get; set; }
        ContainerClasses ContainerClass { get; set; }

        Collection<IFooterBuilder> FooterObjects { get; set; }

 

    }
}
