using System;
namespace SEPA_Druckerei.TemplatePath
{

    /*

        TemplatePath, that will be inhertied from all template Path related classes 


    */

    public class MasterTemplatePath
    {
        // The name of the template, that shall be rendered 
        private String templateName; 

        public MasterTemplatePath(String templateName)
        {
            this.templateName = templateName; 
        }

        public  virtual String TemplateName { get => templateName; set => templateName = value; }
    }
}
