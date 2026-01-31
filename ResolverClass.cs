namespace PngImageStaticWebAsset;
public class ResolverClass : IStaticWebAssetSpec
{
    string IStaticWebAssetSpec.GetGlobalName => "PngImageAssets";
    BasicList<string> IStaticWebAssetSpec.ExtensionsAllowed => [".png"];
}