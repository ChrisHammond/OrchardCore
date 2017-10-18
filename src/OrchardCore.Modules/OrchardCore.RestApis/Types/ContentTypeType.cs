using GraphQL.Types;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace OrchardCore.RestApis.Types
{
    public class ContentTypeType : ObjectGraphType<ContentTypeDefinition>
    {
        public ContentTypeType(IContentManager contentManager)
        {
            Name = typeof(ContentTypeDefinition).Name;

            Field(h => h.Name).Description("The content type.");
        }
    }
}
