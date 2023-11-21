using System.Media;

namespace Toastr.Winforms;

internal class PlaySounds
{
    public static void Success()
    {
        SoundPlayer player =
            new SoundPlayer(Properties.Resources.success_sound);
        player.Play();
    }

    public static void Error()
    {
        SoundPlayer player =
            new SoundPlayer(Properties.Resources.error_sound);
        player.Play();
    }

    public static void Warning()
    {
        SoundPlayer player =
            new SoundPlayer(Properties.Resources.warning_sound);
        player.Play();
    }
}