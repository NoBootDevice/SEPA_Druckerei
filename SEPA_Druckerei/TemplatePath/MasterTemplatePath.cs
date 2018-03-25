using System;
namespace SEPA_Druckerei.TemplatePath
{
    public class MasterTemplatePath
    {
        private String templateName; 

        public MasterTemplatePath(String templateName)
        {
            this.templateName = templateName; 
        }

        public  virtual String TemplateName { get => templateName; set => templateName = value; }
    }
}
