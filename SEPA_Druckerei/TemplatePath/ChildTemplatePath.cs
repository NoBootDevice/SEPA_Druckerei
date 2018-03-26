using System;
using System.Text;

namespace SEPA_Druckerei.TemplatePath
{


    /*

        TemplatePath, that will handle the 
        requests, for any section...

        PathToChildTemplates, shall include the relactive path to the 
        child template directory
    */


    public class ChildTemplatePath : MasterTemplatePath
    {

        #warning path to child templates are missing ....
        private readonly String PathToChildTemplates = "";
        private StringBuilder PathBuilder; 


        public ChildTemplatePath(String templateName) : base(templateName)
        {
            this.PathBuilder = new StringBuilder();   
        }

        public override String TemplateName 
        {
            // overrided property method

            // get will return the absolute path to the child template 
            get => AddPathToTemplateName(base.TemplateName); set => base.TemplateName = value;
        }

        private String AddPathToTemplateName(String NameToAdd)
        {
            // this method adds the needed path o the tmeplate name
            this.PathBuilder.Append(NameToAdd);
            return this.PathBuilder.ToString();
        }
    }
}
