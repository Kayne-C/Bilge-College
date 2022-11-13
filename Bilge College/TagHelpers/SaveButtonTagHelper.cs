using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bilge_College.TagHelpers
{
    [HtmlTargetElement("button-save")]
    public class SaveButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("type", "submit");
            output.Attributes.Add("class", "btn btn-success");
            output.Attributes.Add("value", "Kaydet");
            output.Content.AppendHtml("<i class='fa fa-save'></i> Kaydet");
            base.Process(context, output);
        }
    }

}
