// QReplace v1.0 (c) 2022 Sensei (aka 'Q')
// Reads stdin and replaces one string with another string or deletes it.
//
// Usage:
// QReplace <from> <to>
// QReplace <to-delete>
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QReplace.cs
//
// TODO:
// - add regex support
// - replace multiple strings

using System;
public static class QReplace {
   private static void Help() {
      Console.WriteLine( "QReplace v1.0 (c) 2022 Sensei (aka 'Q')" );
      Console.WriteLine( "Reads stdin and replaces one string with another string or deletes it." );
      Console.WriteLine();
      Console.WriteLine( "Usage:" );
      Console.WriteLine( "QReplace <from> <to>" );
      Console.WriteLine( "QReplace <to-delete>" );
   }

   private static void Replace( string from, string to ) {
      //Console.WriteLine( "Replacing \"{0}\" by \"{1}\"", from, to );
      string row;
      while( ( row = Console.ReadLine() ) != null ) {
         Console.WriteLine( row.Replace( from, to ) );
      }
   }

   public static void Main( string [] args ) {
      if( args.Length == 2 ) {
         Replace( args[ 0 ], args[ 1 ] );
      } else if( args.Length == 1 ) {
         Replace( args[ 0 ], String.Empty );
      } else {
         Help();
      }
   }
}
