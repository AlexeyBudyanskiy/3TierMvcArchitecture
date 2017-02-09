using System.Configuration;

namespace Vocabulary.WEB.Infrastructure
{
    public class GlovalVaribles
    {
        public static string ExampleVariable => ConfigurationManager.AppSettings["Example"];
    }
}