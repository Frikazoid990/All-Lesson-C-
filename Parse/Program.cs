using System.Text;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace Parse;

class Program
{
    static void Main(string[] args)
    {
        string template = "<table>\\n<tr><td align=\\\"center\\\"><b>Сработка аналогового датчика!</b></td></tr>\\n" +
                          "<tr><td><b>[event_date]</b> в <b>[event_time]</b> у объекта <b>[object]</b>, модель <b>«[model]»</b><span @visible=\\\"@isset([geozone])=true\\\">, " +
                          "в геозоне <b>[geozone]</b></span><span @visible=\\\"@isset([geozone])=false\\\">, " +
                          "по адресу <b>[address]</b></span>, зафиксирована сработка аналогового датчика <b>«[sensor]»</b>." +
                          "<br>Значение датчика в момент сработки <b>[value]</b> единиц.<br>Диапазон значений для уведомлений от " +
                          "<b>[minvalue]</b> до <b>[maxvalue]</b> единиц.</td></tr>\\n<tr><td><br><em>Время генерации уведомления<br>[create_date] в" +
                          " [create_time]</em></td></tr>\\n</table>";

        string result = TemplateCleaner.ParseWithAngleSharp(template);

        Console.WriteLine(result);
    }
}

public static class TemplateCleaner
{
    public static string ParseWithAngleSharp(string template)
    {
        if (string.IsNullOrEmpty(template))
            return "";
        
        template = template
            .Replace("\\n", "") 
            .Replace("\\\"", "\"");
        try
        {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(template);
            var spanNode  = document.QuerySelectorAll("span");
            string text = document.Body?.TextContent ?? document.DocumentElement?.TextContent ?? "";
            return text.Trim();
        }
        catch
        {
            throw new Exception("Unluck");
        }
    }
    
}