// See https://aka.ms/new-console-template for more information
using System.Text;

var sb = new StringBuilder();
sb.Append("Hello ");
unsafe
{
    var* a = &sb;
}
sb.Append("Narang");
sb.Insert(1, "Ritika");
Object.

