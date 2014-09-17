using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Globalization;
using System.Diagnostics;

namespace peach_project_
{
   public static  class MutationFunctions
    {
       public static void mutate(XDocument peachPit, Random rnd)
       {
           var DataModelblocks = peachPit.XPathSelectElements("Peach/DataModel");
           var Testblocks = peachPit.XPathSelectElements("Peach/Test");
           foreach (var block in DataModelblocks)
           {
               var descendants = block.DescendantsAndSelf();
               foreach (var des in descendants)
               {
                   //make mutation according to the tags
                   switch (des.Name.ToString().ToLower())
                   {
                       case "block":
                           MutationFunctions.block_(des, rnd);
                           break;
                       case "blob":
                           MutationFunctions.blob_(des, rnd);
                           break;
                       case "choice":
                           MutationFunctions.choice_(des, rnd);
                           break;
                       case "custom":
                           break;
                       case "flag":
                           MutationFunctions.flag_(des, rnd);
                           break;
                       case "flags":
                           break;
                       case "number":
                           MutationFunctions.number_(des, rnd);
                           break;
                       case "padding":
                           break;
                       case "string":
                           MutationFunctions.string_(des, rnd);
                           break;
                       case "relation":
                           break;
                       case "fixup":
                           break;
                       case "transformer":
                           break;
                       case "placement":
                           break;
                       case "datamodel":
                           MutationFunctions.datamodel_(des, rnd);
                           break;
                       default:
                           Console.WriteLine("ERROR:UNKNOWN TAG");
                           break;
                   }
               }
           }
       }



        public static void flag_(XElement el, Random rnd)
        {

            int val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                size(el, rnd);

            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                value_(el, rnd);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }

        }


       public static void choice_(XElement el, Random rnd)
        {

            int val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el, rnd);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                occurs(el, rnd);
            }

        }



        public static void number_(XElement el, Random rnd)
        {

            int val = rnd.Next(1, 100);
            //  int bits = rnd.Next(3, 6); 
            //  if (val % 2 == 0)
            //{
            //              size(el, bits);
            //        }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                value_(el, rnd);
            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                token(el, rnd);
            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                endian(el, rnd);
            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                signed(el, rnd);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el, rnd);
            }
        }



        public static void datamodel_(XElement el, Random rnd)
        {

            int val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }
        }


        public static void block_(XElement el, Random rnd)
        {
            //minoccurs or maxOccurs
            int val;
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el, rnd);
            }
            //mutable or not mutable
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }
        }


        public static void blob_(XElement el, Random rnd)
        {
            //minoccurs  maxOccurs
            int val;

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el, rnd);
            }
            val = rnd.Next(1, 100);
            //mutable or not mutable
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }
            val = rnd.Next(1, 100);

            if (val % 2 == 0)
            {
                token(el, rnd);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                value_(el, rnd);
            }


        }

        public static void string_(XElement el, Random rnd)
        {
            //minoccurs  maxOccurs
            int val;

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                null_terminated(el);  //problems with string in zip file
            }

            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el, rnd);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el, rnd);
            }
            // val = rnd.Next(1, 100);
            //if (val % 2 == 0)
            //{
            //   token(el);
            //}
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                value_(el, rnd);

            }
        }

        //=====================================================================================================================================

        public static void occurs(XElement el, Random rnd)
        {

            int occurs = rnd.Next(1, 100);
            if (el.Attribute("occurs") != null)
            {
                el.Attribute("occurs").SetValue(occurs.ToString());
            }
            else
            {

                //  XAttribute attribute = new XAttribute("occurs", occurs.ToString());
                //el.Add(attribute);
            }
        }
        public static void signed(XElement el, Random rnd)
        {

            //default value of mutable is true
            if (el.Attribute("signed") != null)
            {
                if (el.Attribute("signed").Value.ToString().Equals("false"))
                {
                    el.Attribute("signed").SetValue("true");
                }
                else
                {
                    el.Attribute("signed").SetValue("false");
                }
            }
            else
            {
                //  XAttribute attribute = new XAttribute("signed", "false");
                // el.Add(attribute);
            }
        }


        public static void endian(XElement el, Random rnd)
        {
            if (el.Attribute("endian") != null)
            {
                if (el.Attribute("endian").Value.ToString().Equals("little"))
                {
                    el.Attribute("endian").SetValue("big");
                }
                else
                {
                    el.Attribute("endian").SetValue("little");
                }
            }
            else
            {

                // XAttribute attribute = new XAttribute("endian", "big");
                // el.Add(attribute);
            }

        }

        public static void size(XElement el,Random rnd ,int bits = -1 )
        {

            if (bits == -1)
                bits = rnd.Next(3, 6); //from 1 to 8 bits
            if (el.Attribute("size") != null)
            {
                if (el.Name == "Flag")
                {

                    while (Convert.ToInt32(el.Attribute("size").Value.ToString()) > Convert.ToInt32(el.Parent.Attribute("size").Value.ToString()))
                    {
                        bits--;
                        el.Attribute("size").SetValue(Math.Pow(2, bits).ToString());
                    }
                }
                else
                    el.Attribute("size").SetValue(Math.Pow(2, bits).ToString());
            }
        }

        public static void padCharacter(XElement el, Random rnd)
        {

            char c = (char)(rnd.Next(90) + 32);

            if (el.Attribute("padCharacter") != null)
            {
                el.Attribute("padCharacter").SetValue(c);
            }
            else
            {
                // XAttribute attribute = new XAttribute("padCharacter", "true");
                //el.Add(attribute);
            }
        }


        public static void null_terminated(XElement el)
        {//default value is false
            if (el.Attribute("nullTerminated") != null)
            {
                if (el.Attribute("nullTerminated").Value.ToString().Equals("false"))
                {
                    el.Attribute("nullTerminated").SetValue("true");
                }
                else
                {
                    el.Attribute("nullTerminated").SetValue("false");
                }
            }
            else
            {
                XAttribute attribute = new XAttribute("nullTerminated", "false");
                el.Add(attribute);
            }


        }


        public static void length(XElement el, Random rnd)
        {

            if (el.Attribute("value") != null)
            {
                el.SetAttributeValue("length", el.Attribute("value").Value.Length.ToString());
            }
            else if (el.Attribute("value") == null && el.Attribute("length") != null)
            {
                el.SetAttributeValue("length", rnd.Next(1, 100).ToString());
            }
            else
            {
                // val = rnd.Next(1, 100);
                // XAttribute attribute = new XAttribute("length", val.ToString());
                // el.Add(attribute);
            }
        }

        public static void minMaxOccurs(XElement el, Random rnd)
        {
            int minValue = -1, maxValue = -1;
            if (el.Attribute("maxOccurs") != null)
            {
                maxValue = Convert.ToInt32(el.Attribute("maxOccurs").Value.ToString());
            }
            if (el.Attribute("minOccurs") != null)
            {
                minValue = Convert.ToInt32(el.Attribute("minOccurs").Value.ToString());
            }


            if (maxValue != -1 && minValue == -1)
            {
                maxValue = rnd.Next(1, maxValue);
                el.Attribute("maxOccurs").SetValue(maxValue.ToString());
            }
            else if (maxValue != -1 && minValue != -1)
            {
                maxValue = rnd.Next(minValue + 1, maxValue);
                el.Attribute("maxOccurs").SetValue(maxValue.ToString());
            }
            if (minValue != -1 && maxValue == -1)
            {
                minValue = rnd.Next(minValue, minValue * 2);
                el.Attribute("minOccurs").SetValue(minValue.ToString());
            }
            else if (minValue != -1 && maxValue != -1)
            {
                minValue = rnd.Next(minValue, maxValue);
                el.Attribute("minOccurs").SetValue(minValue.ToString());
            }
        }


        public static void mutable(XElement el, Random rnd)
        {
            //default value of mutable is true
            if (el.Attribute("mutable") != null)
            {
                if (el.Attribute("mutable").Value.ToString().Equals("false"))
                {
                    el.Attribute("mutable").SetValue("true");
                }
                else
                {
                    el.Attribute("mutable").SetValue("false");
                }
            }
            else
            {
                XAttribute attribute = new XAttribute("mutable", "false");
                el.Add(attribute);
            }
        }

        public static void token(XElement el, Random rnd)
        {
            if (el.Attribute("token") != null)
            {
                if (el.Attribute("token").Value.ToString().Equals("false"))
                {
                    el.Attribute("token").SetValue("true");
                }
                else el.Attribute("token").SetValue("false");
            }
            else if (el.Attribute("length") != null)
            {

                //  XAttribute attribute = new XAttribute("token", false);
                // el.Add(attribute);
            }

        }

        /*   public static void string_value_(XElement el)
           {
               String StrValue;
               int val_length;
               Random rnd = new Random();
               val_length = rnd.Next(1, 100);
               StrValue = crString(val_length);
               if (el.Attribute("value") != null)
                   el.Attribute("value").SetValue(StrValue);
               else
               {
                   XAttribute attribute = new XAttribute("value", StrValue);
                   el.Add(attribute);
               }
               length(el);
           }*/

        public static void value_(XElement el, Random rnd)
        {
            String type;
            String StrValue = "";
            int val_length;
            int size = -1; ;

            if (el.Attribute("valueType") == null)
            {
                type = "string";
            }
            else type = el.Attribute("valueType").Value.ToString();


            switch (type.ToLower())
            {
                case "string":
                    if (el.Name == "Number")
                    {
                        size = Convert.ToInt32(el.Attribute("size").Value.ToString());

                        double u = (Math.Pow(2, size)) / 2 - 1;
                        StrValue = rnd.Next(0, 10000).ToString();
                        // el.Attribute("value").SetValue(StrValue);
                    }
                    else if (el.Name == "Blob" || el.Name == "String")
                    {
                        val_length = rnd.Next(1, 100);
                        StrValue = crString(val_length, rnd);
                        //  el.Attribute("value").SetValue(StrValue);
                        if (el.Name == "String")
                            length(el, rnd);
                    }
                    break;
                case "hex":
                    int b;
                    b = Convert.ToInt32(el.Attribute("value").Value.ToString(), 16);
                    b = rnd.Next(0, Math.Abs(b));
                    StrValue = b.ToString("x");
                    val_length = StrValue.Length;
                    // el.Attribute("value").SetValue(StrValue);
                    if (el.Name == "Blob" || el.Name == "String")
                        length(el, rnd);
                    break;
                case "literal":
                    break;
                default:
                    Console.WriteLine("Error:Wnknown Type");
                    break;

            }

            if (el.Attribute("value") != null)
            {
                el.Attribute("value").SetValue(StrValue);
            }
            else
            {
                // XAttribute attribute = new XAttribute("value", StrValue);
                // el.Add(attribute);
            }

        }

        public static String crString(int length, Random rnd)
        {

            StringBuilder b = new StringBuilder();
            for (int j = 0; j < length; j++)
            {
                char c = (char)(rnd.Next(90) + 32);
                b.Append(c);
            }
            return b.ToString();

        }

    }
}
