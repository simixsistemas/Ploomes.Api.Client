using System.Text;

namespace Ploomes.Api.Client.Extensions {
    internal static class StringBuilderExtensions {
        public static bool IsEmpty(this StringBuilder stringBuilder) =>
            !(stringBuilder?.Length > 0);
    }
}
