using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using static System.Console;
namespace CustomSerialization
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with Custom Serialization *****");

            // Recall that this type implements ISerializable.
            StringData myData = new StringData();

            // Save to a local file in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream("MyData.soap",
              FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, myData);
            }
            ReadLine();
        }
    }
}