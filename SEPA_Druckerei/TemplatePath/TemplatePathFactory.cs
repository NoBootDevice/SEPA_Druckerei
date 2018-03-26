using System;
namespace SEPA_Druckerei.TemplatePath
{
    
    public class TemplatePathFactory
    {
        public static String BuildChildTemplatePath (String templateName)
        {
            ChildTemplatePath childTemplate = new ChildTemplatePath(templateName);

            return childTemplate.TemplateName;
        }
    }
}
