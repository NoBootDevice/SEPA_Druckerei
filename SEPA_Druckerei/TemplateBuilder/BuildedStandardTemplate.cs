using System;
using SEPA_Druckerei.TemplatePath;

namespace SEPA_Druckerei.TemplateBuilder
{
    /*

        blank builded Template Class, 

        This means, every section will be hold by one
        Object of these class. 

        String headline, the headline of the section

        String childTemplateName, the name of the child template....


        -> An Object, does hold the information, that is needed to
        render a section...... 
    */


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
