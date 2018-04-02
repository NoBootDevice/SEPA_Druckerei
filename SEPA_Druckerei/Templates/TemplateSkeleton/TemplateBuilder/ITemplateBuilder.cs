using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SEPA_Druckerei.TemplateBuilder.ColumnBuilder;

namespace SEPA_Druckerei.TemplateBuilder
{
    public interface ITemplateBuilder
    {
        string Menupoint();

        List<Collection<IColumnBuilder>> ColumnRows();
    }
}
