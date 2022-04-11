using System;

namespace Question1
{
    public class Program
    {
        static void Main()
        {
            //instantiating the ProgramHelper Class
            ProgramHelper programHelper1 = new ProgramHelper();
            string cSharpstring = programHelper1.ConvertToCSharp("a string");
            string vBString = programHelper1.ConvertToVB2005("another string");


            //
            Console.WriteLine(cSharpstring);    
            Console.WriteLine(vBString);

            ProgramConverter[] programConverters = new ProgramConverter[2];
            programConverters[0] = new ProgramConverter();
            programConverters[1] = new ProgramHelper();

            for(int i = 0; i < programConverters.Length; i++)
            {
                Console.WriteLine(programConverters[i] is ProgramHelper);
            }

            for (int i = 0; i < programConverters.Length; i++)
            {
                ProgramHelper programHelperType = programConverters[i] as ProgramHelper;
                if (programHelperType != null)
                {
                    programHelperType.CodeCheckSyntax(cSharpstring, "CSharp");
                }
                else if (programHelperType != null)
                {
                    programHelperType.CodeCheckSyntax(vBString, "VB2005");
                }
                else Console.WriteLine("its neither a VB or CSharp syntax");
            }
                
        }
    }

    public class ProgramHelper : ProgramConverter, someOtherinterface, ICodechecker
    {
        public bool CodeCheckSyntax(string strToCheck, string LangToUse)
        {
            if (LangToUse == "CSharp")
            {
                Console.WriteLine($"the Language to use is in CSharp.\nThus {strToCheck} is convertible");
                return true;
            }

            else if (LangToUse == "VB2005")
            {
                Console.WriteLine($"the language to use is in VB2005.\nThus {strToCheck} is convertible");
                return true;
            }
            return false;
        }
        public void Codechecking()
        {
            Console.WriteLine("checks the code as the name implies");
        }

    }
    public class ProgramConverter: IConvertible
    {
        public string ConvertToCSharp(string theString)
        {
            return $"{theString} got converted to CSharp";
        }
        public string ConvertToVB2005(string theString)
        {
            return $"{theString} got converted to VB 2005";
        }
    }
    public interface someOtherinterface: IConvertible
    {
        public bool CodeCheckSyntax(string strToCheck, string LangToUse);
    }
    public interface IConvertible
    {
        public string ConvertToCSharp(string theString);
        public string ConvertToVB2005(string theString);
        
    }
    public interface ICodechecker
    {
        public void Codechecking();
    }
    
}
