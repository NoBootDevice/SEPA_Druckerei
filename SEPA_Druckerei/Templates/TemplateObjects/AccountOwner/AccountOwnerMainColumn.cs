using System;
using System.Collections.ObjectModel;
using SEPA_Druckerei.TemplateBuilder.FooterBuilder;
using SEPA_Druckerei.Templates.TemplateSkeleton.ColumnBuilder.MainColumn;
using SEPA_Druckerei.TemplateBuilder.ColumnBuilder; 


namespace SEPA_Druckerei.Templates.TemplateObjects.AccountOwner
{
    public class AccountOwnerMainColumn: IMainColumn
    {
        private String AccountOwnerMainColumnHeadline;

        private String DisplayAccountOwnerHeadline; 
        private String DisplayAccountOwnerFooter; 

        public string MainColumnHeadline { 
           
            get => AccountOwnerMainColumnHeadline; 

            set => AccountOwnerMainColumnHeadline = "Konteninhaber"; 
        }

        string IMainColumn.DisplayHeader { 

            get => DisplayAccountOwnerHeadline; 

            set => DisplayAccountOwnerHeadline = MasterColumnBuilder.Display.DisplayHeader.ToString(); 
        
        }
       
        string IMainColumn.DisplayFooter { 
           
            get => DisplayAccountOwnerFooter;
            set => DisplayAccountOwnerFooter = "";
        }
    
        Collection<IFooterBuilder> IMainColumn.DetermineToes 
        { get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
    }
}
