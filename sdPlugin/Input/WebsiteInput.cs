namespace sdPlugin.Input
{
    public class WebsiteInput : BaseInput
    {
        public string Url { get; set; }
        public WebsiteInput(string name, string url = "") : base(name)
        {
            Url = url;
        }
    }
}
