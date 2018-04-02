using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SEPA_Druckerei.TemplateBuilder;
using SEPA_Druckerei.TemplateBuilder.ColumnBuilder;

namespace SEPA_Druckerei.Templates.TemplateObjects
{
    public class AccountOwner: MasterTemplateBuilder, ITemplateBuilder
    {
        public AccountOwner()
        {

            this.TemplateHeadline = "Konteninhaber samt Konten"; 
        }

        public List<Collection<IColumnBuilder>> ColumnRows()
        {
            List<Collection<IColumnBuilder>> rows = new List<Collection<IColumnBuilder>>();

            Collection<IColumnBuilder> firstRow = ColumnRowFactory.buildSplitTemplate();

            rows.Add(  ColumnsFactory.equipRow(firstRow,
                                            ColumnFactory.buildColumnWithoutFooter(new AccountOwnerMainColumn()) , 
                                        ColumnFactory.buildColumn(new AccountOwnerSubColumn()) )   );


            Collection<IColumnBuilder> secondRow = ColumnRowFactory.build(RowForms.SplitTemplate);

            rows.Add(ColumnsFactory.equipRow(secondRow,
                                            ColumnFactory.buildColumnWithoutFooter(new AccountMainColumn()),
                                        ColumnFactory.buildColumn(new AccountSubColumn())));



            return rows; 
        }

        public string Menupoint()
        {
            return this.TemplateHeadline;
        }

        List<Collection<IColumnBuilder>> ITemplateBuilder.ColumnRows()
        {
            throw new NotImplementedException();
        }
    }
}
