using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Domain
{
    public class FreeBookMap
    {
        public string title { get; set; }
        public string url { get; set; }
        public string language { get; set; }
        public Epoch[] epochs { get; set; }
        public Genre[] genres { get; set; }
        public Kind[] kinds { get; set; }
        public Author[] authors { get; set; }
        public Translator[] translators { get; set; }
        public Fragment_Data fragment_data { get; set; }
        public object[] children { get; set; }
        public object parent { get; set; }
        public bool preview { get; set; }
        public string epub { get; set; }
        public string mobi { get; set; }
        public string pdf { get; set; }
        public string html { get; set; }
        public string txt { get; set; }
        public string fb2 { get; set; }
        public string xml { get; set; }
        public Medium[] media { get; set; }
        public string audio_length { get; set; }
        public string cover_color { get; set; }
        public string simple_cover { get; set; }
        public string cover_thumb { get; set; }
        public string cover { get; set; }
        public string simple_thumb { get; set; }
        public string isbn_pdf { get; set; }
        public string isbn_epub { get; set; }
        public string isbn_mobi { get; set; }
    }

    public class Fragment_Data
    {
        public string title { get; set; }
        public string html { get; set; }
    }

    public class Epoch
    {
        public string url { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Genre
    {
        public string url { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Kind
    {
        public string url { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Author
    {
        public string url { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Translator
    {
        public string name { get; set; }
    }

    public class Medium
    {
        public string url { get; set; }
        public string director { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string artist { get; set; }
    }

}
