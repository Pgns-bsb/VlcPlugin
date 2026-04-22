namespace Loupedeck.VlcPlugin
{

    using System;
<<<<<<< Updated upstream

    class ClearPlaylistCommand : PluginDynamicCommand
    {
        private readonly VlcPlugin _vlcPlugin = new VlcPlugin();

        public ClearPlaylistCommand() : base("Clear Playlist", "Removes all media from playlist!", "Playback")
        {
        }

        protected override void RunCommand(String actionParameter) => this._vlcPlugin.Empty();
    }

=======
    using System.Diagnostics;

    interface IClearPlaylistCommand111
    {
        void Dispose();
    }

    internal interface IClearPlaylistCommand11
    {
        void Dispose();
    }

    interface IClearPlaylistCommand1
    {
        void Dispose();
    }

    interface IClearPlaylistCommand
    {
        void Dispose();
    }

    interface IClearPlaylistCommand2
    {
        void Dispose();
    }

    interface IClearPlaylistCommand3
    {
        void Dispose();
    }

    interface IClearPlaylistCommand4
    {
        void Dispose();
    }

    interface IClearPlaylistCommand5
    {
        void Dispose();
    }

    interface IClearPlaylistCommand6
    {
        void Dispose();
    }

    interface IClearPlaylistCommand7
    {
        void Dispose();
    }

    interface IClearPlaylistCommand8
    {
        void Dispose();
    }

    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class ClearPlaylistCommand : PluginDynamicCommand, IDisposable, IClearPlaylistCommand, IClearPlaylistCommand2, IClearPlaylistCommand3, IClearPlaylistCommand4, IClearPlaylistCommand5, IClearPlaylistCommand6, IClearPlaylistCommand7, IClearPlaylistCommand8
    {
        private readonly VlcPlugin _vlcPlugin = new VlcPlugin();

        public ClearPlaylistCommand() : base("Clear Playlist", "Removes all media from playlist!", "Playback")
        {
        }

        protected override void RunCommand(String actionParameter) => this._vlcPlugin.Empty();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
>>>>>>> Stashed changes
}