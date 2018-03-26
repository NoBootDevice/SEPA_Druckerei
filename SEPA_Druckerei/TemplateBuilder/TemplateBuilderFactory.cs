using System;
namespace SEPA_Druckerei.TemplateBuilder
{
    public class TemplateBuilderFactory
    {
        public TemplateBuilderFactory()
        {
        }

        //  BuildedStandardTemplate 


        /*
            Class that will "produce" the builded 
            Template Objects......
        */


        // this will handle the Account Owner Information Section
        public static BuildedStandardTemplate BuildAccountOwnerTemplate()
        {
            BuildedStandardTemplate buildaccountownertemplate = new BuildedStandardTemplate();

            buildaccountownertemplate.Headline = "Konteninhaber und Konten";
            buildaccountownertemplate.ChildTemplate = "AccountOwner.cshtml";

            return buildaccountownertemplate;
        }
    }
}
