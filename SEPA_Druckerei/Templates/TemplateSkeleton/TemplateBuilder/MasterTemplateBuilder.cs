using System;
namespace SEPA_Druckerei.TemplateBuilder
{
    public abstract  class MasterTemplateBuilder
    {

        private String templateHeadline;

        protected string TemplateHeadline { get => templateHeadline; set => templateHeadline = value; }


        public  enum RowForms{

            SplitTemplate, 
            /*
                Template will contain two inner "Templates", one 
                big Template with column 9, and one smaller Template with clumn length 3 
            */

            WholeTemplate
            /*

                Whole Template (Row is 12 )
            */
        }

         
        /*

ColumnRows

———

@Model.Mountpoint => String 

ColumnRows => Column Collection

rowObject.Columns => Collection
 
(Contains column objects)

columnObject.ColumnClass => Column Class (Enum)

columnObject.ContainerClass => Container Class (Enum)

columnObject.Headline = Headline für den Hauptcontainer  string 

columnObject.FooterArea => Display Footer Area or not  String 

columnObject.FooterObjects => FooterObjects is a Collection

toe.isAnchorObject => is an anchor object  (String)

toe.isButtonObject => is an anchor object  (String)


toe.ToeClass = Class of the Toe   (Enum)

toe.ToeName = Name of the toe (Enum)

——
        */

        public MasterTemplateBuilder()
        {
        }


    }
}
