using System;
namespace SEPA_Druckerei.TemplateBuilder
{
    public class TemplateBuilderFactory
    {
        public TemplateBuilderFactory()
        {
        }

        //  BuildedStandardTemplate 

        public static BuildedStandardTemplate BuildAccountOwnerTemplate()
        {
            BuildedStandardTemplate buildaccountownertemplate = new BuildedStandardTemplate();

            buildaccountownertemplate.Headline = "Konteninhaber und Konten";
            buildaccountownertemplate.ChildTemplate = "AccountOwner.cshtml";

            return buildaccountownertemplate;
        }
    }
}
