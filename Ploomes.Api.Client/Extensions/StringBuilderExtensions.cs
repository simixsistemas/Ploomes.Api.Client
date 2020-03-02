using System.Text;

namespace Ploomes.Api.Client.Extensions {
    public static class StringBuilderExtensions {
        public static bool IsEmpty(this StringBuilder stringBuilder) =>
            !(stringBuilder?.Length > 0);
    }
}
