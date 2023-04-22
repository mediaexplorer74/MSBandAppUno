namespace Microsoft.Band.Admin;

public enum KeyboardMessageType : byte
{
    Init,
    Stroke,
    CandidatesForNextWord,
    CandidatesForWord,
    End,
    PreInit,
    TryReleaseClient,
    PreInitV2
}
