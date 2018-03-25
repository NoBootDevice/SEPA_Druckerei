using System;
using SEPA_Druckerei.TemplatePath;

namespace SEPA_Druckerei.TemplateBuilder
{
    public class BuildedStandardTemplate 
    {

        // Field to define the Headline 
        private String headline;

        // Filed, to define the childfemplate name  
        private String childTemplateName;

        public string Headline { get => headline; set => headline = value; }

        public string ChildTemplate { get =>  TemplatePathFactory.BuildChildTemplatePath(childTemplateName); set => childTemplateName = value; }

    }
}
