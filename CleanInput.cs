using System.Linq;


namespace CleanInput
{
  public static class Clean
  {
    public static string Word()
    {
      string? input = "";
      
      
      while (string.IsNullOrEmpty(input)       ||
             input.Contains(" ")               ||
             input.Contains("\n")              ||
             input.Contains("\r")              ||
             input.Contains("\f")              ||
             input.Contains("\t")              ||
             input.Contains("\v")              ||
             input.Contains("\b")              ||
             input.Contains("\a")              ||
             (input.All(Char.IsLetter) == false))
      {
        input = System.Console.ReadLine();
      }
      
      
      input = input.Trim();
      
      
      return input;
    }
    
    
    public static string Sentence()
    {
      string? input = "";
      
      
      while (string.IsNullOrEmpty(input)        ||
             input.Contains("\n")               ||
             input.Contains("\r")               ||
             input.Contains("\f")               ||
             input.Contains("\t")               ||
             input.Contains("\v")               ||
             input.Contains("\b")               ||
             input.Contains("\a")               ||
             (Char.IsLetter(input[0]) == false) ||
             (input.EndsWith(".")     == false)  )
      {
        input = System.Console.ReadLine();
      }
      
      
      input = input.Trim();
      
      // Get rid of extra spaces between words
      input = string.Join(' ', input.Split(' ').Where(word => string.IsNullOrEmpty(word) == false));
      
      
      return input;
    }
    
    
    public static string Question()
    {
      string? input = "";
      
      
      while (string.IsNullOrEmpty(input)        ||
             input.Contains("\n")               ||
             input.Contains("\r")               ||
             input.Contains("\f")               ||
             input.Contains("\t")               ||
             input.Contains("\v")               ||
             input.Contains("\b")               ||
             input.Contains("\a")               ||
             (Char.IsLetter(input[0]) == false) ||
             (input.EndsWith("?")     == false)  )
      {
        input = System.Console.ReadLine();
      }
      
      
      input = input.Trim();
      
      // Get rid of extra spaces between words
      input = string.Join(' ', input.Split(' ').Where(word => string.IsNullOrEmpty(word) == false));
      
      
      return input;
    }
    
    
    public static string Exclamation()
    {
      string? input = "";
      
      
      while (string.IsNullOrEmpty(input)        ||
             input.Contains("\n")               ||
             input.Contains("\r")               ||
             input.Contains("\f")               ||
             input.Contains("\t")               ||
             input.Contains("\v")               ||
             input.Contains("\b")               ||
             input.Contains("\a")               ||
             (Char.IsLetter(input[0]) == false) ||
             (input.EndsWith("!")     == false)  )
      {
        input = System.Console.ReadLine();
      }
      
      
      input = input.Trim();
      
      // Get rid of extra spaces between words
      input = string.Join(' ', input.Split(' ').Where(word => string.IsNullOrEmpty(word) == false));
      
      
      return input;
    }
    
    
    public static string This(string s)
    {
      if ( string.IsNullOrEmpty(s) ) { return ""; }
      
      
      return
      s.Replace(" " , "")
       .Replace("\n", "")
       .Replace("\r", "")
       .Replace("\f", "")
       .Replace("\t", "")
       .Replace("\v", "")
       .Replace("\b", "")
       .Replace("\a", "")
       .Replace("1" , "")
       .Replace("2" , "")
       .Replace("3" , "")
       .Replace("4" , "")
       .Replace("5" , "")
       .Replace("6" , "")
       .Replace("7" , "")
       .Replace("8" , "")
       .Replace("9" , "")
       .Replace("0" , "")
       .Replace("!" , "")
       .Replace("@" , "")
       .Replace("#" , "")
       .Replace("$" , "")
       .Replace("%" , "")
       .Replace("^" , "")
       .Replace("&" , "")
       .Replace("*" , "")
       .Replace("(" , "")
       .Replace(")" , "")
       .Replace("-" , "")
       .Replace("_" , "")
       .Replace("=" , "")
       .Replace("+" , "")
       .Replace("[" , "")
       .Replace("]" , "")
       .Replace("{" , "")
       .Replace("}" , "")
       .Replace("\\", "")
       .Replace("|" , "")
       .Replace(";" , "")
       .Replace(":" , "")
       .Replace("\'", "")
       .Replace("\"", "")
       .Replace("/" , "")
       .Replace("//", "")
       .Replace("?" , "")
       .Replace("." , "")
       .Replace(">" , "")
       .Replace("," , "")
       .Replace("<" , "")
       .Replace("`" , "")
       .Replace("~" , "")
       .Trim();
    }
  }
}
