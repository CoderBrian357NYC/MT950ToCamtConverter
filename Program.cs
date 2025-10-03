using System;
using System.IO;
using System.Xml.Serialization;
using MT950ToCamtConverter.Models;
using MT950ToCamtConverter.Parsers;
using MT950ToCamtConverter.Mappers;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            string inputPath = Path.Combine("input", "input_mt950_01.txt");
            string outputPath = Path.Combine("output", "output_camt053.xml");

            // 1. Read MT950 input
            string mt950Text = File.ReadAllText(inputPath);

            // 2. Parse MT950
            var mt950Statement = MT950Parser.Parse(mt950Text);


            // 3. Map to CAMT.053
            var mapper = new Camt053Mapper();
            Document camtDocument = mapper.Map(mt950Statement);

            // 4. Serialize CAMT.053 XML to output folder
            var serializer = new XmlSerializer(typeof(Document));
            using var writer = new StreamWriter(outputPath);
            serializer.Serialize(writer, camtDocument);

            Console.WriteLine($"Conversion complete! Output saved to '{outputPath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
