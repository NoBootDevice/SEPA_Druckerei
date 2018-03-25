using System;
using System.Text;

namespace SEPA_Druckerei.TemplatePath
{
    public class ChildTemplatePath : MasterTemplatePath
    {
        private readonly String PathToChildTemplates = "";
        private StringBuilder PathBuilder; 


        public ChildTemplatePath(String templateName) : base(templateName)
        {
            this.PathBuilder = new StringBuilder();   
        }

        public override String TemplateName 
        {
            get => AddPathToTemplateName(base.TemplateName); set => base.TemplateName = value;
        }

        private String AddPathToTemplateName(String NameToAdd)
        {

            this.PathBuilder.Append(NameToAdd);
            return this.PathBuilder.ToString();
        }
    }
}
