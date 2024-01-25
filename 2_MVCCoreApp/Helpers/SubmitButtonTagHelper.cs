using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _2_MVCCoreApp.TagHelpers
{
    [HtmlTargetElement("submit-button", TagStructure = TagStructure.WithoutEndTag)]
    public class SubmitButtonTagHelper : TagHelper
    {
        public string Text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("class", "btn btn-primary"); // Add Bootstrap button styling

            // You can customize the button text or use a default value
            output.Content.SetContent(Text ?? "Submit");
        }
    }
}
