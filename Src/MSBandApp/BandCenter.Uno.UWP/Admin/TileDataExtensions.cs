using Microsoft.Band.Tiles;

namespace Microsoft.Band.Admin;

public static class TileDataExtensions
{
    public static AdminBandTile ToAdminBandTile(this TileData data)
    {
        string name = "(DEFAULT NAME)";
        if (data.FriendlyName != null && data.FriendlyNameLength > 0)
        {
            name = data.FriendlyName;
        }
        return new AdminBandTile(data.AppID, name, (AdminTileSettings)data.SettingsMask, data.Icon)
        {
            OwnerId = data.OwnerId
        };
    }
}
