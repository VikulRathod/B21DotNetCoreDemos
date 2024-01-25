using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _2_MVCCoreApp.TagHelpers
{
    [HtmlTargetElement("command-button")]
    public class CommandButtonTagHelper : TagHelper
    {
        [HtmlAttributeName("value")]
        public string Value { get; set; }

        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        public override void Process(TagHelperContext context,
            TagHelperOutput output)
        {
            //string html = $"<input type='submit' value='{Value}' class='{CssClass}' />";
            //output.Content.SetHtmlContent(html);

            //output.TagName = "button";
            //// output.Attributes.Add("type", "submit");
            //// output.Attributes.Add("value", Value);
            //output.Content.SetContent(Value);
            //output.Attributes.Add("class", CssClass);

            string btnTag = $"<button type='submit' name='command' class='{CssClass}'>{Value}</button>";
            output.Content.SetHtmlContent(btnTag);
        }
    }
}
