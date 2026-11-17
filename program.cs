using System;
using System.Globallization;
using System.Xml;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            string commandline=Console.ReadLine();
            if(string.isnullorwhitespace(commandline))
            {
                Console.WriteLine("No command line input provided.");
                return;
            }
            commandline=commandline.Trim();
            string[] parts=commandline.Split(' ',2,stringsplitoptions.removeemptyentries);
            string cmd=parts[0].toUpper();
            string xmlContent=Console.In.ReadToEnd();
            XmlDocument xmlDoc=new XmlDocument();
            xmlDoc.LoadXml(xmlContent);
            switch(cmd)
            {
                case"LUONG_TREN":
                if(parts.Length<2||!decimal.TryParse(parts[1],out decimal luongTren))
                {
                    Console.WriteLine("Missing parameter for LUONG_TREN command.");
                    return;
                }
                HandleLuongTren(doc,minLuong);
                return;
                case"PHONG":
                if(parts.Length<2)
                {
                    Console.WriteLine("Missing parameter for PHONG command.");
                    return;
                }
                string maPhong=parts[1].trim();
                HandlePhong(doc,maPhong);
                break;
                case"DEM":
                HandleDem(doc);
                break;
                case"XPATH":
                if(parts.Length<2)
                {
                    Console.WriteLine("Missing parameter for XPATH command.");
                    return;
                }
                string xpathExpression=parts[1].trim();
                HandleXPath(doc,xpathExpression);
                break;
                case"THUONG":
                HandleThuong(doc);
                break;
                default:
                console.WriteLine($"Unknown command: {cmd}");
                break;
            }
        }
        static void HandleLuongTren(XmlDocument doc, decimal luongTren)
        {
            string xpath=$"//NhanVien[number(Luong)>{luongTren.ToString(CultureInfo.InvariantCulture)}]";
            XmlNodeList nodes=doc.SelectNodes(xpath);
             if(node == null || nodes.Count == 0
             {
                Console.WriteLine("No employees found with salary greater than {0}.", luongTren);
                return;
            };
            foreach(XmlNode node in nodes)
            {
                string ma=node.SelectSingleNode("MaNV")?.InnerText;
                string hoten=node.SelectSingleNode("HoTen")?.InnerText;
                string luong=node.SelectSingleNode("Luong")?.InnerText;
                Console.WriteLine($"MaNV: {ma}, HoTen: {hoten}, Luong: {luong}");
            }
    }
    static void Handle
}
}
